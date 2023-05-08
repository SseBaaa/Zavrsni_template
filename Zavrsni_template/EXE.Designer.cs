namespace Zavrsni_template
{
    partial class EXE
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.textBoxLower = new System.Windows.Forms.TextBox();
            this.textBoxUpper = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(198, 93);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(241, 102);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // textBoxLower
            // 
            this.textBoxLower.Location = new System.Drawing.Point(198, 67);
            this.textBoxLower.Name = "textBoxLower";
            this.textBoxLower.Size = new System.Drawing.Size(100, 20);
            this.textBoxLower.TabIndex = 1;
            // 
            // textBoxUpper
            // 
            this.textBoxUpper.Location = new System.Drawing.Point(339, 67);
            this.textBoxUpper.Name = "textBoxUpper";
            this.textBoxUpper.Size = new System.Drawing.Size(100, 20);
            this.textBoxUpper.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(195, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lower";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(336, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Upper";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(198, 201);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(241, 109);
            this.textBoxOutput.TabIndex = 5;
            // 
            // EXE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(668, 390);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUpper);
            this.Controls.Add(this.textBoxLower);
            this.Controls.Add(this.btnGuess);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "EXE";
            this.Text = "EXE";
            this.Load += new System.EventHandler(this.EXE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox textBoxLower;
        private System.Windows.Forms.TextBox textBoxUpper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}