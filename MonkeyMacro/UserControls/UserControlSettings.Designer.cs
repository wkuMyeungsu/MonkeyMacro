namespace MonkeyMacro.UserControls
{
    partial class UserControlSettings
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTestSettings = new System.Windows.Forms.Label();
            this.TrackOpacity = new System.Windows.Forms.TrackBar();
            this.Panel_Opacity = new System.Windows.Forms.GroupBox();
            this.LabelOpacity = new System.Windows.Forms.Label();
            this.GroupSet = new System.Windows.Forms.Label();
            this.QuitProgram = new System.Windows.Forms.RadioButton();
            this.SetTray = new System.Windows.Forms.RadioButton();
            this.trayControl = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrackOpacity)).BeginInit();
            this.Panel_Opacity.SuspendLayout();
            this.trayControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTestSettings
            // 
            this.labelTestSettings.AutoSize = true;
            this.labelTestSettings.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelTestSettings.Location = new System.Drawing.Point(105, 230);
            this.labelTestSettings.Name = "labelTestSettings";
            this.labelTestSettings.Size = new System.Drawing.Size(113, 32);
            this.labelTestSettings.TabIndex = 1;
            this.labelTestSettings.Text = "Settings";
            // 
            // TrackOpacity
            // 
            this.TrackOpacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackOpacity.Location = new System.Drawing.Point(3, 17);
            this.TrackOpacity.Maximum = 100;
            this.TrackOpacity.Minimum = 10;
            this.TrackOpacity.Name = "TrackOpacity";
            this.TrackOpacity.Size = new System.Drawing.Size(316, 80);
            this.TrackOpacity.TabIndex = 2;
            this.TrackOpacity.TickFrequency = 10;
            this.TrackOpacity.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrackOpacity.Value = 20;
            this.TrackOpacity.Scroll += new System.EventHandler(this.OnOpacityTrackScroll);
            // 
            // Panel_Opacity
            // 
            this.Panel_Opacity.Controls.Add(this.LabelOpacity);
            this.Panel_Opacity.Controls.Add(this.TrackOpacity);
            this.Panel_Opacity.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Opacity.Location = new System.Drawing.Point(0, 0);
            this.Panel_Opacity.Name = "Panel_Opacity";
            this.Panel_Opacity.Size = new System.Drawing.Size(322, 100);
            this.Panel_Opacity.TabIndex = 3;
            this.Panel_Opacity.TabStop = false;
            this.Panel_Opacity.Text = "투명도";
            // 
            // LabelOpacity
            // 
            this.LabelOpacity.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LabelOpacity.Location = new System.Drawing.Point(256, 70);
            this.LabelOpacity.Name = "LabelOpacity";
            this.LabelOpacity.Size = new System.Drawing.Size(58, 23);
            this.LabelOpacity.TabIndex = 3;
            this.LabelOpacity.Text = "XX%";
            this.LabelOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupSet
            // 
            this.GroupSet.AutoSize = true;
            this.GroupSet.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GroupSet.Location = new System.Drawing.Point(20, 20);
            this.GroupSet.Name = "GroupSet";
            this.GroupSet.Size = new System.Drawing.Size(102, 11);
            this.GroupSet.TabIndex = 6;
            this.GroupSet.Text = "X 클릭시 동작 설정";
            // 
            // QuitProgram
            // 
            this.QuitProgram.AutoSize = true;
            this.QuitProgram.Checked = true;
            this.QuitProgram.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.QuitProgram.Location = new System.Drawing.Point(195, 50);
            this.QuitProgram.Name = "QuitProgram";
            this.QuitProgram.Size = new System.Drawing.Size(99, 16);
            this.QuitProgram.TabIndex = 5;
            this.QuitProgram.TabStop = true;
            this.QuitProgram.Text = "프로그램 종료";
            this.QuitProgram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuitProgram.UseVisualStyleBackColor = true;
            // 
            // SetTray
            // 
            this.SetTray.AutoSize = true;
            this.SetTray.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SetTray.Location = new System.Drawing.Point(51, 50);
            this.SetTray.Name = "SetTray";
            this.SetTray.Size = new System.Drawing.Size(99, 16);
            this.SetTray.TabIndex = 0;
            this.SetTray.Text = "트레이 최소화";
            this.SetTray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SetTray.UseVisualStyleBackColor = true;
            this.SetTray.CheckedChanged += new System.EventHandler(this.SetTray_CheckedChanged);
            // 
            // trayControl
            // 
            this.trayControl.Controls.Add(this.GroupSet);
            this.trayControl.Controls.Add(this.QuitProgram);
            this.trayControl.Controls.Add(this.SetTray);
            this.trayControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.trayControl.Font = new System.Drawing.Font("굴림", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trayControl.Location = new System.Drawing.Point(0, 100);
            this.trayControl.Name = "trayControl";
            this.trayControl.Size = new System.Drawing.Size(322, 80);
            this.trayControl.TabIndex = 5;
            this.trayControl.TabStop = false;
            this.trayControl.Text = "종료설정";
            // 
            // UserControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trayControl);
            this.Controls.Add(this.Panel_Opacity);
            this.Controls.Add(this.labelTestSettings);
            this.Name = "UserControlSettings";
            this.Size = new System.Drawing.Size(322, 394);
            this.Load += new System.EventHandler(this.OnUserControlSettingsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.TrackOpacity)).EndInit();
            this.Panel_Opacity.ResumeLayout(false);
            this.Panel_Opacity.PerformLayout();
            this.trayControl.ResumeLayout(false);
            this.trayControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTestSettings;
        private System.Windows.Forms.TrackBar TrackOpacity;
        private System.Windows.Forms.GroupBox Panel_Opacity;
        private System.Windows.Forms.Label LabelOpacity;
        private System.Windows.Forms.Label GroupSet;
        private System.Windows.Forms.RadioButton QuitProgram;
        private System.Windows.Forms.RadioButton SetTray;
        private System.Windows.Forms.GroupBox trayControl;
    }
}
