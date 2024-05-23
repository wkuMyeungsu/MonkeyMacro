﻿using Google.Cloud.Firestore;
using MonkeyMacro.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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

        public MainForm()
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeDefaultUserControl();
            InitializeAttributes();

            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();

            // DataController의 인스턴스를 가져와서 할당
            dataController = DataController.Instance;

            // 로그인 성공시
            if (result == DialogResult.OK)
            {
                userData = new UserData();
                userData.UserName = loginForm.UserName;

                this.Show();
            }
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
        }

        private void InitializeAttributes()
        {
            setUserSetting();
            isDragging = false;
            isHome = true;
        }

        private void setUserSetting()
        {
            this.TopMost = true;
            this.Opacity = 90;
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
            // 사용자 정보 저장 함수 호출
            SaveUserInfo();

            this.Close();
        }

        private void SaveUserInfo()
        {
            // 나중에 작업 할 것임
            throw new NotImplementedException();
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
                MessageBox.Show("add Key");
                //testFunc(sender, e);
            }
            else
            {
                UC_Home uc = new UC_Home();
                switchUserControl(uc);
            }
        }

        private void testFunc(object sender, EventArgs e)
        {
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
    }
}
