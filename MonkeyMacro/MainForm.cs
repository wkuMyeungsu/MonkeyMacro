using MonkeyMacro.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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

        public MainForm()
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeDefaultUserControl();
            InitializeAttributes();
        }

        private void InitializeDefaultUserControl()
        {
            UC_Home uc = new UC_Home();
            switchUserControl(uc);
        }

        private void InitializeEventHandlers()
        {
            panel_titleBar.MouseDown += PanelTitleBar_MouseDown;
            panel_titleBar.MouseMove += PanelTitleBar_MouseMove;
            panel_titleBar.MouseUp += PanelTitleBar_MouseUp;
            pictureBoxButton_exit.MouseMove += pictureBoxButton_Move;
            pictureBoxButton_minimize.MouseMove += pictureBoxButton_Move;
            notifyIcon.MouseClick += NotifyIcon_MouseClick;
        }

        private void InitializeAttributes()
        {
            this.TopMost = true;
            isDragging = false;
            isHome = true;
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 왼쪽 버튼을 클릭했을 때 실행할 동작을 여기에 작성
                Console.WriteLine("작업 표시줄 아이콘을 클릭했습니다.");
            }
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

        private void switchUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;

            panel_container.Controls.Clear();
            panel_container.Controls.Add(userControl);
            userControl.BringToFront();

            if (userControl.GetType() == typeof(UC_Home))
            {
                isHome = true;
            }
            else
            {
                isHome = false;
            }
            changeUtilityButton(isHome);
        }

        private void changeUtilityButton(bool isHome)
        {
            if (isHome)
            {
                button_utility.Image = Properties.Resources.plus;
            }
            else
            {
                button_utility.Image = Properties.Resources.back;
            }
        }

        private void pictureBoxButton_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void pictureBoxButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonManageKeys_Click(object sender, EventArgs e)
        {
            UC_ManageKey uc = new UC_ManageKey();
            switchUserControl(uc);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            switchUserControl(uc);
        }

        private void buttonUtility_Click(object sender, EventArgs e)
        {
            if (isHome)
            {
                //MessageBox.Show("add Key");

                Process[] processes = Process.GetProcesses()
                                             .OrderByDescending(p => p.StartTime)
                                             .ToArray();

                StringBuilder processInfo = new StringBuilder();
                foreach (Process process in processes)
                {
                    processInfo.AppendLine($"{process.ProcessName} - {process.StartTime}");
                }

                MessageBox.Show(processInfo.ToString(), "Recently Started Processes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UC_Home uc = new UC_Home();
                switchUserControl(uc);
            }
        }
    }
}
