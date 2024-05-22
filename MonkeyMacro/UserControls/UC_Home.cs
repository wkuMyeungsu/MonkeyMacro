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

namespace MonkeyMacro.UserControls
{
    public partial class UC_Home : UserControl
    {
        private Panel panel_Container; // 키 아이템을 담을 패널
        private VScrollBar containerScrollbar;

        private const int itemMargin = 10; // 아이템 간격

        public UC_Home()
        {
            InitializeComponent();
            InitializePanel();
            AddKeyItems();
        }

        private void InitializePanel()
        {
            panel_Container = new Panel();
            panel_Container.Location = new Point(0, 20); // 패널의 위치를 설정합니다.
            panel_Container.Size = new Size(this.Width, this.Height - 40); // 패널의 크기를 설정합니다.
            panel_Container.AutoScroll = true;
            Controls.Add(panel_Container);
        }

        private void AddKeyItems()
        {
            const int itemCount = 10; // 키 아이템 개수
            int yPos = 0;

            for (int i = 0; i < itemCount; i++)
            {
                UC_KeyItem ucKeyItem = new UC_KeyItem();
                ucKeyItem.Location = new Point((panel_Container.Width - ucKeyItem.Width) / 2, yPos);
                panel_Container.Controls.Add(ucKeyItem);

                yPos += ucKeyItem.Height + itemMargin; // 다음 아이템의 Y 위치를 갱신
            }
        }
    }
}
