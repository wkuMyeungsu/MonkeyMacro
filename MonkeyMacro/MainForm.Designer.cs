namespace MonkeyMacro
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBoxButtonMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtonTray = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtonExit = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelMenuInfo = new System.Windows.Forms.Label();
            this.buttonAddKey = new System.Windows.Forms.Button();
            this.buttonManageKeys = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonTray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(91)))));
            this.panelTitleBar.Controls.Add(this.pictureBoxButtonMinimize);
            this.panelTitleBar.Controls.Add(this.pictureBoxButtonTray);
            this.panelTitleBar.Controls.Add(this.pictureBoxButtonExit);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.pictureBoxLogo);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(407, 48);
            this.panelTitleBar.TabIndex = 0;
            // 
            // pictureBoxButtonMinimize
            // 
            this.pictureBoxButtonMinimize.Image = global::MonkeyMacro.Properties.Resources.white_minus;
            this.pictureBoxButtonMinimize.Location = new System.Drawing.Point(336, 8);
            this.pictureBoxButtonMinimize.Name = "pictureBoxButtonMinimize";
            this.pictureBoxButtonMinimize.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButtonMinimize.TabIndex = 4;
            this.pictureBoxButtonMinimize.TabStop = false;
            this.pictureBoxButtonMinimize.Click += new System.EventHandler(this.pictureBoxButtonMinimize_Click);
            // 
            // pictureBoxButtonTray
            // 
            this.pictureBoxButtonTray.Image = global::MonkeyMacro.Properties.Resources.white_angle_down;
            this.pictureBoxButtonTray.Location = new System.Drawing.Point(360, 8);
            this.pictureBoxButtonTray.Name = "pictureBoxButtonTray";
            this.pictureBoxButtonTray.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxButtonTray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButtonTray.TabIndex = 3;
            this.pictureBoxButtonTray.TabStop = false;
            // 
            // pictureBoxButtonExit
            // 
            this.pictureBoxButtonExit.Image = global::MonkeyMacro.Properties.Resources.white_cross;
            this.pictureBoxButtonExit.Location = new System.Drawing.Point(384, 8);
            this.pictureBoxButtonExit.Name = "pictureBoxButtonExit";
            this.pictureBoxButtonExit.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButtonExit.TabIndex = 2;
            this.pictureBoxButtonExit.TabStop = false;
            this.pictureBoxButtonExit.Click += new System.EventHandler(this.pictureBoxButtonExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(50, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(125, 19);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Monkey Macro";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::MonkeyMacro.Properties.Resources.logo_monkey;
            this.pictureBoxLogo.Location = new System.Drawing.Point(6, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelMenu.Controls.Add(this.labelMenuInfo);
            this.panelMenu.Controls.Add(this.buttonAddKey);
            this.panelMenu.Controls.Add(this.buttonManageKeys);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 48);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(407, 36);
            this.panelMenu.TabIndex = 1;
            // 
            // labelMenuInfo
            // 
            this.labelMenuInfo.AutoSize = true;
            this.labelMenuInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuInfo.Location = new System.Drawing.Point(5, 7);
            this.labelMenuInfo.Name = "labelMenuInfo";
            this.labelMenuInfo.Size = new System.Drawing.Size(120, 21);
            this.labelMenuInfo.TabIndex = 3;
            this.labelMenuInfo.Text = "Tracing : none";
            // 
            // buttonAddKey
            // 
            this.buttonAddKey.Image = global::MonkeyMacro.Properties.Resources.plus;
            this.buttonAddKey.Location = new System.Drawing.Point(304, 3);
            this.buttonAddKey.Name = "buttonAddKey";
            this.buttonAddKey.Size = new System.Drawing.Size(30, 30);
            this.buttonAddKey.TabIndex = 2;
            this.buttonAddKey.UseVisualStyleBackColor = true;
            // 
            // buttonManageKeys
            // 
            this.buttonManageKeys.Image = global::MonkeyMacro.Properties.Resources.menu;
            this.buttonManageKeys.Location = new System.Drawing.Point(339, 3);
            this.buttonManageKeys.Name = "buttonManageKeys";
            this.buttonManageKeys.Size = new System.Drawing.Size(30, 30);
            this.buttonManageKeys.TabIndex = 1;
            this.buttonManageKeys.UseVisualStyleBackColor = true;
            this.buttonManageKeys.Click += new System.EventHandler(this.buttonManageKeys_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Image = global::MonkeyMacro.Properties.Resources.setting;
            this.buttonSettings.Location = new System.Drawing.Point(374, 3);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(30, 30);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 84);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(407, 447);
            this.panelContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 531);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonTray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonAddKey;
        private System.Windows.Forms.Button buttonManageKeys;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.PictureBox pictureBoxButtonTray;
        private System.Windows.Forms.PictureBox pictureBoxButtonExit;
        private System.Windows.Forms.PictureBox pictureBoxButtonMinimize;
        private System.Windows.Forms.Label labelMenuInfo;
    }
}

