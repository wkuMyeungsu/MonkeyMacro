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
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
            AddKeyItme();
        }

        private void AddKeyItme()
        {
            // UserControl을 코드 단에서 생성합니다.
            UC_KeyItem ucKeyItem = new UC_KeyItem();
            this.Controls.Add(ucKeyItem);
        }
    }
}
