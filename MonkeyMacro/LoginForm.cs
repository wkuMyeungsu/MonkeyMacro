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

        public LoginForm()
        {
            InitializeComponent();
            InitializeLayout();
            InitializeEventHandlers();
        }

        private void InitializeLayout()
        {
            // label title
            label_title.Left = (this.panel_titleBar.Width - label_title.Width) / 2;
            label_title.Top = (this.panel_titleBar.Height - label_title.Height) / 2;
        }

        private void InitializeEventHandlers()
        {
            panel_titleBar.MouseDown += PanelTitleBar_MouseDown;
            panel_titleBar.MouseMove += PanelTitleBar_MouseMove;
            panel_titleBar.MouseUp += PanelTitleBar_MouseUp;
            pictureBoxButton_exit.MouseMove += pictureBoxButton_Move;
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
    }
}
