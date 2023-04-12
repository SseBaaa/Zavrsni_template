
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExifLib;

namespace Zavrsni_template
{
    public partial class EXIF : Form
    {
        
        public EXIF()
        {
            InitializeComponent();
        }

        private void EXIF_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                Dictionary<string, string> exifData = GetExifData(imagePath);
                DisplayExifData(exifData);
            }
        }
        private Dictionary<string, string> GetExifData(string imagePath)
        {
            Dictionary<string, string> exifData = new Dictionary<string, string>();

            try
            {
                using (ExifReader reader = new ExifReader(imagePath))
                {
                    foreach (ExifTags tag in Enum.GetValues(typeof(ExifTags)))
                    {
                        object value;
                        if (reader.GetTagValue(tag, out value))
                        {
                            exifData.Add(tag.ToString(), value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error extracting EXIF data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return exifData;
        }

        private void DisplayExifData(Dictionary<string, string> exifData)
        {
            dgvExifData.Rows.Clear();
            dgvExifData.Columns.Clear();

            dgvExifData.Columns.Add("Tag", "Tag");
            dgvExifData.Columns.Add("Value", "Value");

            foreach (var entry in exifData)
            {
                dgvExifData.Rows.Add(entry.Key, entry.Value);
            }
        }



    }

}

