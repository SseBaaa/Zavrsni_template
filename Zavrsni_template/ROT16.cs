using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni_template
{
    
    public partial class ROT16 : Form
    {
        private ToolTip helpToolTip;
        private TextBox helpTextBox;
        public ROT16()
        {
            InitializeComponent();
            InitializeHelpButton();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");
            foreach (char c in textBoxROT16.Text)
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int code = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    result.Append((char)code);
                }
                else
                    result.Append(c);
            }
            textBoxDecipher.AppendText(Convert.ToString(result));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ROT16_Load(object sender, EventArgs e)
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
            helpToolTip.SetToolTip(helpButton, "Click this button to get helpful information about Rot16.");
            // Add ButtonClick event handler
            helpButton.Click += ButtonClick;

            // Create a TextBox
            helpTextBox = new TextBox
            {
                Location = new Point(helpButton.Location.X, helpButton.Location.Y - 65), // Above the button
                Size = new Size(250, 60), // Adjust the size as needed
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
            helpTextBox.Text = "1." + "https://www.dcode.fr/rot-cipher" + Environment.NewLine +
                "2." + "https://www.ultimatesolver.com/en/rot-encryption" + Environment.NewLine +
                "3." + "https://www.cachesleuth.com/rot.html";

            helpTextBox.Visible = !helpTextBox.Visible;
        }
    }
}
