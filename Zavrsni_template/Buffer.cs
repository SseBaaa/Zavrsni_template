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
    public partial class Buffer : Form
    {
        public Buffer()
        {
            InitializeComponent();
        }

        private void exploitButton_Click(object sender, EventArgs e)
        {
            string vulnerableProgramPath = @"path\to\vulnerable.exe";
            string exploit = new string('A', 64 + 4);

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = vulnerableProgramPath,
                Arguments = $"\"{exploit}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            Process process = new Process { StartInfo = startInfo };
            try
            {
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                outputTextBox.AppendText($"Output: {output}\n");
            }
            catch (Exception ex)
            {
                outputTextBox.AppendText($"Exception: {ex.Message}\n");
            }
            finally
            {
                process.Dispose();
            }
        }
        
    }
}
