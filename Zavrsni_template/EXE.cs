using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni_template
{
    public partial class EXE : Form
    {
        string filename;
        public EXE()
        {
            InitializeComponent();
        }



        private void EXE_Load(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                filename = dlg.FileName;
            }
            try
            {
                string targetExePath = filename;
                int lowerBound = Convert.ToInt32(textBoxLower.Text); // Adjust this based on the range of possible numbers
                int upperBound = Convert.ToInt32(textBoxUpper.Text); // Adjust this based on the range of possible numbers
                int guessedNumber = GuessTheNumber(targetExePath, lowerBound, upperBound);
                textBoxOutput.Text = $"Guessed number: {guessedNumber}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GuessTheNumber(string exePath, int lowerBound, int upperBound)
        {
            while (lowerBound <= upperBound)
            {
                int mid = lowerBound + (upperBound - lowerBound) / 2;
                string output = RunExeAndGetOutput(exePath, mid.ToString());

                // If the output is not empty, the guess is correct
                if (!string.IsNullOrEmpty(output.Trim()))
                {
                    return mid;
                }
                else
                {
                    // If the output is empty, we have to decide how to update the search space
                    // Here we implement a simple "coin flip" logic
                    // You can change this to use any other strategy that works for your specific problem

                    Random rnd = new Random();
                    int coinFlip = rnd.Next(0, 2);
                    if (coinFlip == 0)
                    {
                        lowerBound = mid + 1;
                    }
                    else
                    {
                        upperBound = mid - 1;
                    }
                }
            }

            throw new Exception("Number not found");
        }

        private string RunExeAndGetOutput(string exePath, string input)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = exePath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                CreateNoWindow = true
            };

            using (var process = new Process { StartInfo = startInfo })
            {
                process.Start();

                using (StreamWriter sw = process.StandardInput)
                using (StreamReader sr = process.StandardOutput)
                {
                    sw.WriteLine(input);
                    sw.WriteLine("exit");
                    string output = sr.ReadToEnd();

                    process.WaitForExit();
                    return output;
                }
            }
        }
    }
}
