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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace MonkeyMacro.Forms
{
    public partial class KeyDialog : Form
    {
        private bool isDragging;
        private Point draggingStartPoint;

        public string ShortcutName { get; set; }
        public KeyCombination Keys { get; set; } // KeyCombination 타입으로 수정

        public KeyDialog(string keyName, KeyCombination keys)
        {
            this.ShortcutName = keyName;
            this.Keys = keys;

            InitializeComponent();
            InitializeLayout();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            buttonEdit.Click += OnButtonEditClick;
            buttonSave.Click += OnButtonSaveClick;
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

        private void OnPictureBoxButtonExitClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OnPictureBoxButtonMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
        {
        }

        private void OnButtonEditClick(object sender, EventArgs e)
        {
        }

        private void InitializeLayout()
        {
            // 필요한 레이아웃 초기화 코드 추가
            textBoxKeyName.Text = ShortcutName;
            textBoxKeyCombination.Text = string.Join(" + ", Keys.Keys);
        }

        // 정적 메서드: 다이얼로그 표시 및 결과 반환
        public static bool ShowDialog(Form parentForm, string shortcutName, KeyCombination keys)
        {
            using (KeyDialog editDialog = new KeyDialog(shortcutName, keys))
            {
                editDialog.StartPosition = FormStartPosition.CenterParent;
                editDialog.TopMost = parentForm.TopMost;  // 부모 폼의 TopMost 상태에 따라 다이얼로그의 TopMost 설정
                return editDialog.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
