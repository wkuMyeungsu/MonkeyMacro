﻿namespace MonkeyMacro
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_titleBar = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label_menuInfo = new System.Windows.Forms.Label();
            this.panel_container = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.button_utility = new System.Windows.Forms.Button();
            this.button_manageKeys = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.pictureBoxButton_minimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxButton_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_titleBar.SuspendLayout();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titleBar
            // 
            this.panel_titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(91)))));
            this.panel_titleBar.Controls.Add(this.pictureBoxButton_minimize);
            this.panel_titleBar.Controls.Add(this.pictureBoxButton_exit);
            this.panel_titleBar.Controls.Add(this.label_title);
            this.panel_titleBar.Controls.Add(this.pictureBox_logo);
            this.panel_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_titleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_titleBar.Name = "panel_titleBar";
            this.panel_titleBar.Size = new System.Drawing.Size(465, 60);
            this.panel_titleBar.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(57, 18);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(159, 23);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Monkey Macro";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel_menu.Controls.Add(this.label_menuInfo);
            this.panel_menu.Controls.Add(this.button_utility);
            this.panel_menu.Controls.Add(this.button_manageKeys);
            this.panel_menu.Controls.Add(this.button_settings);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 60);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(465, 45);
            this.panel_menu.TabIndex = 1;
            // 
            // label_menuInfo
            // 
            this.label_menuInfo.AutoSize = true;
            this.label_menuInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menuInfo.Location = new System.Drawing.Point(6, 9);
            this.label_menuInfo.Name = "label_menuInfo";
            this.label_menuInfo.Size = new System.Drawing.Size(146, 23);
            this.label_menuInfo.TabIndex = 3;
            this.label_menuInfo.Text = "Tracing : none";
            // 
            // panel_container
            // 
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 105);
            this.panel_container.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(465, 559);
            this.panel_container.TabIndex = 2;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // button_utility
            // 
            this.button_utility.Image = global::MonkeyMacro.Properties.Resources.plus;
            this.button_utility.Location = new System.Drawing.Point(347, 4);
            this.button_utility.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_utility.Name = "button_utility";
            this.button_utility.Size = new System.Drawing.Size(34, 38);
            this.button_utility.TabIndex = 2;
            this.button_utility.UseVisualStyleBackColor = true;
            this.button_utility.Click += new System.EventHandler(this.buttonUtility_Click);
            // 
            // button_manageKeys
            // 
            this.button_manageKeys.Image = global::MonkeyMacro.Properties.Resources.menu;
            this.button_manageKeys.Location = new System.Drawing.Point(387, 4);
            this.button_manageKeys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_manageKeys.Name = "button_manageKeys";
            this.button_manageKeys.Size = new System.Drawing.Size(34, 38);
            this.button_manageKeys.TabIndex = 1;
            this.button_manageKeys.UseVisualStyleBackColor = true;
            this.button_manageKeys.Click += new System.EventHandler(this.buttonManageKeys_Click);
            // 
            // button_settings
            // 
            this.button_settings.Image = global::MonkeyMacro.Properties.Resources.setting;
            this.button_settings.Location = new System.Drawing.Point(427, 4);
            this.button_settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(34, 38);
            this.button_settings.TabIndex = 0;
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // pictureBoxButton_minimize
            // 
            this.pictureBoxButton_minimize.Image = global::MonkeyMacro.Properties.Resources.white_minus;
            this.pictureBoxButton_minimize.Location = new System.Drawing.Point(407, 10);
            this.pictureBoxButton_minimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxButton_minimize.Name = "pictureBoxButton_minimize";
            this.pictureBoxButton_minimize.Size = new System.Drawing.Size(18, 20);
            this.pictureBoxButton_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButton_minimize.TabIndex = 4;
            this.pictureBoxButton_minimize.TabStop = false;
            this.pictureBoxButton_minimize.Click += new System.EventHandler(this.pictureBoxButtonMinimize_Click);
            // 
            // pictureBoxButton_exit
            // 
            this.pictureBoxButton_exit.Image = global::MonkeyMacro.Properties.Resources.white_cross;
            this.pictureBoxButton_exit.Location = new System.Drawing.Point(439, 10);
            this.pictureBoxButton_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxButton_exit.Name = "pictureBoxButton_exit";
            this.pictureBoxButton_exit.Size = new System.Drawing.Size(18, 20);
            this.pictureBoxButton_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButton_exit.TabIndex = 2;
            this.pictureBoxButton_exit.TabStop = false;
            this.pictureBoxButton_exit.Click += new System.EventHandler(this.pictureBoxButtonExit_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::MonkeyMacro.Properties.Resources.logo_monkey;
            this.pictureBox_logo.Location = new System.Drawing.Point(7, 6);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(41, 45);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 664);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_titleBar.ResumeLayout(false);
            this.panel_titleBar.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_titleBar;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Button button_utility;
        private System.Windows.Forms.Button button_manageKeys;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.PictureBox pictureBoxButton_exit;
        private System.Windows.Forms.PictureBox pictureBoxButton_minimize;
        private System.Windows.Forms.Label label_menuInfo;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}
