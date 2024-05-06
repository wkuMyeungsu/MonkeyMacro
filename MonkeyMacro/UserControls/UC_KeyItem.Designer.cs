namespace MonkeyMacro.UserControls
{
    partial class UC_KeyItem
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
            this.label_underLine = new System.Windows.Forms.Label();
            this.label_keyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_underLine
            // 
            this.label_underLine.AutoSize = true;
            this.label_underLine.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_underLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_underLine.Location = new System.Drawing.Point(49, 4);
            this.label_underLine.Name = "label_underLine";
            this.label_underLine.Size = new System.Drawing.Size(287, 35);
            this.label_underLine.TabIndex = 0;
            this.label_underLine.Text = "⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯";
            // 
            // label_keyName
            // 
            this.label_keyName.AutoSize = true;
            this.label_keyName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_keyName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_keyName.Location = new System.Drawing.Point(150, 0);
            this.label_keyName.Name = "label_keyName";
            this.label_keyName.Size = new System.Drawing.Size(94, 21);
            this.label_keyName.TabIndex = 1;
            this.label_keyName.Text = "단축키 별명";
            // 
            // UC_KeyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.label_keyName);
            this.Controls.Add(this.label_underLine);
            this.Name = "UC_KeyItem";
            this.Size = new System.Drawing.Size(387, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_underLine;
        private System.Windows.Forms.Label label_keyName;
    }
}
