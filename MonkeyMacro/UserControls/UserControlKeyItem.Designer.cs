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
            this.labelKeyName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKeyName
            // 
            this.labelKeyName.AutoSize = true;
            this.labelKeyName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeyName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelKeyName.Location = new System.Drawing.Point(15, 9);
            this.labelKeyName.Name = "labelKeyName";
            this.labelKeyName.Size = new System.Drawing.Size(100, 23);
            this.labelKeyName.TabIndex = 1;
            this.labelKeyName.Text = "단축키 별명";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(19, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(204, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Ctrl + V";
            // 
            // button_settings
            // 
            this.button_settings.Image = global::MonkeyMacro.Properties.Resources.setting;
            this.button_settings.Location = new System.Drawing.Point(229, 41);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(32, 32);
            this.button_settings.TabIndex = 3;
            this.button_settings.UseVisualStyleBackColor = true;
            // 
            // UserControlKeyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelKeyName);
            this.Name = "UserControlKeyItem";
            this.Size = new System.Drawing.Size(279, 84);
            this.Load += new System.EventHandler(this.UserControlKeyItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelKeyName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_settings;
    }
}
