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

            // Label 너비 계산
            int labelWidth = (panelKeyContainer.Width - (labelCount - 1) * buttonMargin) / labelCount;

            for (int i = 0; i < labelCount; i++)
            {
                Button button = new Button();
                button.Text = "Button " + (i + 1);
                button.ForeColor = Color.White;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Height = panelKeyContainer.Height;
                button.Width = button.Width;
                button.Margin = new Padding(buttonMargin, 0, 0, 0); // 버튼 간격 설정

                // 버튼을 패널 내부에 추가합니다.
                button.Location = new Point(i * (button.Width + buttonMargin), 0);
                panelKeyContainer.Controls.Add(button);
            }
        }

        private void InitializeLayout()
        {
            // label_underLine
            labelUnderLine.Left = (this.Width - labelUnderLine.Width) / 2;

            // label_keyName
            labelKeyName.Left = (this.Width - labelKeyName.Width) / 2;

            // panel_keyContainer
            panelKeyContainer.Left = (this.Width - panelKeyContainer.Width) / 2;

        }
    }
}
