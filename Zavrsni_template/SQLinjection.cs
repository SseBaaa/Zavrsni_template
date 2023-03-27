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
        public SQLinjection()
        {
            InitializeComponent();
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

            string outputFile = "results\\sqlmap_report.txt";
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
    }
}
