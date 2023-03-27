using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Zavrsni_template
{
    public partial class DiskImage : Form
    {
        public DiskImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sourceDisk = textBoxDisk.Text;
            string imageFile = textBoxImageFile.Text;

            using (FileStream sourceStream = new FileStream(sourceDisk, FileMode.Open, FileAccess.Read))
            using (FileStream targetStream = new FileStream(imageFile, FileMode.Create, FileAccess.Write))
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    targetStream.Write(buffer, 0, bytesRead);
                    md5.TransformBlock(buffer, 0, bytesRead, null, 0);
                }
                md5.TransformFinalBlock(buffer, 0, 0);
                byte[] hash = md5.Hash;
                MessageBox.Show("Disk image created with MD5 hash value: " + BitConverter.ToString(hash));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imageFile = textBoxImageFile.Text; // change this to the name and path of the disk image file you want to analyze

            // read the disk image into a byte array
            byte[] diskImageBytes = File.ReadAllBytes(imageFile);

            // search for a specific string pattern in the image
            string searchString = textBoxString.Text; // change this to the string you want to search for in the disk image
            int index = FindStringInBytes(searchString, diskImageBytes);
            if (index >= 0)
            {
                MessageBox.Show("Search string found at offset " + index.ToString("X"));
            }
            else
            {
                MessageBox.Show("Search string not found.");
            }
        }
        private int FindStringInBytes(string searchString, byte[] bytes)
        {
            int index = -1;
            byte[] searchBytes = Encoding.ASCII.GetBytes(searchString);
            for (int i = 0; i <= bytes.Length - searchBytes.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < searchBytes.Length; j++)
                {
                    if (bytes[i + j] != searchBytes[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
