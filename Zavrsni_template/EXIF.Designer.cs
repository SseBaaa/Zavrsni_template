﻿namespace Zavrsni_template
{
    partial class EXIF
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.dgvExifData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExifData)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 109);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check metadata";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(148, 304);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(345, 136);
            this.textBoxResults.TabIndex = 2;
            // 
            // dgvExifData
            // 
            this.dgvExifData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExifData.Location = new System.Drawing.Point(148, 33);
            this.dgvExifData.Name = "dgvExifData";
            this.dgvExifData.Size = new System.Drawing.Size(345, 150);
            this.dgvExifData.TabIndex = 3;
            // 
            // EXIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.dgvExifData);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.button1);
            this.Name = "EXIF";
            this.Text = "EXIF";
            this.Load += new System.EventHandler(this.EXIF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExifData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.DataGridView dgvExifData;
    }
}