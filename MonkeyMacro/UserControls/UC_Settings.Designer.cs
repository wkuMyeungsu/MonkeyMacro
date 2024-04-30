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
            this.SuspendLayout();
            // 
            // labelTestSettings
            // 
            this.labelTestSettings.AutoSize = true;
            this.labelTestSettings.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelTestSettings.Location = new System.Drawing.Point(168, 259);
            this.labelTestSettings.Name = "labelTestSettings";
            this.labelTestSettings.Size = new System.Drawing.Size(142, 40);
            this.labelTestSettings.TabIndex = 1;
            this.labelTestSettings.Text = "Settings";
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTestSettings);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(465, 559);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTestSettings;
    }
}
