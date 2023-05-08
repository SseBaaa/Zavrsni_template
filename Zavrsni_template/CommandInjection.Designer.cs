namespace Zavrsni_template
{
    partial class CommandInjection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExecuteSecure = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.Filename = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.btnExecuteSecure);
            this.groupBox1.Controls.Add(this.btnExecute);
            this.groupBox1.Controls.Add(this.Filename);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Command Injection";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(66, 409);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(535, 226);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnExecuteSecure
            // 
            this.btnExecuteSecure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExecuteSecure.Location = new System.Drawing.Point(294, 64);
            this.btnExecuteSecure.Name = "btnExecuteSecure";
            this.btnExecuteSecure.Size = new System.Drawing.Size(260, 45);
            this.btnExecuteSecure.TabIndex = 2;
            this.btnExecuteSecure.Text = "Execute Secure";
            this.btnExecuteSecure.UseVisualStyleBackColor = true;
            this.btnExecuteSecure.Click += new System.EventHandler(this.btnExecuteSecure_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExecute.Location = new System.Drawing.Point(19, 64);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(260, 45);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // Filename
            // 
            this.Filename.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Filename.Location = new System.Drawing.Point(6, 19);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(172, 23);
            this.Filename.TabIndex = 0;
            this.Filename.Text = "Filename";
            this.Filename.UseVisualStyleBackColor = true;
            this.Filename.Click += new System.EventHandler(this.Filename_Click);
            // 
            // CommandInjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(668, 390);
            this.Controls.Add(this.groupBox1);
            this.Name = "CommandInjection";
            this.Text = "CommandInjection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnExecuteSecure;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button Filename;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
    }
}