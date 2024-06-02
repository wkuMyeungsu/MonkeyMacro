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

        public UserControlKeyItem()
        {
            InitializeComponent();
            InitializeLayout();
            AddLabels();
        }

        private void AddLabels()
        {
            const int labelCount = 5; // Label 개수
            const int buttonMargin = 5; // Label 사이의 간격

        }

        private void InitializeLayout()
        {
            UserControlStyler.ApplyRoundedCorners(this, 20, 20);
        }

        private void UserControlKeyItem_Load(object sender, EventArgs e)
        {

        }
    }
}