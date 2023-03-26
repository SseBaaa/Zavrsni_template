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
    }
}
