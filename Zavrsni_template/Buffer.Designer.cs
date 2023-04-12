namespace Zavrsni_template
{
    partial class Buffer
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
            this.exploitButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exploitButton
            // 
            this.exploitButton.Location = new System.Drawing.Point(178, 130);
            this.exploitButton.Name = "exploitButton";
            this.exploitButton.Size = new System.Drawing.Size(275, 155);
            this.exploitButton.TabIndex = 0;
            this.exploitButton.Text = "Exploit";
            this.exploitButton.UseVisualStyleBackColor = true;
            this.exploitButton.Click += new System.EventHandler(this.exploitButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(178, 292);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(275, 136);
            this.outputTextBox.TabIndex = 1;
            // 
            // Buffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.exploitButton);
            this.Name = "Buffer";
            this.Text = "Buffer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exploitButton;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}