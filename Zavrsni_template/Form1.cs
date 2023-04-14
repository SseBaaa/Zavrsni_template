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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            costumizeDesign();
        }
        private void costumizeDesign()
        {
            panelMediaSubMenu.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
            
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void webButton_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void BinaryButton_Click(object sender, EventArgs e)
        {
            showSubMenu(panel4);
        }
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new ROT16());
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void childForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Basee());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new RSA());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Morsee());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new FileFormat());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new EXIF());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new DiskImage());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Stenography());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new SQLinjection());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            openChildForm(new EXE());
        }

        private void button23_Click(object sender, EventArgs e)
        {
            openChildForm(new Buffer());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            openChildForm(new Decompile());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            openChildForm(new TheC());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            openChildForm(new TheA());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new CommandInjection());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new CSSs());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new ServerForgery());
        }

        private void button25_Click(object sender, EventArgs e)
        {
            openChildForm(new Registers());
        }

        private void button22_Click(object sender, EventArgs e)
        {
            openChildForm(new Heap());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            openChildForm(new Stack());
        }
    }
}
