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
    public partial class ServerForgery : Form
    {
        public ServerForgery()
        {
            InitializeComponent();
        }

        private void ServerForgery_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = @"Server-Side Request Forgery (SSRF) is a type of security vulnerability that allows an attacker to induce a server to make arbitrary HTTP requests, often to internal or private resources that the attacker cannot access directly. It typically occurs when an application processes untrusted URLs without proper validation or restriction.

An attacker may exploit SSRF vulnerabilities to:
- Bypass access controls and retrieve sensitive information.
- Perform unauthorized actions on internal services.
- Execute attacks like port scanning or denial of service against internal systems.

To protect applications from SSRF attacks, developers should:
- Validate and sanitize user-supplied URLs.
- Restrict the destination IP addresses and domains that the application can access.
- Implement network segmentation to limit the access of application servers to internal systems.
- Employ allowlisting to ensure only trusted URLs can be accessed.
- Use authentication and authorization mechanisms to protect internal resources.";

        }
    }
}
