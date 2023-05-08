namespace Zavrsni_template
{
    partial class ROT16
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
            this.textBoxROT16 = new System.Windows.Forms.TextBox();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.textBoxDecipher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxROT16
            // 
            this.textBoxROT16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxROT16.Location = new System.Drawing.Point(12, 80);
            this.textBoxROT16.Multiline = true;
            this.textBoxROT16.Name = "textBoxROT16";
            this.textBoxROT16.Size = new System.Drawing.Size(316, 181);
            this.textBoxROT16.TabIndex = 0;
            this.textBoxROT16.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDecipher.Location = new System.Drawing.Point(296, 314);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(75, 23);
            this.buttonDecipher.TabIndex = 1;
            this.buttonDecipher.Text = "Decipher";
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // textBoxDecipher
            // 
            this.textBoxDecipher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDecipher.Location = new System.Drawing.Point(334, 80);
            this.textBoxDecipher.Multiline = true;
            this.textBoxDecipher.Name = "textBoxDecipher";
            this.textBoxDecipher.Size = new System.Drawing.Size(322, 181);
            this.textBoxDecipher.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(149, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cipher";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(463, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "decipher";
            // 
            // ROT16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(668, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDecipher);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.textBoxROT16);
            this.Name = "ROT16";
            this.Text = "ROT16";
            this.Load += new System.EventHandler(this.ROT16_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxROT16;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.TextBox textBoxDecipher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}