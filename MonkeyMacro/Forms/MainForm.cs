using MonkeyMacro.Forms;
using MonkeyMacro.Objects;
using MonkeyMacro.UserControls;
using System;
using System.Collections.Generic;
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
        private Point draggingStartPoint;

        private FirebaseController firebaseController;
        public UserData userDataStorage;
        private string tracingAppName;

        private bool isLogin; //로그인 상태 확인
        private bool isHome;
        public bool useTrayMinimize; //트레이로 최소화

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        private Timer updateTimer;

        public MainForm()
        {
            InitializeComponent();

            InitializeEventHandlers();
            InitializeAttributes();
            InitializeLayout();
            InitializeDefaultUserControl();

            // 로그인 폼 표시
            ShowLoginForm();
        }

        private void InitializeLayout()
        {

        }

        private void InitializeUpdateTimer()
        {
            updateTimer = new Timer();
            updateTimer.Interval = 100; // 0.1초마다 업데이트
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
                isLogin = true;
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
                            LoadUserSettings(); // UI 설정 초기화
                            InitializeUpdateTimer();
                            this.Show(); // 데이터 로드 성공시 메인 폼 표시
                        }));
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                this.Close();
            }
        }

        private void LoadUserSettings()
        {
            UserSettings _userSettings = userDataStorage.UserSettings;

            this.Opacity = _userSettings.Opacity;
            this.TopMost = _userSettings.TopMost;
            useTrayMinimize = _userSettings.UseTrayMinimize;
        }

        private void InitializeDefaultUserControl()
        {
            UserControlHome uc = new UserControlHome();
            SwitchUserControl(uc);

            isHome = true;
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
            tracingAppName = "Tracing";
            useTrayMinimize = false;
            isLogin = false;
        }

        private async Task LoadInitUserData(string userName)
        {
            var data = await firebaseController.GetUserData(userName);
            if (data != null)
            {
                userDataStorage = new UserData();
                userDataStorage.UserName = userName;
                userDataStorage.LoadFromFirebaseController(data);
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
                if(userDataStorage != null)
                {
                    UpdateHomeKeyItems(tracingAppName);
                }
            }
            else
            {
                isHome = false;
            }

            ChangeUtilityButton();
        }

        private void UpdateHomeKeyItems(string tracingAppName)
        {
            if (userDataStorage == null)
            {
                
                MessageBox.Show("User data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserControlHome homeControl = panelContainer.Controls.OfType<UserControlHome>().FirstOrDefault();
            if (homeControl != null)
            {
                var appsShortcutDict = userDataStorage.AppsShortcutDict;
                foreach ( var appShortcut in appsShortcutDict.Keys )
                {
                    if ( appShortcut == tracingAppName)
                    {
                    }
                }
                homeControl.UpdateControl(tracingAppName, appsShortcutDict);
            }
        }

        private void ChangeUtilityButton()
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
            if (useTrayMinimize)
                this.Hide();
            else
                // 사용자 정보 저장 함수 호출
                ExitApplication();
        }

        private void ExitApplication()
        {
            // 종료 확인 메시지 박스
            string dialogTitle = "종료 확인";
            string dialogMessage = "프로그램을 정말 종료 하시겠습니까?";
            string dialogOKText = "OK";
            string dialogCancelText = "Cancel";

            bool dialogResult = AlertDialog.ShowDialog(this, dialogTitle, dialogMessage, dialogOKText, dialogCancelText);
            if (dialogResult)
            {
                // 사용자 정보 저장 함수 호출
                SaveUserInfo();

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
                //testFuncAsync();
                testPrint();
            }
            else
            {
                UserControlHome uc = new UserControlHome();
                SwitchUserControl(uc);
            }
        }

        private async Task testFuncAsync()
        {
            string userName = userDataStorage.UserName;
            string applicationName = "Visual Studio";
            string shortcutName = "Copy";
            string[] keys = new string[] { "Ctrl", "C" };

            await firebaseController.SetUserShortcut(userName, applicationName, shortcutName, keys);
            //await firebaseController.DeleteUserShortcut(userName, applicationName, shortcutName);
            //await firebaseController.UpdateUserSettings(userName, 55, false, true);
        }

        private void testPrint()
        {
            if (userDataStorage == null)
            {
                MessageBox.Show("User data is not loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 결과 문자열을 구성합니다.
            StringBuilder result = new StringBuilder();
            result.AppendLine("User Data Keys:");
            result.AppendLine($"UserName: {userDataStorage.UserName}");

            result.AppendLine("\nApplications and Shortcuts:");
            foreach (var app in userDataStorage.AppsShortcutDict)
            {
                result.AppendLine($"{app.Key}:");
                foreach (var shortcut in app.Value.ShortcutKeys)
                {
                    result.AppendLine($"  {shortcut.Key}: {string.Join(", ", shortcut.Value.Keys)}");
                }
            }

            result.AppendLine("\nUser Settings:");
            result.AppendLine($"Opacity: {userDataStorage.UserSettings.Opacity}");
            result.AppendLine($"TopMost: {userDataStorage.UserSettings.TopMost}");

            // 결과를 메시지 박스로 표시합니다.
            MessageBox.Show(result.ToString(), "User Data Overview", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            string processName = GetActiveWindowProcessName();
            string newTracingAppName = GetTracingAppName(processName);

            if (newTracingAppName != null)
            {
                if (!tracingAppName.Equals(newTracingAppName))
                {
                    tracingAppName = newTracingAppName;
                    labelMenuInfo.Text = $"Tracing : {tracingAppName}";
                    UpdateHomeKeyItems(tracingAppName);
                }
            }
        }

        private string GetTracingAppName(string processName)
        {
            switch(processName)
            {
                case "WINWORD":
                    return "MS Word";
                case "POWERPNT":
                    return "MS PowerPoint";
                case "EXCEL":
                    return "MS Excel";
                case "devenv":
                    return "Visual Studio";
                case "Hwp":
                    return "한글";
                default:
                    return null;
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
            if (isLogin)
                this.Show();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLogin)
                this.Show();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
    }
}
