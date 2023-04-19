using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni_template
{
    
    public partial class RSA : Form
    {
        private ToolTip helpToolTip;
        private TextBox helpTextBox;
        BigInteger d;

        public static string DecryptRSA(byte[] encryptedData, string privateKeyXml)
        {
            // Create a new instance of the RSACryptoServiceProvider
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            // Load the private key into the RSACryptoServiceProvider
            rsa.FromXmlString(privateKeyXml);

            // Decrypt the data using the RSACryptoServiceProvider
            byte[] decryptedData = rsa.Decrypt(encryptedData, false);

            // Convert the decrypted data to a string and return it
            return Encoding.UTF8.GetString(decryptedData);
        }
        BigInteger[] FactorizeModulus(BigInteger nnn)
        {
            // Find the prime factors of n using trial division
            // Split the range of possible factors into equal parts for parallelization

            int cores = Environment.ProcessorCount;
            BigInteger rangeSize = (nnn / cores) + 1;
            BigInteger rangeStart = 1;
            BigInteger rangeEnd = rangeStart + rangeSize;

            // Divide the range of possible factors into chunks for parallel processing
            BigInteger[][] ranges = new BigInteger[cores][];
            for (int i = 0; i < cores; i++)
            {
                ranges[i] = new BigInteger[] { rangeStart, rangeEnd };
                rangeStart = rangeEnd;
                rangeEnd = rangeStart + rangeSize;
            }

            // Find the prime factors of n in parallel
            ConcurrentBag<BigInteger> factors = new ConcurrentBag<BigInteger>();
            Parallel.ForEach(ranges, range =>
            {
                for (BigInteger i = range[0]; i < range[1]; i += 2)
                {
                    if (nnn % i == 0)
                    {
                        factors.Add(i);
                        factors.Add(nnn / i);
                    }
                }
            });
            return factors.ToArray();
        }
        BigInteger CalculatePrivateKey(BigInteger pp, BigInteger qq, BigInteger ee)
        {
            // Calculate the private key d using the Chinese remainder theorem
            BigInteger phi = (pp - 1) * (qq - 1);
            BigInteger ddd = BigInteger.ModPow(ee, -1, phi);

            return ddd;
        }
        public RSA()
        {
            InitializeComponent();
            InitializeHelpButton();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RSA_Load(object sender, EventArgs e)
        {

        }

        private void buttonIzracun_Click(object sender, EventArgs e)
        {
            string nn = textBoxN.Text;
            string ee = textBoxE.Text;
            string cc = textBoxC.Text;
            BigInteger n = BigInteger.Parse(nn);
            BigInteger eee = BigInteger.Parse(ee);
            BigInteger p = BigInteger.One, q = BigInteger.One;
            if(textBoxD.Text == " ")
            {
                Parallel.ForEach(FactorizeModulus(n), factor =>
                {
                    if (p == BigInteger.One)
                    {
                        p = factor;
                    }
                    else if (q == BigInteger.One)
                    {
                        q = factor;
                    }
                });
                d = CalculatePrivateKey(p, q, eee);
            }
            else
            {
                d = BigInteger.Parse(textBoxD.Text);
            }
            byte[] encryptedData = new byte[] { Convert.ToByte(cc) };
            string privateKeyXml = Convert.ToString(d);
            string decryptedText = DecryptRSA(encryptedData, privateKeyXml);
            textBoxRjesenje.Text = decryptedText;
            
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
            helpToolTip.SetToolTip(helpButton, "Click this button to get helpful information about RSA.");
            // Add ButtonClick event handler
            helpButton.Click += ButtonClick;

            // Create a TextBox
            helpTextBox = new TextBox
            {
                Location = new Point(helpButton.Location.X, helpButton.Location.Y - 65), // Above the button
                Size = new Size(400, 60), // Adjust the size as needed
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
            helpTextBox.Text = "1." + "https://www.dcode.fr/rsa-cipher" + Environment.NewLine + 
                "2." + "https://www.devglan.com/online-tools/rsa-encryption-decryption" + Environment.NewLine +
                "3." + "https://www.cs.drexel.edu/~jpopyack/Courses/CSP/Fa17/notes/10.1_Cryptography/RSA_Express_EncryptDecrypt_v2.html";

            helpTextBox.Visible = !helpTextBox.Visible;
        }
    }
}
