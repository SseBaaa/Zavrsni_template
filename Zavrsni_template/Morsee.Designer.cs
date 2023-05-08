namespace Zavrsni_template
{
    partial class Morsee
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
            this.textBoxMorse = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonIspisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMorse
            // 
            this.textBoxMorse.Location = new System.Drawing.Point(24, 43);
            this.textBoxMorse.Multiline = true;
            this.textBoxMorse.Name = "textBoxMorse";
            this.textBoxMorse.Size = new System.Drawing.Size(313, 159);
            this.textBoxMorse.TabIndex = 0;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(342, 43);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(313, 159);
            this.textBoxText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(151, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Morse Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(483, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text";
            // 
            // buttonIspisi
            // 
            this.buttonIspisi.Location = new System.Drawing.Point(301, 264);
            this.buttonIspisi.Name = "buttonIspisi";
            this.buttonIspisi.Size = new System.Drawing.Size(75, 23);
            this.buttonIspisi.TabIndex = 4;
            this.buttonIspisi.Text = "Decrypt";
            this.buttonIspisi.UseVisualStyleBackColor = true;
            this.buttonIspisi.Click += new System.EventHandler(this.buttonIspisi_Click);
            // 
            // Morsee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(668, 390);
            this.Controls.Add(this.buttonIspisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxMorse);
            this.Name = "Morsee";
            this.Text = "Morse";
            this.Load += new System.EventHandler(this.Morsee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMorse;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonIspisi;
    }
}