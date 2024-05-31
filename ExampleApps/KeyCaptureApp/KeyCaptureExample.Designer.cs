namespace KeyCaptureApp
{
    partial class KeyCaptureExample
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
            this.labelCapturedKeys = new System.Windows.Forms.Label();
            this.buttonKeyCapture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCapturedKeys
            // 
            this.labelCapturedKeys.AutoSize = true;
            this.labelCapturedKeys.Location = new System.Drawing.Point(70, 45);
            this.labelCapturedKeys.Name = "labelCapturedKeys";
            this.labelCapturedKeys.Size = new System.Drawing.Size(53, 12);
            this.labelCapturedKeys.TabIndex = 0;
            this.labelCapturedKeys.Text = "단축키 : ";
            // 
            // buttonKeyCapture
            // 
            this.buttonKeyCapture.Location = new System.Drawing.Point(72, 78);
            this.buttonKeyCapture.Name = "buttonKeyCapture";
            this.buttonKeyCapture.Size = new System.Drawing.Size(170, 56);
            this.buttonKeyCapture.TabIndex = 1;
            this.buttonKeyCapture.Text = "키 캡쳐 시작";
            this.buttonKeyCapture.UseVisualStyleBackColor = true;
            this.buttonKeyCapture.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 181);
            this.Controls.Add(this.buttonKeyCapture);
            this.Controls.Add(this.labelCapturedKeys);
            this.Name = "AppForm";
            this.Text = "KeyCaptureApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCapturedKeys;
        private System.Windows.Forms.Button buttonKeyCapture;
    }
}

