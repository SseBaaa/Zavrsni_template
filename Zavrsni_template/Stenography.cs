using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni_template
{
    public partial class Stenography : Form
    {
        private ToolTip helpToolTip;
        private TextBox helpTextBox;
        public Stenography()
        {
            InitializeComponent();
            InitializeHelpButton();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                Bitmap image = new Bitmap(imagePath);
                string decodedMessage = DecodeMessageFromImage(image);
                txtDecodedMessage.Text = decodedMessage;
            }
        }
        private string DecodeMessageFromImage(Bitmap image)
        {
            int colorUnitIndex = 0;
            int charValue = 0;
            StringBuilder hiddenMessage = new StringBuilder();

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color pixel = image.GetPixel(j, i);

                    // Extracting LSBs from the pixel's color channels
                    int redLSB = pixel.R & 1;
                    int greenLSB = pixel.G & 1;
                    int blueLSB = pixel.B & 1;

                    charValue = SetBitValue(charValue, colorUnitIndex % 8, redLSB);
                    colorUnitIndex++;

                    if (colorUnitIndex % 8 == 0)
                    {
                        if (charValue == 0)
                        {
                            return hiddenMessage.ToString();
                        }

                        hiddenMessage.Append((char)charValue);
                        charValue = 0;
                    }

                    charValue = SetBitValue(charValue, colorUnitIndex % 8, greenLSB);
                    colorUnitIndex++;

                    if (colorUnitIndex % 8 == 0)
                    {
                        if (charValue == 0)
                        {
                            return hiddenMessage.ToString();
                        }

                        hiddenMessage.Append((char)charValue);
                        charValue = 0;
                    }

                    charValue = SetBitValue(charValue, colorUnitIndex % 8, blueLSB);
                    colorUnitIndex++;

                    if (colorUnitIndex % 8 == 0)
                    {
                        if (charValue == 0)
                        {
                            return hiddenMessage.ToString();
                        }

                        hiddenMessage.Append((char)charValue);
                        charValue = 0;
                    }
                }
            }

            return hiddenMessage.ToString();
        }

        private int SetBitValue(int oldValue, int bitIndex, int bitValue)
        {
            int mask = 1 << bitIndex;
            int newValue = oldValue & ~mask;

            if (bitValue == 1)
            {
                newValue |= mask;
            }

            return newValue;
        }

        private void Stenography_Load(object sender, EventArgs e)
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
            helpToolTip.SetToolTip(helpButton, "Click this button to get helpful information about Stenography.");
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
            helpTextBox.Text = "1." + "https://infosecwriteups.com/steganography-ctfs-73f7b310b1f7" + Environment.NewLine + Environment.NewLine +
                "2." + "https://medium.com/@FourOctets/ctf-tidbits-part-1-steganography-ea76cc526b40" + Environment.NewLine + Environment.NewLine +
                "3." + "https://ctf101.org/forensics/what-is-stegonagraphy/";

            helpTextBox.Visible = !helpTextBox.Visible;
        }
    }
}
