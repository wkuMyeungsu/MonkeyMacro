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
            AddLabels();
        }

        private void AddLabels()
        {
            const int labelCount = 5; // Label 개수
            const int buttonMargin = 5; // Label 사이의 간격

            // Label 너비 계산
            int labelWidth = (panel_keyContainer.Width - (labelCount - 1) * buttonMargin) / labelCount;

            for (int i = 0; i < labelCount; i++)
            {
                Button button = new Button();
                button.Text = "Button " + (i + 1);
                button.ForeColor = Color.White;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Height = panel_keyContainer.Height;
                button.Width = button.Width;
                button.Margin = new Padding(buttonMargin, 0, 0, 0); // 버튼 간격 설정

                // 버튼을 패널 내부에 추가합니다.
                button.Location = new Point(i * (button.Width + buttonMargin), 0);
                panel_keyContainer.Controls.Add(button);
            }
        }

        private void InitializeLayout()
        {
            // label_underLine
            label_underLine.Left = (this.Width - label_underLine.Width) / 2;

            // label_keyName
            label_keyName.Left = (this.Width - label_keyName.Width) / 2;

            // panel_keyContainer
            panel_keyContainer.Left = (this.Width - panel_keyContainer.Width) / 2;

        }
    }
}
