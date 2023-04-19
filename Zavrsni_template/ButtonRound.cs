using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni_template
{
    public class RoundButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(path);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            base.OnPaint(pevent);
        }
    }
    public partial class ButtonRound : Form
    {
        public ButtonRound()
        {
            InitializeComponent();
        }

        private void ButtonRound_Load(object sender, EventArgs e)
        {

        }
    }
}
