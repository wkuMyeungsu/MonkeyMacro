using MonkeyMacro.Objects;
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

            // labelTitle
            labelTitle.Left = (this.panelTitleBar.Width - labelTitle.Width) / 2;
            labelTitle.Top = (this.panelTitleBar.Height - labelTitle.Height) / 2;

            // textBoxPassWord
            textBoxPassWord.PasswordChar = '*';

            // FormStyling
            FormStyling.ApplyShadow(this);
            FormStyling.ApplyRoundedCorners(this, 5, 5);
        }

        private void InitializeEventHandlers()
        {
            panelTitleBar.MouseDown += OnPanelTitleBarMouseDown;
            panelTitleBar.MouseMove += OnPanelTitleBarMouseMove;
            panelTitleBar.MouseUp += OnPanelTitleBarMouseUp;
            pictureBoxButtonExit.MouseMove += OnPictureBoxButtonMove;
            textBoxUserName.KeyPress += OnTextBoxUserNameKeyPress;
            textBoxPassWord.KeyPress += OnTextBoxPassWordKeyPress;
        }

        private void OnTextBoxUserNameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxPassWord.Focus();

                // Enter 키 입력을 처리했음을 표시하여 경고음이 발생하지 않도록 함
                e.Handled = true;
            }
        }

        private void OnTextBoxPassWordKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.Focus();

                // Enter 키 입력을 처리했음을 표시하여 경고음이 발생하지 않도록 함
                e.Handled = true;
            }
        }

        private void OnPictureBoxButtonMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void OnPanelTitleBarMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                draggingStartPoint = new Point(e.X, e.Y);
            }
        }

        private void OnPanelTitleBarMouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void OnPanelTitleBarMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - draggingStartPoint.X, point.Y - draggingStartPoint.Y);
            }
        }

        private void OnPictureBoxButtonExitClick(object sender, EventArgs e)
        {
            // DialogResult를 Cancel로 설정하여 부모 폼에 알림
            this.DialogResult = DialogResult.Cancel;

            // 폼 닫기
            this.Close();
        }

        private async void OnButtonLoginClick(object sender, EventArgs e)
        {
            UserName = textBoxUserName.Text.Trim(); // 공백제거
            Password = textBoxPassWord.Text.Trim(); // 공백제거

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
