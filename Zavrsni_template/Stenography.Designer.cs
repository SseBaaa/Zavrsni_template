namespace Zavrsni_template
{
    partial class Stenography
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.txtDecodedMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(218, 179);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(207, 82);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // txtDecodedMessage
            // 
            this.txtDecodedMessage.Location = new System.Drawing.Point(218, 268);
            this.txtDecodedMessage.Multiline = true;
            this.txtDecodedMessage.Name = "txtDecodedMessage";
            this.txtDecodedMessage.Size = new System.Drawing.Size(207, 91);
            this.txtDecodedMessage.TabIndex = 1;
            // 
            // Stenography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.txtDecodedMessage);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "Stenography";
            this.Text = "Stenography";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.TextBox txtDecodedMessage;
    }
}