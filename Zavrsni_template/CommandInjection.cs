using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni_template
{
    
    public partial class CommandInjection : Form
    {
        public CommandInjection()
        {
            InitializeComponent();
           
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string filee;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                 filee = dlg.FileName;
            }
            lblStatus.Text = "Executing with command injection vulnerability...";
            ExecuteCommandWithInjection(dlg.FileName);
        }
        private void ExecuteCommandWithInjection(string filename)
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", "/c dir " + filename)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process p = new Process { StartInfo = psi };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            richTextBox1.Text = output;
        }

        private void btnExecuteSecure_Click(object sender, EventArgs e)
        {
            string filee;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                filee = dlg.FileName;
            }
            lblStatus.Text = "Executing securely without command injection...";
            ExecuteCommandSecure(dlg.FileName);
        }
        private void ExecuteCommandSecure(string filename)
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", $"/c dir \"{filename}\"")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process p = new Process { StartInfo = psi };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            richTextBox1.Text = output;
        }

        private void Filename_Click(object sender, EventArgs e)
        {
            
        }
    }
}
