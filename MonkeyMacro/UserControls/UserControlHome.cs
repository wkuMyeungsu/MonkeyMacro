using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MonkeyMacro.UserControls
{
    public partial class UserControlHome : UserControl
    {
        private Panel panelContainer; // 키 아이템을 담을 패널
        private const int itemMargin = 10; // 아이템 간격

        public UserControlHome()
        {
            InitializeComponent();
            InitializePanel();
        }

        private void InitializePanel()
        {
            panelContainer = new Panel()
            {
                Location = new Point(0, 20),
                Size = new Size(this.Width, this.Height - 40), // 패널의 크기를 설정합니다.
                AutoScroll = true
            };
            Controls.Add(panelContainer);
        }

        public void UpdateControl(string tracingAppName, Dictionary<string, ApplicationShortcut> shortcutData)
        {
            panelContainer.Controls.Clear(); // 이전에 추가된 키 아이템들을 제거합니다.

            if (shortcutData.ContainsKey(tracingAppName))
            {
                var shortcuts = shortcutData[tracingAppName].ShortcutKeys;
                int yPos = 0;

                foreach (var shortcut in shortcuts)
                {
                    // 각 단축키 정보에 대한 UserControlKeyItem을 생성합니다.
                    UserControlKeyItem keyItem = new UserControlKeyItem(tracingAppName, shortcut.Key, shortcut.Value);
                    keyItem.Location = new Point((panelContainer.Width - keyItem.Width) / 2, yPos);
                    panelContainer.Controls.Add(keyItem);

                    yPos += keyItem.Height + itemMargin; // 다음 아이템의 Y 위치를 갱신
                }
            }
        }
    }
}
