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
        }
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
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
    }
}
