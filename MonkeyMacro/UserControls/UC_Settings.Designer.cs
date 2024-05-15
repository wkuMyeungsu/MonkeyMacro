namespace MonkeyMacro.UserControls
{
    partial class UC_Settings
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
            this.Track_Opacity = new System.Windows.Forms.TrackBar();
            this.Panel_Opacity = new System.Windows.Forms.GroupBox();
            this.Label_Opacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Opacity)).BeginInit();
            this.Panel_Opacity.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTestSettings
            // 
            this.labelTestSettings.AutoSize = true;
            this.labelTestSettings.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelTestSettings.Location = new System.Drawing.Point(147, 207);
            this.labelTestSettings.Name = "labelTestSettings";
            this.labelTestSettings.Size = new System.Drawing.Size(113, 32);
            this.labelTestSettings.TabIndex = 1;
            this.labelTestSettings.Text = "Settings";
            // 
            // Track_Opacity
            // 
            this.Track_Opacity.Location = new System.Drawing.Point(6, 20);
            this.Track_Opacity.Maximum = 100;
            this.Track_Opacity.Minimum = 10;
            this.Track_Opacity.Name = "Track_Opacity";
            this.Track_Opacity.Size = new System.Drawing.Size(389, 45);
            this.Track_Opacity.TabIndex = 2;
            this.Track_Opacity.TickFrequency = 10;
            this.Track_Opacity.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Track_Opacity.Value = 20;
            this.Track_Opacity.Scroll += new System.EventHandler(this.Opacity_Track_Scroll);
            // 
            // Panel_Opacity
            // 
            this.Panel_Opacity.Controls.Add(this.Label_Opacity);
            this.Panel_Opacity.Controls.Add(this.Track_Opacity);
            this.Panel_Opacity.Location = new System.Drawing.Point(3, 3);
            this.Panel_Opacity.Name = "Panel_Opacity";
            this.Panel_Opacity.Size = new System.Drawing.Size(401, 102);
            this.Panel_Opacity.TabIndex = 3;
            this.Panel_Opacity.TabStop = false;
            this.Panel_Opacity.Text = "투명도";
            // 
            // Label_Opacity
            // 
            this.Label_Opacity.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Opacity.Location = new System.Drawing.Point(337, 68);
            this.Label_Opacity.Name = "Label_Opacity";
            this.Label_Opacity.Size = new System.Drawing.Size(58, 23);
            this.Label_Opacity.TabIndex = 3;
            this.Label_Opacity.Text = "XX%";
            this.Label_Opacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_Opacity);
            this.Controls.Add(this.labelTestSettings);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(407, 447);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Track_Opacity)).EndInit();
            this.Panel_Opacity.ResumeLayout(false);
            this.Panel_Opacity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTestSettings;
        private System.Windows.Forms.TrackBar Track_Opacity;
        private System.Windows.Forms.GroupBox Panel_Opacity;
        private System.Windows.Forms.Label Label_Opacity;
    }
}
