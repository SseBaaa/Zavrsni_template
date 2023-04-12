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
    public partial class Stenography : Form
    {
        public Stenography()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                Bitmap image = new Bitmap(imagePath);
                string decodedMessage = DecodeMessageFromImage(image);
                txtDecodedMessage.Text = decodedMessage;
            }
        }
        private string DecodeMessageFromImage(Bitmap image)
        {
            int colorUnitIndex = 0;
            int charValue = 0;
            StringBuilder hiddenMessage = new StringBuilder();

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color pixel = image.GetPixel(j, i);

                    // Extracting LSBs from the pixel's color channels
                    int redLSB = pixel.R & 1;
                    int greenLSB = pixel.G & 1;
                    int blueLSB = pixel.B & 1;

                    charValue = SetBitValue(charValue, colorUnitIndex % 8, redLSB);
                    colorUnitIndex++;

                    if (colorUnitIndex % 8 == 0)
                    {
                        if (charValue == 0)
                        {
                            return hiddenMessage.ToString();
                        }

                        hiddenMessage.Append((char)charValue);
                        charValue = 0;
                    }

                    charValue = SetBitValue(charValue, colorUnitIndex % 8, greenLSB);
                    colorUnitIndex++;

                    if (colorUnitIndex % 8 == 0)
                    {
                        if (charValue == 0)
                        {
                            return hiddenMessage.ToString();
                        }

                        hiddenMessage.Append((char)charValue);
                        charValue = 0;
                    }

                    charValue = SetBitValue(charValue, colorUnitIndex % 8, blueLSB);
                    colorUnitIndex++;

                    if (colorUnitIndex % 8 == 0)
                    {
                        if (charValue == 0)
                        {
                            return hiddenMessage.ToString();
                        }

                        hiddenMessage.Append((char)charValue);
                        charValue = 0;
                    }
                }
            }

            return hiddenMessage.ToString();
        }

        private int SetBitValue(int oldValue, int bitIndex, int bitValue)
        {
            int mask = 1 << bitIndex;
            int newValue = oldValue & ~mask;

            if (bitValue == 1)
            {
                newValue |= mask;
            }

            return newValue;
        }
    }
}
