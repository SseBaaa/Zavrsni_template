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
    public partial class TheC : Form
    {
        public TheC()
        {
            InitializeComponent();
        }
        private readonly string[] vulnerabilityInfo = new string[]
{
    "Buffer Overflow:\nA buffer overflow occurs when a program writes more data to a buffer than it can hold, causing the excess data to overwrite adjacent memory. This can lead to unpredictable behavior, crashes, or security vulnerabilities. To avoid buffer overflow, always validate input lengths and use secure functions such as strncpy() instead of strcpy().",

    "Integer Overflow:\nAn integer overflow occurs when the result of an arithmetic operation exceeds the maximum value that can be stored in the integer type, causing the value to wrap around. This can lead to unexpected behavior or security vulnerabilities. To prevent integer overflows, validate input ranges and use proper type casting.",

    "Format String Vulnerability:\nA format string vulnerability occurs when a program uses untrusted input as a format string in functions such as printf(). An attacker can exploit this vulnerability to read or write arbitrary memory. To avoid format string vulnerabilities, use static format strings and validate user input.",

    "Memory Leaks:\nA memory leak occurs when a program allocates memory but does not free it, leading to a gradual decrease in available memory. This can cause performance issues or crashes. To prevent memory leaks, always free memory allocated with malloc() or other memory allocation functions using the free() function.",

    "Use After Free:\nUse after free vulnerabilities occur when a program continues to use a pointer after the memory it points to has been freed. This can lead to crashes or security vulnerabilities. To avoid use after free issues, set pointers to NULL after freeing the associated memory and ensure proper memory management."
};

        private void TheC_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[]
    {
        "Buffer Overflow",
        "Integer Overflow",
        "Format String Vulnerability",
        "Memory Leaks",
        "Use After Free"
    });

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = vulnerabilityInfo[comboBox1.SelectedIndex];
        }
    }
}
