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
            this.panel_titleBar = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBoxButton_exit = new System.Windows.Forms.PictureBox();
            this.textBox_passWord = new System.Windows.Forms.TextBox();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.label_passWord = new System.Windows.Forms.Label();
            this.label_userName = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.panel_titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titleBar
            // 
            this.panel_titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(55)))), ((int)(((byte)(91)))));
            this.panel_titleBar.Controls.Add(this.label_title);
            this.panel_titleBar.Controls.Add(this.pictureBoxButton_exit);
            this.panel_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titleBar.Location = new System.Drawing.Point(0, 0);
            this.panel_titleBar.Name = "panel_titleBar";
            this.panel_titleBar.Size = new System.Drawing.Size(413, 65);
            this.panel_titleBar.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(154, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(100, 32);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Sign In";
            // 
            // pictureBoxButton_exit
            // 
            this.pictureBoxButton_exit.Image = global::MonkeyMacro.Properties.Resources.white_cross;
            this.pictureBoxButton_exit.Location = new System.Drawing.Point(388, 8);
            this.pictureBoxButton_exit.Name = "pictureBoxButton_exit";
            this.pictureBoxButton_exit.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxButton_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxButton_exit.TabIndex = 2;
            this.pictureBoxButton_exit.TabStop = false;
            this.pictureBoxButton_exit.Click += new System.EventHandler(this.pictureBoxButton_exit_Click);
            // 
            // textBox_passWord
            // 
            this.textBox_passWord.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox_passWord.Location = new System.Drawing.Point(112, 176);
            this.textBox_passWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_passWord.Name = "textBox_passWord";
            this.textBox_passWord.Size = new System.Drawing.Size(192, 23);
            this.textBox_passWord.TabIndex = 13;
            // 
            // textBox_userName
            // 
            this.textBox_userName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userName.Location = new System.Drawing.Point(112, 124);
            this.textBox_userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(192, 23);
            this.textBox_userName.TabIndex = 12;
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
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button_login.Location = new System.Drawing.Point(112, 207);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(95, 28);
            this.button_login.TabIndex = 15;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
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
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_passWord);
            this.Controls.Add(this.textBox_userName);
            this.Controls.Add(this.label_passWord);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.panel_titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel_titleBar.ResumeLayout(false);
            this.panel_titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButton_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_titleBar;
        private System.Windows.Forms.PictureBox pictureBoxButton_exit;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_passWord;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Label label_passWord;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_SignUp;
    }
}