using MonkeyMacro.UserControls;
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
    public partial class MainForm : Form
    {
        private bool isDragging = false;
        private Point draggingStartPoint;

        public MainForm()
        {
            InitializeComponent();
            this.pictureBoxButtonExit.MouseMove += pictureBoxButton_Move;
            this.pictureBoxButtonMinimize.MouseMove += pictureBoxButton_Move;
            this.Activated += MainForm_Activated;

            panelTitleBar.MouseDown += PanelTitleBar_MouseDown;
            panelTitleBar.MouseMove += PanelTitleBar_MouseMove;
            panelTitleBar.MouseUp += PanelTitleBar_MouseUp;

            UC_Home uc = new UC_Home();
            switchUserControl(uc);
            this.TopMost = true;


        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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
            if(isDragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - draggingStartPoint.X, point.Y - draggingStartPoint.Y);
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }else
            {
                this.WindowState= FormWindowState.Minimized;
            }
        }

        private void switchUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
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
    }
}
