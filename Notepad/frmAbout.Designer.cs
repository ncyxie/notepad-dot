﻿namespace Notepad
{
    partial class frmAbout
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblProductVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblProductName.Location = new System.Drawing.Point(12, 18);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(135, 24);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Notepad Dot";
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(108, 231);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(103, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK!";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblProductVersion
            // 
            this.lblProductVersion.AutoSize = true;
            this.lblProductVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblProductVersion.Location = new System.Drawing.Point(12, 51);
            this.lblProductVersion.Name = "lblProductVersion";
            this.lblProductVersion.Size = new System.Drawing.Size(120, 80);
            this.lblProductVersion.TabIndex = 2;
            this.lblProductVersion.Text = "A open source,\r\nlightweight,\r\nvery simple text \r\neditor. \r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version: 2.1.0 Beta\r\nMade by ncyxie.\r\nThanks to xezrunner.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Notepad.Properties.Resources.notepad_dot_logo_png_200x200;
            this.pictureBox1.Location = new System.Drawing.Point(149, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 193);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProductVersion);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnOK;
    }
}