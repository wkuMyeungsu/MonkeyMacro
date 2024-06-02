namespace MonkeyMacro
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxButtonExit = new System.Windows.Forms.PictureBox();
            this.textBoxPassWord = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label_passWord = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(91)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.pictureBoxButtonExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panel_titleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(413, 65);
            this.panelTitleBar.TabIndex = 1;
            // 
            // label_title
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(154, 20);
            this.labelTitle.Name = "label_title";
            this.labelTitle.Size = new System.Drawing.Size(100, 32);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Sign In";
            // 
            // pictureBoxButton_exit
            // 
            this.pictureBoxButtonExit.Image = global::MonkeyMacro.Properties.Resources.white_cross;
            this.pictureBoxButtonExit.Location = new System.Drawing.Point(388, 8);
            this.pictureBoxButtonExit.Name = "pictureBoxButton_exit";
            this.pictureBoxButtonExit.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButtonExit.TabIndex = 2;
            this.pictureBoxButtonExit.TabStop = false;
            this.pictureBoxButtonExit.Click += new System.EventHandler(this.OnPictureBoxButtonExitClick);
            // 
            // textBox_passWord
            // 
            this.textBoxPassWord.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxPassWord.Location = new System.Drawing.Point(112, 176);
            this.textBoxPassWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassWord.Name = "textBox_passWord";
            this.textBoxPassWord.Size = new System.Drawing.Size(192, 23);
            this.textBoxPassWord.TabIndex = 13;
            // 
            // textBox_userName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(112, 124);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserName.Name = "textBox_userName";
            this.textBoxUserName.Size = new System.Drawing.Size(192, 23);
            this.textBoxUserName.TabIndex = 12;
            // 
            // label_passWord
            // 
            this.label_passWord.AutoSize = true;
            this.label_passWord.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_passWord.Location = new System.Drawing.Point(108, 153);
            this.label_passWord.Name = "label_passWord";
            this.label_passWord.Size = new System.Drawing.Size(82, 21);
            this.label_passWord.TabIndex = 11;
            this.label_passWord.Text = "Password";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userName.Location = new System.Drawing.Point(108, 101);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(88, 21);
            this.label_userName.TabIndex = 10;
            this.label_userName.Text = "Username";
            // 
            // button_login
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonLogin.Location = new System.Drawing.Point(112, 207);
            this.buttonLogin.Name = "button_login";
            this.buttonLogin.Size = new System.Drawing.Size(95, 28);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.OnButtonLoginClick);
            // 
            // button_SignUp
            // 
            this.button_SignUp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button_SignUp.Location = new System.Drawing.Point(209, 207);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(95, 28);
            this.button_SignUp.TabIndex = 16;
            this.button_SignUp.Text = "Sign Up";
            this.button_SignUp.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 293);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassWord);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label_passWord);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBoxButtonExit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxPassWord;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label_passWord;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button button_SignUp;
    }
}