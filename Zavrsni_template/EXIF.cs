
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExifLib;

namespace Zavrsni_template
{
    public partial class EXIF : Form
    {
        private ToolTip helpToolTip;
        private TextBox helpTextBox;

        public EXIF()
        {
            InitializeComponent();
            InitializeHelpButton();
        }

        private void EXIF_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                Dictionary<string, string> exifData = GetExifData(imagePath);
                DisplayExifData(exifData);
            }
        }
        private Dictionary<string, string> GetExifData(string imagePath)
        {
            Dictionary<string, string> exifData = new Dictionary<string, string>();

            try
            {
                using (ExifReader reader = new ExifReader(imagePath))
                {
                    foreach (ExifTags tag in Enum.GetValues(typeof(ExifTags)))
                    {
                        object value;
                        if (reader.GetTagValue(tag, out value))
                        {
                            exifData.Add(tag.ToString(), value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error extracting EXIF data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return exifData;
        }

        private void DisplayExifData(Dictionary<string, string> exifData)
        {
            dgvExifData.Rows.Clear();
            dgvExifData.Columns.Clear();

            dgvExifData.Columns.Add("Tag", "Tag");
            dgvExifData.Columns.Add("Value", "Value");

            foreach (var entry in exifData)
            {
                dgvExifData.Rows.Add(entry.Key, entry.Value);
            }
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
            helpToolTip.SetToolTip(helpButton, "Click this button to get helpful information about EXIF data.");
            // Add ButtonClick event handler
            helpButton.Click += ButtonClick;

            // Create a TextBox
            helpTextBox = new TextBox
            {
                Location = new Point(helpButton.Location.X, helpButton.Location.Y - 135), // Above the button
                Size = new Size(130, 130), // Adjust the size as needed
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
            helpTextBox.Text = "1." + "https://en.wikipedia.org/wiki/Exif" + Environment.NewLine + Environment.NewLine +
                "2." + "https://petapixel.com/what-is-exif-data/" + Environment.NewLine + Environment.NewLine +
                "3." + "https://jimpl.com/";

            helpTextBox.Visible = !helpTextBox.Visible;
        }
    }

}

