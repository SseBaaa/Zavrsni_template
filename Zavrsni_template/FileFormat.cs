using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zavrsni_template
{
    public partial class FileFormat : Form
    {
        string filename;
        string headerSignature = "";
        public FileFormat()
        {
            InitializeComponent();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                filename = dlg.FileName;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (comboBoxFile.SelectedIndex == 0)
            {
                headerSignature = "\x89\x50\x4E\x47\x0D\x0A\x1A\x0A"; //png file header signature
            }
            if(comboBoxFile.SelectedIndex == 1)
            {
                headerSignature = "PK\x03\x04"; // zip file header signature
            }
            if(comboBoxFile.SelectedIndex == 2)
            {
                headerSignature = "Rar!\x1A\x07\x00"; // rar file header signature
            }
            if(comboBoxFile.SelectedIndex == 3)
            {
                headerSignature = "\xFF\xD8";
            }
            if (comboBoxFile.SelectedIndex == 4)
            {
                headerSignature = "%PDF-";
            }

            using (FileStream fileStream = File.OpenRead(filename))
            {
                byte[] fileBytes = new byte[headerSignature.Length];
                int bytesRead = fileStream.Read(fileBytes, 0, headerSignature.Length);

                if (bytesRead != headerSignature.Length)
                {
                    Console.WriteLine("File is too short.");
                }
                else
                {
                    string headerString = System.Text.Encoding.ASCII.GetString(fileBytes);
                    if (headerString == headerSignature)
                    {
                        MessageBox.Show("File has a valid header", "Valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File dosent have a valid header", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
    }
}
