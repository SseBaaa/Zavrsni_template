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
    public partial class CSSs : Form
    {
        public CSSs()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            richTextBox1.Text = $"Welcome, {name}!";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            richTextBox2.Text = @"Cross-Site Scripting (XSS) is a type of security vulnerability that allows attackers to inject malicious scripts into web pages viewed by other users. It typically occurs when an application includes untrusted data (e.g., user input) in a web page without proper validation or escaping.

XSS attacks can be classified into three types:

1. Stored XSS (Persistent): The malicious script is stored on the server (e.g., in a database) and executed when the user loads a vulnerable page. This type of XSS is often found in comment sections or user-generated content.

2. Reflected XSS (Non-persistent): The malicious script is included in a URL or form submission and executed when the user clicks a link or submits the form. The script is not stored on the server.

3. DOM-based XSS: The vulnerability exists in the client-side code, and the malicious script is executed by manipulating the Document Object Model (DOM).

To protect applications from XSS attacks, developers should:
- Validate and sanitize user input.
- Use secure coding practices, such as output encoding and Content Security Policy (CSP).
- Regularly update and patch software components and libraries.";
        }
    }
}
