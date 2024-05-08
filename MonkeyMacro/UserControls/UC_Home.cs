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
        private Panel panelContainer; // 키 아이템을 담을 패널
        private const int itemMargin = 10; // 아이템 간격

        public UC_Home()
        {
            InitializeComponent();
            InitializePanel();
            AddKeyItems();
        }

        private void InitializePanel()
        {
            panelContainer = new Panel();
            panelContainer.Location = new Point(0, 20); // 패널의 위치를 설정합니다.
            panelContainer.Size = new Size(this.Width, this.Height - 40); // 패널의 크기를 설정합니다.
            panelContainer.AutoScroll = true;
            this.Controls.Add(panelContainer);
        }

        private void AddKeyItems()
        {
            const int itemCount = 10; // 키 아이템 개수
            int yPos = 0;

            for (int i = 0; i < itemCount; i++)
            {
                UC_KeyItem ucKeyItem = new UC_KeyItem();
                ucKeyItem.Location = new Point((panelContainer.Width - ucKeyItem.Width) / 2, yPos);
                panelContainer.Controls.Add(ucKeyItem);

                yPos += ucKeyItem.Height + itemMargin; // 다음 아이템의 Y 위치를 갱신
            }
        }
    }
}
