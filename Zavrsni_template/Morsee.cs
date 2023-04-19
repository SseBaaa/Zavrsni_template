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
    public partial class Morsee : Form
    {
        private ToolTip helpToolTip;
        private TextBox helpTextBox;
        private readonly Dictionary<char, string> MorseCodeMap = new Dictionary<char, string>
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."}, {'G', "--."},
            {'H', "...."}, {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."},
            {'O', "---"}, {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"}, {'U', "..-"},
            {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"}, {'Z', "--.."}, {'0', "-----"},
            {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."},
            {'7', "--..."}, {'8', "---.."}, {'9', "----."}, {' ', "/"}
        };
        public Morsee()
        {
            InitializeComponent();
            InitializeHelpButton();
        }

        private void buttonIspisi_Click(object sender, EventArgs e)
        {
            string morseCode = textBoxMorse.Text;
            string[] morseWords = morseCode.Split(new[] { " / " }, StringSplitOptions.None);

            string result = "";
            foreach (string morseWord in morseWords)
            {
                string[] morseLetters = morseWord.Split(' ');
                foreach (string morseLetter in morseLetters)
                {
                    char c = TranslateMorseCode(morseLetter);
                    result += c == '\0' ? "?? " : $"{c} ";
                }

                result = result.TrimEnd() + " ";
            }

            textBoxText.Text = result.TrimEnd();
        }
        private char TranslateMorseCode(string morseCode)
        {
            foreach (var pair in MorseCodeMap)
            {
                if (pair.Value == morseCode)
                {
                    return pair.Key;
                }
            }

            return '\0';
        }


        private void Morsee_Load(object sender, EventArgs e)
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
            helpButton.BackgroundImage = Image.FromFile(@"C:\Users\SeBa\source\repos\Zavrsni_templateV13\Zavrsni_template\Resources\pictureForProgram.png"); // Replace with your image filename and extension

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
            helpToolTip.SetToolTip(helpButton, "Click this button to get helpful information about Morse code.");
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
            helpTextBox.Text = "1." + "https://morsedecoder.com/" + Environment.NewLine +
                "2." + "https://www.dcode.fr/morse-code" + Environment.NewLine +
                "3." + "https://md5decrypt.net/en/Morse-code/";

            helpTextBox.Visible = !helpTextBox.Visible;
        }
    }
}
