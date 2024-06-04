namespace MonkeyMacro.UserControls
{
    partial class UserControlKeyItem
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
            this.labelShortcutName = new System.Windows.Forms.Label();
            this.textBoxKeyCombination = new System.Windows.Forms.TextBox();
            this.pictureBoxButtonEdit = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtonDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKeyName
            // 
            this.labelShortcutName.AutoSize = true;
            this.labelShortcutName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShortcutName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelShortcutName.Location = new System.Drawing.Point(14, 11);
            this.labelShortcutName.Name = "labelKeyName";
            this.labelShortcutName.Size = new System.Drawing.Size(108, 27);
            this.labelShortcutName.TabIndex = 1;
            this.labelShortcutName.Text = "단축키 별명";
            // 
            // textBox1
            // 
            this.textBoxKeyCombination.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxKeyCombination.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyCombination.Location = new System.Drawing.Point(37, 56);
            this.textBoxKeyCombination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKeyCombination.Name = "textBox1";
            this.textBoxKeyCombination.ReadOnly = true;
            this.textBoxKeyCombination.Size = new System.Drawing.Size(245, 32);
            this.textBoxKeyCombination.TabIndex = 2;
            this.textBoxKeyCombination.Text = "Ctrl + V";
            // 
            // pictureBoxButtonEdit
            // 
            this.pictureBoxButtonEdit.Image = global::MonkeyMacro.Properties.Resources.white_edit_sqare;
            this.pictureBoxButtonEdit.Location = new System.Drawing.Point(266, 11);
            this.pictureBoxButtonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxButtonEdit.Name = "pictureBoxButtonEdit";
            this.pictureBoxButtonEdit.Size = new System.Drawing.Size(18, 20);
            this.pictureBoxButtonEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButtonEdit.TabIndex = 4;
            this.pictureBoxButtonEdit.TabStop = false;
            // 
            // pictureBoxButtonDelete
            // 
            this.pictureBoxButtonDelete.Image = global::MonkeyMacro.Properties.Resources.white_trash;
            this.pictureBoxButtonDelete.Location = new System.Drawing.Point(291, 11);
            this.pictureBoxButtonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxButtonDelete.Name = "pictureBoxButtonDelete";
            this.pictureBoxButtonDelete.Size = new System.Drawing.Size(18, 20);
            this.pictureBoxButtonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButtonDelete.TabIndex = 5;
            this.pictureBoxButtonDelete.TabStop = false;
            // 
            // UserControlKeyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.pictureBoxButtonDelete);
            this.Controls.Add(this.pictureBoxButtonEdit);
            this.Controls.Add(this.textBoxKeyCombination);
            this.Controls.Add(this.labelShortcutName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlKeyItem";
            this.Size = new System.Drawing.Size(319, 105);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelShortcutName;
        private System.Windows.Forms.TextBox textBoxKeyCombination;
        private System.Windows.Forms.PictureBox pictureBoxButtonEdit;
        private System.Windows.Forms.PictureBox pictureBoxButtonDelete;
    }
}
