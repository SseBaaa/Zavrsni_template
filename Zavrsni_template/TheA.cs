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
    public partial class TheA : Form
    {
        public TheA()
        {
            InitializeComponent();
        }

        private void TheA_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = @"Assembly Language and Machine Code are two low-level programming languages used in computer systems.

Assembly Language:
- A human-readable representation of machine code instructions.
- Each assembly instruction corresponds to one machine code instruction.
- Assembly languages are specific to a particular computer architecture.
- Programmers use mnemonics to represent machine code instructions, making it easier to read and write.
- Assembly code is translated into machine code by an assembler.

Machine Code:
- A series of binary instructions that are executed directly by the computer's hardware.
- The lowest level of programming languages, consisting of 1s and 0s.
- Difficult for humans to read and write directly.
- Executed directly by the computer's processor, without the need for an interpreter or compiler.

When working with high-level programming languages like C# or Python, the code is compiled or interpreted into machine code, which is then executed by the computer's processor. Programmers use low-level languages like assembly when they need precise control over hardware or optimization at the instruction level.";
        }
    }
}
