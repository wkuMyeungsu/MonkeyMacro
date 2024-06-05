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
    public partial class UserControlAppItem : UserControl
    {
        public string ApplicationName { get; private set; }
        public int ShortcutCount { get; private set; }

        public UserControlAppItem(string applicationName, int shortcutCount)
        {
            ApplicationName = applicationName;
            ShortcutCount = shortcutCount;

            InitializeComponent();
            InitializeLayout();
        }

        private void InitializeLayout()
        {
            // Set the text of the labels
            labelAppName.Text = ApplicationName;
            labelShortcutCount.Text = $"저장 단축키 : {ShortcutCount}개";

            // Center the labelAppName in the panelAppNameContainer
            panelAppNameContainer.Layout += (s, e) =>
            {
                labelAppName.Left = (panelAppNameContainer.ClientSize.Width - labelAppName.Width) / 2;
            };

            // Center the labelShortcutCount in the UserControlAppItem
            this.Layout += (s, e) =>
            {
                labelShortcutCount.Left = (this.ClientSize.Width - labelShortcutCount.Width) / 2;
            };

            // Optional: Adjust the padding/margin if needed
            labelAppName.Margin = new Padding(0);
            labelShortcutCount.Margin = new Padding(0);
            panelAppNameContainer.Padding = new Padding(0);

            // Redraw the control to apply changes
            panelAppNameContainer.PerformLayout();
            this.PerformLayout();
        }
    }
}
