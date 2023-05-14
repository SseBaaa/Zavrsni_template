using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using OtpNet;
using System.Drawing.Drawing2D;

namespace Zavrsni_template
{
 

    public partial class Basee : Form
    {
        private ToolTip helpToolTip;
        private TextBox helpTextBox;
        public Basee()
        {
            InitializeComponent();
            InitializeHelpButton();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
             string Base32Decode(string input)
            {
                const string Base32Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

                // Remove padding characters from the input string
                input = input.TrimEnd('=');

                // Convert each character in the input string to its corresponding 5-bit value
                var bitString = "";
                foreach (char c in input)
                {
                    int value = Base32Alphabet.IndexOf(char.ToUpper(c));
                    if (value >= 0)
                    {
                        bitString += Convert.ToString(value, 2).PadLeft(5, '0');
                    }
                    else
                    {
                        throw new ArgumentException("Invalid character in the Base32 input.");
                    }
                }

                // Adjust the length of the bit string to be a multiple of 8
                int paddingCount = (8 - (bitString.Length % 8)) % 8;
                bitString = bitString.PadRight(bitString.Length + paddingCount, '0');

                // Convert the bit string to bytes and then to a string
                var bytes = new byte[bitString.Length / 8];
                for (int i = 0; i < bitString.Length; i += 8)
                {
                    bytes[i / 8] = Convert.ToByte(bitString.Substring(i, 8), 2);
                }

                return System.Text.Encoding.UTF8.GetString(bytes);
            }
            string Base64Decode(string input)
            {
                byte[] bytes = Convert.FromBase64String(input);
                return System.Text.Encoding.UTF8.GetString(bytes);
            }

            if (comboBox1.SelectedIndex == 0) 
            {
                byte[] byteArray = Enumerable.Range(0, textBox1.Text.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(textBox1.Text.Substring(x, 2), 16))
                             .ToArray();
                string decodedString = Encoding.UTF8.GetString(byteArray);
                textBox2.Text = decodedString;
            }
            if(comboBox1.SelectedIndex == 1)
            {
                string base32String = textBox1.Text; 
                string decodedText = Base32Decode(base32String);
                textBox2.AppendText(decodedText);
            }
            if(comboBox1.SelectedIndex == 2)
            {
                string base64String = textBox1.Text;
                string decodedText1 = Base64Decode(base64String);
                textBox2.AppendText(decodedText1);
            }
               

               

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Basee_SizeChanged(object sender, EventArgs e)
        {

        }

        private void Basee_Load(object sender, EventArgs e)
        {

        }
        private void InitializeHelpButton()
        {
            // Create a round button
            RoundButton helpButton = new RoundButton
            {
                Location = new Point(30, 310), // Change the location based on your layout
                Size = new Size(80, 80), // Adjust the size as needed
                FlatStyle = FlatStyle.Flat,
                BackgroundImageLayout = ImageLayout.Stretch,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left

            };

            // Set the button's background image
            helpButton.BackgroundImage = Properties.Resources.pictureForProgram;

            // Add the button to the form
            this.Controls.Add(helpButton);
            helpButton.BringToFront();
            // Create a ToolTip
            helpToolTip = new ToolTip
            {
                // Set the tooltip properties, if needed
                AutoPopDelay = 5000,
                InitialDelay = 1000,
                ReshowDelay = 500,
                ShowAlways = true
            };
            helpToolTip.SetToolTip(helpButton, "Click this button to get helpful information about Base.");
            // Add ButtonClick event handler
            helpButton.Click += ButtonClick;

            // Create a TextBox
            helpTextBox = new TextBox
            {
                Location = new Point(helpButton.Location.X, helpButton.Location.Y - 65), // Above the button
                Size = new Size(150, 100), // Adjust the size as needed
                Visible = false, // Initially hide the TextBox
                ReadOnly = true, // Make the TextBox read-only, so the text can be copied but not modified
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };

            // Add the TextBox to the form
            this.Controls.Add(helpTextBox);
            helpTextBox.BringToFront();
        }
        private void ButtonClick(object sender, EventArgs e)
        {

            // Set the TextBox text to the desired message
            helpTextBox.Text = "1." + "https://www.dcode.fr/tools-list#character_encoding" + Environment.NewLine + Environment.NewLine + 
                "2." + "https://pentesttools.net/basecrack-best-decoder-tool-for-base-encoding-schemes/" + Environment.NewLine + Environment.NewLine +
                "3." + "https://www.base64decode.net/";

            helpTextBox.Visible = !helpTextBox.Visible;
        }
    }
        
    }

