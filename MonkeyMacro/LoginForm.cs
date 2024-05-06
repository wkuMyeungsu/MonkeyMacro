using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyMacro
{
    public partial class LoginForm : Form
    {
        private bool isDragging;
        private Point draggingStartPoint;

        string userName;
        string password;

        public LoginForm()
        {
            InitializeComponent();
            InitializeLayout();
            InitializeEventHandlers();
        }

        private void InitializeLayout()
        {
            // LoginForm
            this.Opacity = 0.9;

            // label_title
            label_title.Left = (this.panel_titleBar.Width - label_title.Width) / 2;
            label_title.Top = (this.panel_titleBar.Height - label_title.Height) / 2;

            // textBox_passWord
            textBox_passWord.PasswordChar = '*';
        }

        private void InitializeEventHandlers()
        {
            panel_titleBar.MouseDown += PanelTitleBar_MouseDown;
            panel_titleBar.MouseMove += PanelTitleBar_MouseMove;
            panel_titleBar.MouseUp += PanelTitleBar_MouseUp;
            pictureBoxButton_exit.MouseMove += pictureBoxButton_Move;
            textBox_userName.KeyPress += textBox_userName_KeyPress;
            textBox_passWord.KeyPress += textBox_passWord_KeyPress;
        }

        private void textBox_userName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                textBox_passWord.Focus();

                // Enter 키 입력을 처리했음을 표시하여 경고음이 발생하지 않도록 함
                e.Handled = true;
            }
        }

        private void textBox_passWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_login.Focus();

                // Enter 키 입력을 처리했음을 표시하여 경고음이 발생하지 않도록 함
                e.Handled = true;
            }
        }

        private void pictureBoxButton_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                draggingStartPoint = new Point(e.X, e.Y);
            }
        }

        private void PanelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void PanelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - draggingStartPoint.X, point.Y - draggingStartPoint.Y);
            }
        }

        private void pictureBoxButton_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            userName = textBox_userName.Text;
            password = textBox_passWord.Text;

            // 임시 아이디
            if(userName == "admin" && password == "1234")
            {
                this.DialogResult = DialogResult.OK;
            }else
            {
                MessageBox.Show("잘못된 아이디 또는 비밀번호 입니다.");
            }
        }
    }
}
