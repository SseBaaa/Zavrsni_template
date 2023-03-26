using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
