using ExifLib;
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

namespace Zavrsni_template
{
    public partial class EXIF : Form
    {
        string filename;
        public EXIF()
        {
            InitializeComponent();
        }

        private void EXIF_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                filename = dlg.FileName;
                MessageBox.Show(filename);
            }
        }
        private static string RenderTag(object tagValue)
        {
            // Arrays don't render well without assistance.
            var array = tagValue as Array;
            if (array != null)
            {
                // Hex rendering for really big byte arrays (ugly otherwise)
                if (array.Length > 20 && array.GetType().GetElementType() == typeof(byte))
                    return "0x" + string.Join("", array.Cast<byte>().Select(x => x.ToString("X2")).ToArray());

                return string.Join(", ", array.Cast<object>().Select(x => x.ToString()).ToArray());
            }

            return tagValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Image image = Image.FromFile(filename);
            textBoxResults.AppendText(Convert.ToString(Encoding.UTF8.GetString(image.GetPropertyItem(0x0100).Value)) + "\r\n");
            textBoxResults.AppendText(Convert.ToString(Encoding.UTF8.GetString(image.GetPropertyItem(0x0101).Value)) + "\r\n");
            textBoxResults.AppendText(Convert.ToString(Encoding.UTF8.GetString(image.GetPropertyItem(0x0110).Value)) + "\r\n");
            textBoxResults.AppendText(Convert.ToString(Encoding.UTF8.GetString(image.GetPropertyItem(0x0112).Value)) + "\r\n");
            textBoxResults.AppendText(Convert.ToString(Encoding.UTF8.GetString(image.GetPropertyItem(0x0131).Value)) + "\r\n");
            textBoxResults.AppendText(Convert.ToString(Encoding.UTF8.GetString(image.GetPropertyItem(0x0132).Value)) + "\r\n");
            textBoxResults.AppendText(Convert.ToString(Encoding.UTF8.GetString(image.GetPropertyItem(0x013c).Value)) + "\r\n");
            textBoxResults.AppendText(Convert.ToString(Encoding.UTF8.GetString(image.GetPropertyItem(0x8298).Value)) + "\r\n");
            textBoxResults.AppendText(Convert.ToString(Encoding.UTF8.GetString(image.GetPropertyItem(0x8825).Value)) + "\r\n");



            // Get the EXIF data
            //PropertyItem[] propertyItems = image.PropertyItems;

            // Display the EXIF data in the text box
            //textBoxResults.Clear();
            //foreach (PropertyItem propertyItem in propertyItems)
            //{
            //    textBoxResults.AppendText(string.Format("ID: 0x{0:x}\r\nType: {1}\r\nValue: {2}\r\n\r\n",
            //        propertyItem.Id, propertyItem.Type, Encoding.ASCII.GetString(propertyItem.Value)));
            //  }
        }



    }
}
