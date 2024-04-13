namespace MonkeyMacro.UserControls
{
    partial class UC_Home
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
            this.labelTestHome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTestHome
            // 
            this.labelTestHome.AutoSize = true;
            this.labelTestHome.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestHome.ForeColor = System.Drawing.Color.White;
            this.labelTestHome.Location = new System.Drawing.Point(156, 207);
            this.labelTestHome.Name = "labelTestHome";
            this.labelTestHome.Size = new System.Drawing.Size(91, 32);
            this.labelTestHome.TabIndex = 0;
            this.labelTestHome.Text = "Home";
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(86)))), ((int)(((byte)(142)))));
            this.Controls.Add(this.labelTestHome);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(407, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTestHome;
    }
}
