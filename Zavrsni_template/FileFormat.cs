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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                try
                {
                    // Read the header of the file
                    string header = ReadFileHeader(filePath);

                    // Identify the file type based on the header
                    string fileType = GetFileType(header);

                    // Display the file type in the TextBox
                    txtHeader.Text = fileType;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private string GetFileType(string header)
        {
            Dictionary<string, string> fileSignatures = new Dictionary<string, string>
    {
        { "89504E47", ".png" },
        { "47494638", ".gif" },
        { "25504446", ".pdf" },
        { "FFD8FF", ".jpg" },
        { "49492A00", ".tif" },
        { "4D4D002A", ".tif" },
        { "504B0304", ".zip" },
        { "52617221", ".rar" },
        { "D0CF11E0", ".doc" },
        { "504B34", ".docx" },
        { "5A4D", ".exe" },
    };

            foreach (var signature in fileSignatures)
            {
                if (header.StartsWith(signature.Key))
                {
                    return signature.Value;
                }
            }

            return "Unknown";
        }

        private string ReadFileHeader(string filePath, int headerSize = 12)
        {
            byte[] headerBytes;

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                headerBytes = new byte[Math.Min(headerSize, fs.Length)];
                fs.Read(headerBytes, 0, headerBytes.Length);
            }

            // Convert the bytes to a string representation
            StringBuilder sb = new StringBuilder();

            foreach (byte b in headerBytes)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString().Trim();
        }

        private void FileFormat_Load(object sender, EventArgs e)
        {

        }
    }
}
