namespace MonkeyMacro.UserControls
{
    partial class UserControlAppItem
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
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelShortcutCount = new System.Windows.Forms.Label();
            this.panelAppNameContainer = new System.Windows.Forms.Panel();
            this.panelAppNameContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAppName.Location = new System.Drawing.Point(23, 10);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(79, 19);
            this.labelAppName.TabIndex = 2;
            this.labelAppName.Text = "프로그램명";
            // 
            // labelShortcutCount
            // 
            this.labelShortcutCount.AutoSize = true;
            this.labelShortcutCount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShortcutCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelShortcutCount.Location = new System.Drawing.Point(4, 66);
            this.labelShortcutCount.Name = "labelShortcutCount";
            this.labelShortcutCount.Size = new System.Drawing.Size(112, 17);
            this.labelShortcutCount.TabIndex = 3;
            this.labelShortcutCount.Text = "저장 단축키 : N개";
            // 
            // panelAppNameContainer
            // 
            this.panelAppNameContainer.Controls.Add(this.labelAppName);
            this.panelAppNameContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppNameContainer.Location = new System.Drawing.Point(0, 0);
            this.panelAppNameContainer.Name = "panelAppNameContainer";
            this.panelAppNameContainer.Size = new System.Drawing.Size(121, 40);
            this.panelAppNameContainer.TabIndex = 4;
            // 
            // UserControlAppItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.panelAppNameContainer);
            this.Controls.Add(this.labelShortcutCount);
            this.Name = "UserControlAppItem";
            this.Size = new System.Drawing.Size(121, 110);
            this.panelAppNameContainer.ResumeLayout(false);
            this.panelAppNameContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelShortcutCount;
        private System.Windows.Forms.Panel panelAppNameContainer;
    }
}
