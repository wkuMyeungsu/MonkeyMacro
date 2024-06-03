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
            SetItemLayout();
        }

        private void SetItemLayout()
        {
            UserControlStyler.ApplyRoundedCorners(this, 20, 20);
            // 필요한 레이아웃 초기화 코드 추가
            labelKeyName.Text = ShortcutName;
            textBox1.Text = string.Join(" + ", Keys.Keys);
        }

        public void UpdateItem(string shortcutName, KeyCombination keys) // KeyCombination 타입으로 수정
        {
            this.ShortcutName = shortcutName;
            this.Keys = keys;
            SetItemLayout();
        }
    }
}