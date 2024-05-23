using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MonkeyMacro
{
    public partial class LoginForm : Form
    {
        private bool isDragging;
        private Point draggingStartPoint;
        private DataController dataController;

        public string UserName { get; private set; }
        public string Password { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            InitializeLayout();
            InitializeEventHandlers();

            // DataController의 인스턴스를 가져와서 할당
            dataController = DataController.Instance;
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
            if (e.KeyChar == (char)Keys.Enter)
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

        private async void button_login_Click(object sender, EventArgs e)
        {
            UserName = textBox_userName.Text.Trim(); // 공백제거
            Password = textBox_passWord.Text.Trim(); // 공백제거

            if (!IsValidUserName(UserName) || !IsValidPassword(Password))
            {
                MessageBox.Show("유효한 아이디와 비밀번호를 입력해 주세요.");
                return;
            }

            bool accountValid = await dataController.CheckUserAccount(UserName, Password);

            if (accountValid)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("존재하지 않는 아이디 또는 비밀번호 입니다.");
            }
        }

        private bool IsValidUserName(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return false;
            }

            // 알파벳 소문자로 시작하고, 알파벳 소문자와 숫자만 허용, 최소 4글자 이상
            Regex regex = new Regex("^[a-z][a-z0-9]{3,}$");
            return regex.IsMatch(userName);
        }

        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            // 알파벳 소문자와 숫자만 허용, 최소 4글자 이상
            Regex regex = new Regex("^[a-z0-9]{4,}$");
            return regex.IsMatch(password);
        }
    }
}
