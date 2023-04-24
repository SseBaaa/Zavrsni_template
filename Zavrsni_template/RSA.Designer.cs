namespace Zavrsni_template
{
    partial class RSA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxRjesenje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonIzracun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(21, 25);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(328, 36);
            this.textBoxC.TabIndex = 0;
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(21, 81);
            this.textBoxE.Multiline = true;
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(328, 36);
            this.textBoxE.TabIndex = 1;
            this.textBoxE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(21, 135);
            this.textBoxN.Multiline = true;
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(328, 36);
            this.textBoxN.TabIndex = 2;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(21, 188);
            this.textBoxD.Multiline = true;
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(328, 36);
            this.textBoxD.TabIndex = 3;
            // 
            // textBoxRjesenje
            // 
            this.textBoxRjesenje.Location = new System.Drawing.Point(369, 25);
            this.textBoxRjesenje.Multiline = true;
            this.textBoxRjesenje.Name = "textBoxRjesenje";
            this.textBoxRjesenje.Size = new System.Drawing.Size(287, 199);
            this.textBoxRjesenje.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cipher mesagge (C)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Public key (E)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(21, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Public key value (N)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(21, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Private key value (D)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonIzracun
            // 
            this.buttonIzracun.Location = new System.Drawing.Point(24, 231);
            this.buttonIzracun.Name = "buttonIzracun";
            this.buttonIzracun.Size = new System.Drawing.Size(96, 35);
            this.buttonIzracun.TabIndex = 9;
            this.buttonIzracun.Text = "Decrypt";
            this.buttonIzracun.UseVisualStyleBackColor = true;
            this.buttonIzracun.Click += new System.EventHandler(this.buttonIzracun_Click);
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(668, 390);
            this.Controls.Add(this.buttonIzracun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRjesenje);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.textBoxC);
            this.Name = "RSA";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.RSA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxRjesenje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonIzracun;
    }
}