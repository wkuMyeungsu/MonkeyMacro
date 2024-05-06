using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyMacro.UserControls
{
    public partial class UC_KeyItem : UserControl
    {
        public UC_KeyItem()
        {
            InitializeComponent();
            InitializeLayout();
        }

        private void InitializeLayout()
        {
            // label_underLine
            label_underLine.Width = (this.Width - label_underLine.Width) / 2;

            // label_keyName
            label_keyName.Width = (this.Width - label_keyName.Width) / 2;
        }
    }
}
