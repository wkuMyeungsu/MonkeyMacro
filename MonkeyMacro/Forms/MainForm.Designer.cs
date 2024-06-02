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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBoxButtonMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtonExit = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.labelMenuInfo = new System.Windows.Forms.Label();
            this.buttonUtility = new System.Windows.Forms.Button();
            this.button_manageKeys = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(91)))));
            this.panelTitleBar.Controls.Add(this.pictureBoxButtonMinimize);
            this.panelTitleBar.Controls.Add(this.pictureBoxButtonExit);
            this.panelTitleBar.Controls.Add(this.label_title);
            this.panelTitleBar.Controls.Add(this.pictureBox_logo);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(322, 48);
            this.panelTitleBar.TabIndex = 0;
            // 
            // pictureBoxButtonMinimize
            // 
            this.pictureBoxButtonMinimize.Image = global::MonkeyMacro.Properties.Resources.white_minus;
            this.pictureBoxButtonMinimize.Location = new System.Drawing.Point(270, 9);
            this.pictureBoxButtonMinimize.Name = "pictureBoxButtonMinimize";
            this.pictureBoxButtonMinimize.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButtonMinimize.TabIndex = 4;
            this.pictureBoxButtonMinimize.TabStop = false;
            this.pictureBoxButtonMinimize.Click += new System.EventHandler(this.OnPictureBoxButtonMinimizeClick);
            // 
            // pictureBoxButtonExit
            // 
            this.pictureBoxButtonExit.Image = global::MonkeyMacro.Properties.Resources.white_cross;
            this.pictureBoxButtonExit.Location = new System.Drawing.Point(298, 9);
            this.pictureBoxButtonExit.Name = "pictureBoxButtonExit";
            this.pictureBoxButtonExit.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButtonExit.TabIndex = 2;
            this.pictureBoxButtonExit.TabStop = false;
            this.pictureBoxButtonExit.Click += new System.EventHandler(this.OnPictureBoxButtonExitClick);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(50, 14);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(125, 19);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Monkey Macro";
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::MonkeyMacro.Properties.Resources.logo_monkey;
            this.pictureBox_logo.Location = new System.Drawing.Point(6, 5);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(36, 36);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel_menu.Controls.Add(this.labelMenuInfo);
            this.panel_menu.Controls.Add(this.buttonUtility);
            this.panel_menu.Controls.Add(this.button_manageKeys);
            this.panel_menu.Controls.Add(this.button_settings);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 48);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(322, 36);
            this.panel_menu.TabIndex = 1;
            // 
            // labelMenuInfo
            // 
            this.labelMenuInfo.AutoSize = true;
            this.labelMenuInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuInfo.Location = new System.Drawing.Point(5, 7);
            this.labelMenuInfo.Name = "labelMenuInfo";
            this.labelMenuInfo.Size = new System.Drawing.Size(160, 21);
            this.labelMenuInfo.TabIndex = 3;
            this.labelMenuInfo.Text = "Tracing : Detecting";
            // 
            // buttonUtility
            // 
            this.buttonUtility.Image = global::MonkeyMacro.Properties.Resources.plus;
            this.buttonUtility.Location = new System.Drawing.Point(219, 3);
            this.buttonUtility.Name = "buttonUtility";
            this.buttonUtility.Size = new System.Drawing.Size(30, 30);
            this.buttonUtility.TabIndex = 2;
            this.buttonUtility.UseVisualStyleBackColor = true;
            this.buttonUtility.Click += new System.EventHandler(this.OnButtonUtilityClick);
            // 
            // button_manageKeys
            // 
            this.button_manageKeys.Image = global::MonkeyMacro.Properties.Resources.menu;
            this.button_manageKeys.Location = new System.Drawing.Point(254, 3);
            this.button_manageKeys.Name = "button_manageKeys";
            this.button_manageKeys.Size = new System.Drawing.Size(30, 30);
            this.button_manageKeys.TabIndex = 1;
            this.button_manageKeys.UseVisualStyleBackColor = true;
            this.button_manageKeys.Click += new System.EventHandler(this.OnButtonManageKeysClick);
            // 
            // button_settings
            // 
            this.button_settings.Image = global::MonkeyMacro.Properties.Resources.setting;
            this.button_settings.Location = new System.Drawing.Point(289, 3);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(30, 30);
            this.button_settings.TabIndex = 0;
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.OnButtonSettingsClick);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 84);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(322, 394);
            this.panelContainer.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 478);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonUtility;
        private System.Windows.Forms.Button button_manageKeys;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.PictureBox pictureBoxButtonExit;
        private System.Windows.Forms.PictureBox pictureBoxButtonMinimize;
        private System.Windows.Forms.Label labelMenuInfo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
    }
}

