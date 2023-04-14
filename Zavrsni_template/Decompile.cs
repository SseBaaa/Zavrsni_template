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
    public partial class Decompile : Form
    {
        public Decompile()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Decompile_Load(object sender, EventArgs e)
        {
            string idaProInfo = "IDA Pro (https://www.hex-rays.com/products/ida/):\n" +
        "A well-known commercial disassembler and debugger, with a decompiler plugin called Hex-Rays Decompiler. It supports a wide range of executable formats and provides support for numerous processor architectures. The Hex-Rays Decompiler plugin can produce C-like pseudocode from native binaries.";

            string ghidraInfo = "Ghidra (https://ghidra-sre.org/):\n" +
                "A free, open-source software reverse engineering suite developed by the National Security Agency (NSA). It supports a wide variety of executable formats and processor architectures and includes a powerful decompiler that can produce C-like pseudocode.";

            string hopperInfo = "Hopper (https://www.hopperapp.com/):\n" +
                "A commercial reverse engineering tool and disassembler for macOS and Linux, with a built-in decompiler that can produce pseudocode for several processor architectures.";

            richTextBox1.Text = idaProInfo;
            richTextBox2.Text = ghidraInfo;
            richTextBox3.Text = hopperInfo;
        }
    }
}
