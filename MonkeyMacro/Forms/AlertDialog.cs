using MonkeyMacro.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyMacro.Forms
{
    public partial class AlertDialog : Form
    {
        private bool isDragging;
        private Point draggingStartPoint;

        public AlertDialog(string title, string message, string okButtonText, string cancelButtonText)
        {
            InitializeComponent();
            InitializeLayout();
            InitializeEventHandlers();

            // 각 컴포넌트에 전달받은 값을 설정
            labelTitle.Text = title;  // 폼의 제목
            labelMessage.Text = message;  // 메시지 내용
            buttonOK.Text = okButtonText;  // OK 버튼 텍스트
            buttonCancel.Text = cancelButtonText;  // 취소 버튼 텍스트
        }

        private void InitializeEventHandlers()
        {
            buttonOK.Click += OnButtonOKClick;
            buttonCancel.Click += OnButtonCancelClick;
            pictureBoxButtonExit.Click += OnPictureBoxButtonExitClick;
            pictureBoxButtonExit.MouseMove += OnPictureBoxButtonMove;

            panelTitleBar.MouseDown += OnPanelTitleBarMouseDown;
            panelTitleBar.MouseMove += OnPanelTitleBarMouseMove;
            panelTitleBar.MouseUp += OnPanelTitleBarMouseUp;
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

        private void OnButtonOKClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OnButtonCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OnPictureBoxButtonExitClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OnPictureBoxButtonMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void InitializeLayout()
        {
            // labelMessage
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            labelMessage.Dock = DockStyle.Fill;
            labelMessage.AutoSize = false;

            // buttonOK
            buttonOK.TextAlign = ContentAlignment.MiddleCenter;

            // buttonCancel
            buttonCancel.TextAlign = ContentAlignment.MiddleCenter;
        }

        // 정적 메서드: 다이얼로그 표시 및 결과 반환
        public static bool ShowDialog(Form parentForm, string title, string message, string okButtonText, string cancelButtonText)
        {
            using (AlertDialog dialog = new AlertDialog(title, message, okButtonText, cancelButtonText))
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.TopMost = parentForm.TopMost;  // 부모 폼의 TopMost 상태에 따라 다이얼로그의 TopMost 설정
                return dialog.ShowDialog() == DialogResult.OK;
            }
        }


    }
}
