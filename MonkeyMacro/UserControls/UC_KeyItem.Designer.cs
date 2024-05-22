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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KeyItem));
            this.label_underLine = new System.Windows.Forms.Label();
            this.label_keyName = new System.Windows.Forms.Label();
            this.pictureBoxButton_Edit = new System.Windows.Forms.PictureBox();
            this.pictureBoxButton_delete = new System.Windows.Forms.PictureBox();
            this.panel_keyContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // label_underLine
            // 
            this.label_underLine.AutoSize = true;
            this.label_underLine.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_underLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_underLine.Location = new System.Drawing.Point(64, 12);
            this.label_underLine.Name = "label_underLine";
            this.label_underLine.Size = new System.Drawing.Size(283, 44);
            this.label_underLine.TabIndex = 0;
            this.label_underLine.Text = "⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯⎯";
            // 
            // label_keyName
            // 
            this.label_keyName.AutoSize = true;
            this.label_keyName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_keyName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_keyName.Location = new System.Drawing.Point(162, 6);
            this.label_keyName.Name = "label_keyName";
            this.label_keyName.Size = new System.Drawing.Size(108, 27);
            this.label_keyName.TabIndex = 1;
            this.label_keyName.Text = "단축키 별명";
            // 
            // pictureBoxButton_Edit
            // 
            this.pictureBoxButton_Edit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxButton_Edit.Image")));
            this.pictureBoxButton_Edit.Location = new System.Drawing.Point(398, 9);
            this.pictureBoxButton_Edit.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxButton_Edit.Name = "pictureBoxButton_Edit";
            this.pictureBoxButton_Edit.Size = new System.Drawing.Size(18, 21);
            this.pictureBoxButton_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButton_Edit.TabIndex = 4;
            this.pictureBoxButton_Edit.TabStop = false;
            // 
            // pictureBoxButton_delete
            // 
            this.pictureBoxButton_delete.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxButton_delete.Image")));
            this.pictureBoxButton_delete.Location = new System.Drawing.Point(368, 9);
            this.pictureBoxButton_delete.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxButton_delete.Name = "pictureBoxButton_delete";
            this.pictureBoxButton_delete.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxButton_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButton_delete.TabIndex = 3;
            this.pictureBoxButton_delete.TabStop = false;
            // 
            // panel_keyContainer
            // 
            this.panel_keyContainer.BackColor = System.Drawing.Color.White;
            this.panel_keyContainer.ForeColor = System.Drawing.Color.Transparent;
            this.panel_keyContainer.Location = new System.Drawing.Point(26, 52);
            this.panel_keyContainer.Name = "panel_keyContainer";
            this.panel_keyContainer.Size = new System.Drawing.Size(369, 71);
            this.panel_keyContainer.TabIndex = 5;
            // 
            // UC_KeyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.panel_keyContainer);
            this.Controls.Add(this.pictureBoxButton_Edit);
            this.Controls.Add(this.pictureBoxButton_delete);
            this.Controls.Add(this.label_keyName);
            this.Controls.Add(this.label_underLine);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_KeyItem";
            this.Size = new System.Drawing.Size(423, 138);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_underLine;
        private System.Windows.Forms.Label label_keyName;
        private System.Windows.Forms.PictureBox pictureBoxButton_delete;
        private System.Windows.Forms.PictureBox pictureBoxButton_Edit;
        private System.Windows.Forms.Panel panel_keyContainer;
    }
}
