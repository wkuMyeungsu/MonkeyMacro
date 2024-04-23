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
        public MainForm()
        {
            InitializeComponent();
            this.pictureBoxButtonExit.MouseMove += pictureBoxButton_Move;
            this.pictureBoxButtonMinimize.MouseMove += pictureBoxButton_Move;
            this.pictureBoxButtonTray.MouseMove += pictureBoxButton_Move;

            UC_Home uc = new UC_Home();
            addUserControl(uc);

            MessageBox.Show("git test");
        }

        private void addUserControl(UserControl userControl)
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
            addUserControl(uc);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            addUserControl(uc);
        }
    }
}
