using MonkeyMacro.UserControls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MonkeyMacro
{
    public partial class MainForm : Form
    {
        private bool isDragging;
        private bool isHome;
        private Point draggingStartPoint;

        private DataController dataController;
        private UserData userData;

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        private Timer updateTimer;

        public MainForm()
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeDefaultUserControl();
            InitializeAttributes();
            ShowLoginForm();

            InitializeUpdateTimer();
        }

        private void InitializeUpdateTimer()
        {
            updateTimer = new Timer();
            updateTimer.Interval = 1000; // 1초마다 업데이트
            updateTimer.Tick += OnUpdateTimerTick;  //TimerTic마다 내용 업데이트(추적프로그램 및 라벨)
            updateTimer.Start();
        }

        private void ShowLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();

            dataController = DataController.Instance;

            if (result == DialogResult.OK)
            {
                userData = new UserData();
                userData.UserName = loginForm.UserName;
                this.Show();
            }else
            {
                this.Close();
            }
        }

        private void InitializeDefaultUserControl()
        {
            UserControlHome uc = new UserControlHome();
            SwitchUserControl(uc);
        }

        private void InitializeEventHandlers()
        {
            panelTitleBar.MouseDown += OnPanelTitleBarMouseDown;
            panelTitleBar.MouseMove += OnPanelTitleBarMouseMove;
            panelTitleBar.MouseUp += OnPanelTitleBarMouseUp;
            pictureBoxButtonExit.MouseMove += OnPictureBoxButtonMove;
            pictureBoxButtonMinimize.MouseMove += OnPictureBoxButtonMove;
        }

        private void InitializeAttributes()
        {
            SetUserSettings();
            isDragging = false;
            isHome = true;
        }

        private void SetUserSettings()
        {
            this.TopMost = true;
            this.Opacity = 90;
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

        private void SwitchUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

            if (userControl.GetType() == typeof(UserControlHome))
            {
                isHome = true;
            }
            else
            {
                isHome = false;
            }
            ChangeUtilityButton(isHome);
        }

        private void ChangeUtilityButton(bool isHome)
        {
            if (isHome)
            {
                buttonUtility.Image = Properties.Resources.plus;
            }
            else
            {
                buttonUtility.Image = Properties.Resources.back;
            }
        }

        private void OnPictureBoxButtonMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void OnPictureBoxButtonExitClick(object sender, EventArgs e)
        {
            // 사용자 정보 저장 함수 호출
            ExitApplication();
        }

        private void ExitApplication()
        {
            // 사용자 정보 저장 함수 호출
            SaveUserInfo();

            // 종료 확인 메시지 박스
            DialogResult result = MessageBox.Show("프로그램을 종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SaveUserInfo()
        {
        }

        private void OnPictureBoxButtonMinimizeClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnButtonManageKeysClick(object sender, EventArgs e)
        {
            UserControlManageKey uc = new UserControlManageKey();
            SwitchUserControl(uc);
        }

        private void OnButtonSettingsClick(object sender, EventArgs e)
        {
            UserControlSettings uc = new UserControlSettings();
            SwitchUserControl(uc);
        }

        private void OnButtonUtilityClick(object sender, EventArgs e)
        {
            if (isHome)
            {
                MessageBox.Show("add Key");
                //testFunc(sender, e);
            }
            else
            {
                UserControlHome uc = new UserControlHome();
                SwitchUserControl(uc);
            }
        }

        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            String processName = GetActiveWindowProcessName();  //프로세스 명
            String programName = "Detecting";                   //프로그램 명

            switch (processName)    //프로세스 명에 따른 프로그램 명으로 라벨 변경
            {
                case "MonkeyMacro":
                    break;
                case "WINWORD":
                    programName = "MS Word";
                    labelMenuInfo.Text = "Tracing: " + programName;
                    break;
                case "POWERPNT":
                    programName = "MS PowerPoint";
                    labelMenuInfo.Text = "Tracing: " + programName;
                    break;
                case "EXCEL":
                    programName = "MS Excel";
                    labelMenuInfo.Text = "Tracing: " + programName;
                    break;
                case "devenv":
                    programName = "Visual Studio";
                    labelMenuInfo.Text = "Tracing: " + programName;
                    break;
                case "Hwp":
                    programName = "한글";
                    labelMenuInfo.Text = "Tracing: " + programName;
                    break;
                default:
                    labelMenuInfo.Text = "Tracing: " + programName;
                    break;
            }
        }

        private string GetActiveWindowProcessName()
        {
            IntPtr windowHandle = GetForegroundWindow();
            if (windowHandle == IntPtr.Zero)
                return "No active window";

            GetWindowThreadProcessId(windowHandle, out uint processId);

            try
            {
                Process process = Process.GetProcessById((int)processId);
                return process.ProcessName;
            }
            catch (ArgumentException)
            {
                return "Unknown";
            }
        }
    }
}
