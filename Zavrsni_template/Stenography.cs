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

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            // Open the source image and get the bitmap data
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);

                // Create a new bitmap for the decoded image
                Bitmap decodedImage = new Bitmap(bmp.Width, bmp.Height);

                // Loop through the pixels of the source image and extract the least significant bit of each color channel
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color pixel = bmp.GetPixel(x, y);
                        byte r = (byte)(pixel.R & 1);
                        byte g = (byte)(pixel.G & 1);
                        byte b = (byte)(pixel.B & 1);
                        byte decodedByte = (byte)((r << 2) | (g << 1) | b);
                        Color decodedPixel = Color.FromArgb(decodedByte, decodedByte, decodedByte);
                        decodedImage.SetPixel(x, y, decodedPixel);
                    }
                }

                // Save the decoded image
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    decodedImage.Save(saveFileDialog1.FileName);
                }

            }
        }
    }
}
