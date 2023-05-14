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
        private ToolTip helpToolTip;
        private TextBox helpTextBox;
        string filename;
        public FileFormat()
        {
            InitializeComponent();
            InitializeHelpButton();
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
        private void InitializeHelpButton()
        {
            // Create a round button
            RoundButton helpButton = new RoundButton
            {
                Location = new Point(17, 350), // Change the location based on your layout
                Size = new Size(80, 80), // Adjust the size as needed
                FlatStyle = FlatStyle.Flat,
                BackgroundImageLayout = ImageLayout.Stretch
            };

            // Set the button's background image
            helpButton.BackgroundImage = Properties.Resources.pictureForProgram;

            // Add the button to the form
            this.Controls.Add(helpButton);

            // Create a ToolTip
            helpToolTip = new ToolTip
            {
                // Set the tooltip properties, if needed
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,
                ShowAlways = true
            };
            helpToolTip.SetToolTip(helpButton, "Click this button to get helpful information about File formats and headers.");
            // Add ButtonClick event handler
            helpButton.Click += ButtonClick;

            // Create a TextBox
            helpTextBox = new TextBox
            {
                Location = new Point(helpButton.Location.X, helpButton.Location.Y - 135), // Above the button
                Size = new Size(150, 130), // Adjust the size as needed
                Visible = false, // Initially hide the TextBox
                ReadOnly = true, // Make the TextBox read-only, so the text can be copied but not modified
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };

            // Add the TextBox to the form
            this.Controls.Add(helpTextBox);
        }
        private void ButtonClick(object sender, EventArgs e)
        {

            // Set the TextBox text to the desired message
            helpTextBox.Text = "1." + "https://en.wikipedia.org/wiki/List_of_file_signatures" + Environment.NewLine + Environment.NewLine +
                "2." + "https://www.garykessler.net/library/file_sigs.html" + Environment.NewLine + Environment.NewLine +
                "3." + "https://www.microfocus.com/documentation/server-express/sx40/fhfile.htm";

            helpTextBox.Visible = !helpTextBox.Visible;
        }
    }
}
