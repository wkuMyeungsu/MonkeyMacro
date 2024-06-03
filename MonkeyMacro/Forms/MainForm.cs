using MonkeyMacro.Forms;
using MonkeyMacro.Objects;
using MonkeyMacro.UserControls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyMacro
{
    public partial class MainForm : Form
    {
        private bool isDragging;
        private bool isHome;
        private Point draggingStartPoint;

        private FirebaseController firebaseController;
        private UserData userData;

        //사용자 설정 값
        private bool user_Loginstate = false;   //로그인 상태 확인
        public double user_Opacityvalue = 0.9;  //투명도 
        public bool user_useTrayMinimize = false;   //트레이로 최소화

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
            InitializeLayout();
            this.Opacity = user_Opacityvalue;  // 설정 초기화 전에 기본 투명도 설정
            InitializeUpdateTimer();

            // 로그인 폼 표시
            ShowLoginForm();
        }

        private void InitializeLayout()
        {
            // FormStyling
            FormStyler.ApplyShadow(this);
            FormStyler.ApplyRoundedCorners(this, 5, 5);
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

            firebaseController = FirebaseController.Instance;

            if (result == DialogResult.OK)
            {
                user_Loginstate = true;
                string userName = loginForm.UserName;

                // 비동기로 사용자 데이터 로드
                LoadInitUserData(userName).ContinueWith(t =>
                {
                    if (t.Exception != null)
                    {
                        MessageBox.Show("Failed to load user data.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close(); // 데이터 로드 실패 시 폼을 닫음
                    }
                    else
                    {
                        this.Invoke(new Action(() =>
                        {
                            ApplyUserSettings(); // UI 설정 초기화
                            this.Show(); // 데이터 로드 성공시 메인 폼 표시
                            testprint();
                            UpdateHomeUserControl();
                        }));
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                this.Close();
            }
        }

        private void ApplyUserSettings()
        {

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
            isDragging = false;
            isHome = true;
        }

        private async Task LoadInitUserData(string userName)
        {
            var data = await firebaseController.GetUserData(userName);
            if (data != null)
            {
                userData = new UserData();
                userData.UserName = userName;
                userData.LoadFromFirebaseController(data);
            }
            else
            {
                MessageBox.Show("Failed to load user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                UpdateHomeUserControl();
            }
            else
            {
                isHome = false;
            }
            ChangeUtilityButton(isHome);
        }

        private void UpdateHomeUserControl()
        {
            if (userData == null)
            {
                
                MessageBox.Show("User data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserControlHome homeControl = panelContainer.Controls.OfType<UserControlHome>().FirstOrDefault();
            if (homeControl != null)
            {
                string currentProcessName = GetActiveWindowProcessName(); // 현재 활성화된 프로세스 이름 가져오기
                homeControl.UpdateControl(currentProcessName, userData.AppsShortcutDict);
            }
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
            if (user_useTrayMinimize)
                this.Hide();
            else
                // 사용자 정보 저장 함수 호출
                ExitApplication();
        }

        private void ExitApplication()
        {
            // 사용자 정보 저장 함수 호출
            SaveUserInfo();

            // 종료 확인 메시지 박스
            string dialogTitle = "종료 확인";
            string dialogMessage = "프로그램을 정말 종료 하시겠습니까?";
            string dialogOKText = "OK";
            string dialogCancelText = "Cancel";

            bool dialogResult = AlertDialog.ShowDialog(this, dialogTitle, dialogMessage, dialogOKText, dialogCancelText);
            if (dialogResult)
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
                testFuncAsync();
            }
            else
            {
                UserControlHome uc = new UserControlHome();
                SwitchUserControl(uc);
            }
        }

        private async Task testFuncAsync()
        {
            string userName = userData.UserName;
            string applicationName = "Excel";
            string shortcutName = "Paste";
            string[] keys = new string[] { "Ctrl", "V" };

            //await firebaseController.SetUserShortcut(userName, applicationName, shortcutName, keys);
            //await firebaseController.DeleteUserShortcut(userName, applicationName, shortcutName);
            await firebaseController.UpdateUserSettings(userName, 55, false, true);
        }

        private void testprint()
        {
            if (userData == null)
            {
                MessageBox.Show("User data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 결과 문자열을 구성합니다.
            StringBuilder result = new StringBuilder();
            result.AppendLine("User Data Keys:");
            result.AppendLine($"UserName: {userData.UserName}");

            result.AppendLine("\nApplications and Shortcuts:");
            foreach (var app in userData.AppsShortcutDict)
            {
                result.AppendLine($"{app.Key}:");
                foreach (var shortcut in app.Value.ShortcutKeys)
                {
                    result.AppendLine($"  {shortcut.Key}: {string.Join(", ", shortcut.Value.Keys)}");
                }
            }

            result.AppendLine("\nUser Settings:");
            result.AppendLine($"Opacity: {userData.UserSettings.Opacity}");
            result.AppendLine($"TopMost: {userData.UserSettings.TopMost}");

            // 결과를 메시지 박스로 표시합니다.
            MessageBox.Show(result.ToString(), "User Data Overview", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    UpdateHomeUserControl();
                    break;
                case "POWERPNT":
                    programName = "MS PowerPoint";
                    labelMenuInfo.Text = "Tracing: " + programName;
                    UpdateHomeUserControl();
                    break;
                case "EXCEL":
                    programName = "MS Excel";
                    labelMenuInfo.Text = "Tracing: " + programName;
                    UpdateHomeUserControl();
                    break;
                case "devenv":
                    programName = "Visual Studio";
                    labelMenuInfo.Text = "Tracing: " + programName;
                    UpdateHomeUserControl();
                    break;
                case "Hwp":
                    programName = "한글";
                    labelMenuInfo.Text = "Tracing: " + programName;
                    UpdateHomeUserControl();
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

        //트레이 관련 동작들 
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (user_Loginstate)
                this.Show();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user_Loginstate)
                this.Show();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
    }
}
