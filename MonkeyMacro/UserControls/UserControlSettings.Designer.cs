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
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.gropBoxOpacity = new System.Windows.Forms.GroupBox();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.labelUseTrayMinimize = new System.Windows.Forms.Label();
            this.radioButtonNotUseTrayMinimize = new System.Windows.Forms.RadioButton();
            this.radioButtonUseTrayMinimize = new System.Windows.Forms.RadioButton();
            this.groupBoxUseTrayMinimize = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.gropBoxOpacity.SuspendLayout();
            this.groupBoxUseTrayMinimize.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTestSettings
            // 
            this.labelTestSettings.AutoSize = true;
            this.labelTestSettings.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelTestSettings.Location = new System.Drawing.Point(120, 288);
            this.labelTestSettings.Name = "labelTestSettings";
            this.labelTestSettings.Size = new System.Drawing.Size(142, 40);
            this.labelTestSettings.TabIndex = 1;
            this.labelTestSettings.Text = "Settings";
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarOpacity.Location = new System.Drawing.Point(3, 22);
            this.trackBarOpacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Minimum = 10;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(362, 99);
            this.trackBarOpacity.TabIndex = 2;
            this.trackBarOpacity.TickFrequency = 10;
            this.trackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarOpacity.Value = 20;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.OnOpacityTrackScroll);
            // 
            // gropBoxOpacity
            // 
            this.gropBoxOpacity.Controls.Add(this.labelOpacity);
            this.gropBoxOpacity.Controls.Add(this.trackBarOpacity);
            this.gropBoxOpacity.Dock = System.Windows.Forms.DockStyle.Top;
            this.gropBoxOpacity.Location = new System.Drawing.Point(0, 0);
            this.gropBoxOpacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gropBoxOpacity.Name = "gropBoxOpacity";
            this.gropBoxOpacity.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gropBoxOpacity.Size = new System.Drawing.Size(368, 125);
            this.gropBoxOpacity.TabIndex = 3;
            this.gropBoxOpacity.TabStop = false;
            this.gropBoxOpacity.Text = "투명도";
            // 
            // labelOpacity
            // 
            this.labelOpacity.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelOpacity.Location = new System.Drawing.Point(293, 88);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(66, 29);
            this.labelOpacity.TabIndex = 3;
            this.labelOpacity.Text = "XX%";
            this.labelOpacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUseTrayMinimize
            // 
            this.labelUseTrayMinimize.AutoSize = true;
            this.labelUseTrayMinimize.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelUseTrayMinimize.Location = new System.Drawing.Point(23, 25);
            this.labelUseTrayMinimize.Name = "labelUseTrayMinimize";
            this.labelUseTrayMinimize.Size = new System.Drawing.Size(129, 14);
            this.labelUseTrayMinimize.TabIndex = 6;
            this.labelUseTrayMinimize.Text = "X 클릭시 동작 설정";
            // 
            // radioButtonNotUseTrayMinimize
            // 
            this.radioButtonNotUseTrayMinimize.AutoSize = true;
            this.radioButtonNotUseTrayMinimize.Checked = true;
            this.radioButtonNotUseTrayMinimize.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButtonNotUseTrayMinimize.Location = new System.Drawing.Point(223, 62);
            this.radioButtonNotUseTrayMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonNotUseTrayMinimize.Name = "radioButtonNotUseTrayMinimize";
            this.radioButtonNotUseTrayMinimize.Size = new System.Drawing.Size(123, 19);
            this.radioButtonNotUseTrayMinimize.TabIndex = 5;
            this.radioButtonNotUseTrayMinimize.TabStop = true;
            this.radioButtonNotUseTrayMinimize.Text = "프로그램 종료";
            this.radioButtonNotUseTrayMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonNotUseTrayMinimize.UseVisualStyleBackColor = true;
            // 
            // radioButtonUseTrayMinimize
            // 
            this.radioButtonUseTrayMinimize.AutoSize = true;
            this.radioButtonUseTrayMinimize.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButtonUseTrayMinimize.Location = new System.Drawing.Point(58, 62);
            this.radioButtonUseTrayMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonUseTrayMinimize.Name = "radioButtonUseTrayMinimize";
            this.radioButtonUseTrayMinimize.Size = new System.Drawing.Size(123, 19);
            this.radioButtonUseTrayMinimize.TabIndex = 0;
            this.radioButtonUseTrayMinimize.Text = "트레이 최소화";
            this.radioButtonUseTrayMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonUseTrayMinimize.UseVisualStyleBackColor = true;
            this.radioButtonUseTrayMinimize.CheckedChanged += new System.EventHandler(this.OnTrayCheckedChanged);
            // 
            // groupBoxUseTrayMinimize
            // 
            this.groupBoxUseTrayMinimize.Controls.Add(this.labelUseTrayMinimize);
            this.groupBoxUseTrayMinimize.Controls.Add(this.radioButtonNotUseTrayMinimize);
            this.groupBoxUseTrayMinimize.Controls.Add(this.radioButtonUseTrayMinimize);
            this.groupBoxUseTrayMinimize.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxUseTrayMinimize.Font = new System.Drawing.Font("굴림", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBoxUseTrayMinimize.Location = new System.Drawing.Point(0, 125);
            this.groupBoxUseTrayMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxUseTrayMinimize.Name = "groupBoxUseTrayMinimize";
            this.groupBoxUseTrayMinimize.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxUseTrayMinimize.Size = new System.Drawing.Size(368, 100);
            this.groupBoxUseTrayMinimize.TabIndex = 5;
            this.groupBoxUseTrayMinimize.TabStop = false;
            this.groupBoxUseTrayMinimize.Text = "종료설정";
            // 
            // UserControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxUseTrayMinimize);
            this.Controls.Add(this.gropBoxOpacity);
            this.Controls.Add(this.labelTestSettings);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlSettings";
            this.Size = new System.Drawing.Size(368, 492);
            this.Load += new System.EventHandler(this.OnUserControlSettingsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.gropBoxOpacity.ResumeLayout(false);
            this.gropBoxOpacity.PerformLayout();
            this.groupBoxUseTrayMinimize.ResumeLayout(false);
            this.groupBoxUseTrayMinimize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTestSettings;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.GroupBox gropBoxOpacity;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.Label labelUseTrayMinimize;
        private System.Windows.Forms.RadioButton radioButtonNotUseTrayMinimize;
        private System.Windows.Forms.RadioButton radioButtonUseTrayMinimize;
        private System.Windows.Forms.GroupBox groupBoxUseTrayMinimize;
    }
}
