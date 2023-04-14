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

namespace Zavrsni_template
{
    public partial class Basee : Form
    {
        public Basee()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDecipher_Click(object sender, EventArgs e)
        {
           
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
                string ciphertext = textBox1.Text;
                byte[] data = Base32Decode(ciphertext);
                textBox2.AppendText(System.Text.Encoding.UTF8.GetString(data));
                
                byte[] Base32Decode(string input)
                {
                    input = input.Replace("=", "");
                    if (input.Length % 8 != 0)
                        throw new ArgumentException("Invalid length for Base32 input.");
                    byte[] output = new byte[input.Length * 5 / 8];
                    int outputIndex = 0;
                    for (int i = 0; i < input.Length; i += 8)
                    {
                        ulong value = 0;
                        for (int j = 0; j < 8; j++)
                        {
                            value <<= 5;
                            value |= Base32CharToValue(input[i + j]);
                        }
                        output[outputIndex++] = (byte)(value >> 32);
                        output[outputIndex++] = (byte)(value >> 24);
                        output[outputIndex++] = (byte)(value >> 16);
                        output[outputIndex++] = (byte)(value >> 8);
                        output[outputIndex++] = (byte)value;
                    }
                    return output;
                }
                ulong Base32CharToValue(char c)
                {
                    if (c >= 'A' && c <= 'Z')
                        return (ulong)(c - 'A');
                    if (c >= '2' && c <= '7')
                        return (ulong)(c - '2' + 26);
                    throw new ArgumentException("Invalid character in Base32 input.");
                }

               

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Basee_SizeChanged(object sender, EventArgs e)
        {

        }
    }
        
    }

