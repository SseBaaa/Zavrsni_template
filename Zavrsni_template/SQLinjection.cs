using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni_template
{
    public partial class SQLinjection : Form
    {
        private ToolTip helpToolTip;
        private TextBox helpTextBox;
        public SQLinjection()
        {
            InitializeComponent();
            InitializeHelpButton();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string targetUrl = textBoxURL.Text;

            // Use SQLMap command line options to scan the target
            string sqlMapArgs = "-u " + targetUrl + " --batch --dump-all --forms --threads 10 --output-dir=results";

            // Start SQLMap process and redirect output to a text file
            Process sqlMapProcess = new Process();
            sqlMapProcess.StartInfo.FileName = "sqlmap.exe";
            sqlMapProcess.StartInfo.Arguments = sqlMapArgs;
            sqlMapProcess.StartInfo.RedirectStandardOutput = true;
            sqlMapProcess.StartInfo.RedirectStandardError = true;
            sqlMapProcess.StartInfo.UseShellExecute = false;

            string outputFile = "Zavrsni_tamplate.resources.sqlmap_report.txt";
            
            using (StreamWriter sw = File.CreateText(outputFile))
            {
                sqlMapProcess.OutputDataReceived += (senderProcess, outputLine) =>
                {
                    sw.WriteLine(outputLine.Data);
                };

                sqlMapProcess.ErrorDataReceived += (senderProcess, errorLine) =>
                {
                    sw.WriteLine(errorLine.Data);
                };

                // Start the SQLMap process and wait for it to finish
                sqlMapProcess.Start();
                sqlMapProcess.BeginOutputReadLine();
                sqlMapProcess.BeginErrorReadLine();
                sqlMapProcess.WaitForExit();
            }

            // Read the SQLMap report and display in the text box
            if (File.Exists(outputFile))
            {
                string report = File.ReadAllText(outputFile);
                textBoxReport.Text = report;
            }
            else
            {
                textBoxReport.Text = "SQLMap report not found.";
            }
        }

        private void SQLinjection_Load(object sender, EventArgs e)
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
            helpToolTip.SetToolTip(helpButton, "Click this button to get helpful information about SQL injection.");
            // Add ButtonClick event handler
            helpButton.Click += ButtonClick;

            // Create a TextBox
            helpTextBox = new TextBox
            {
                Location = new Point(helpButton.Location.X, helpButton.Location.Y - 135), // Above the button
                Size = new Size(110, 130), // Adjust the size as needed
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
            helpTextBox.Text = "1." + "https://portswigger.net/web-security/sql-injection" + Environment.NewLine + Environment.NewLine +
                "2." + "https://www.w3schools.com/sql/sql_injection.asp" + Environment.NewLine + Environment.NewLine +
                "3." + "https://owasp.org/www-community/attacks/SQL_Injection";

            helpTextBox.Visible = !helpTextBox.Visible;
        }
    }
}
