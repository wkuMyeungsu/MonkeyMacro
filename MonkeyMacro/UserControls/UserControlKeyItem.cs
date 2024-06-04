using MonkeyMacro.Forms;
using MonkeyMacro.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyMacro.UserControls
{
    public partial class UserControlKeyItem : UserControl
    {
        public string ShortcutName { get; set; }
        public KeyCombination Keys { get; set; } // KeyCombination 타입으로 수정

        public UserControlKeyItem(string shortcutName, KeyCombination keys) // KeyCombination 타입으로 수정
        {
            this.ShortcutName = shortcutName;
            this.Keys = keys;

            InitializeComponent();
            InitializeEventHandlers();
            SetItemLayout();
        }

        private void InitializeEventHandlers()
        {
            pictureBoxButtonEdit.Click += OnPictureBoxButtonEditClick;
            pictureBoxButtonEdit.MouseMove += OnPictureBoxButtonMove;
            pictureBoxButtonDelete.MouseMove += OnPictureBoxButtonMove;

        }

        private void OnPictureBoxButtonEditClick(object sender, EventArgs e)
        {
            ShowEditDialog();
        }

        private void ShowEditDialog()
        {
            // 종료 확인 메시지 박스

            bool dialogResult = KeyDialog.ShowDialog(ParentForm, this.ShortcutName, this.Keys);
            if (dialogResult)
            {

            }
        }

        private void OnPictureBoxButtonMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void SetItemLayout()
        {
            UserControlStyler.ApplyRoundedCorners(this, 20, 20);
            // 필요한 레이아웃 초기화 코드 추가
            labelShortcutName.Text = ShortcutName;
            textBoxKeyCombination.Text = string.Join(" + ", Keys.Keys);
        }

        public void UpdateItem(string shortcutName, KeyCombination keys) // KeyCombination 타입으로 수정
        {
            this.ShortcutName = shortcutName;
            this.Keys = keys;
            SetItemLayout();
        }
    }
}