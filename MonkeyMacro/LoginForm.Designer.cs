﻿namespace MonkeyMacro
{
    partial class LoginForm
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
            this.panel_titleBar = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBoxButton_exit = new System.Windows.Forms.PictureBox();
            this.panel_titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titleBar
            // 
            this.panel_titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(91)))));
            this.panel_titleBar.Controls.Add(this.label_title);
            this.panel_titleBar.Controls.Add(this.pictureBoxButton_exit);
            this.panel_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_titleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_titleBar.Name = "panel_titleBar";
            this.panel_titleBar.Size = new System.Drawing.Size(472, 101);
            this.panel_titleBar.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(153, 32);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(176, 37);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Login Form";
            // 
            // pictureBoxButton_exit
            // 
            this.pictureBoxButton_exit.Image = global::MonkeyMacro.Properties.Resources.white_cross;
            this.pictureBoxButton_exit.Location = new System.Drawing.Point(443, 10);
            this.pictureBoxButton_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxButton_exit.Name = "pictureBoxButton_exit";
            this.pictureBoxButton_exit.Size = new System.Drawing.Size(18, 20);
            this.pictureBoxButton_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButton_exit.TabIndex = 2;
            this.pictureBoxButton_exit.TabStop = false;
            this.pictureBoxButton_exit.Click += new System.EventHandler(this.pictureBoxButton_exit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.panel_titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel_titleBar.ResumeLayout(false);
            this.panel_titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_titleBar;
        private System.Windows.Forms.PictureBox pictureBoxButton_exit;
        private System.Windows.Forms.Label label_title;
    }
}