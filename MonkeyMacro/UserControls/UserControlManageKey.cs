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
    public partial class UserControlManageKey : UserControl
    {
        private TableLayoutPanel tableLayoutPanel;
        private Panel scrollablePanel;

        public UserControlManageKey()
        {
            InitializeComponent();
            InitializeLayout();
            AddTestItems(); // Add test items during initialization
        }

        private void InitializeLayout()
        {
            // Initialize and configure the scrollable Panel
            scrollablePanel = new Panel();
            scrollablePanel.Dock = DockStyle.Fill;
            scrollablePanel.AutoScroll = true;
            scrollablePanel.HorizontalScroll.Enabled = false;
            scrollablePanel.HorizontalScroll.Visible = false;
            scrollablePanel.AutoScroll = true;

            // Initialize and configure the TableLayoutPanel
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.Padding = new Padding(10, 10, 10, 50); // Add padding around the entire table

            // Add the TableLayoutPanel to the scrollable Panel
            scrollablePanel.Controls.Add(tableLayoutPanel);

            // Add the scrollable Panel to the UserControl
            this.Controls.Add(scrollablePanel);
        }

        public void AddAppItem(string applicationName, int shortcutCount)
        {
            var appItem = new UserControlAppItem(applicationName, shortcutCount)
            {
                Margin = new Padding(10) // Add margin between items
            };

            int row = tableLayoutPanel.Controls.Count / 2;
            int col = tableLayoutPanel.Controls.Count % 2;

            if (tableLayoutPanel.RowCount <= row)
            {
                tableLayoutPanel.RowCount = row + 1;
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            tableLayoutPanel.Controls.Add(appItem, col, row);
        }

        private void AddTestItems()
        {
            // Add 5 test items
            AddAppItem("App 1", 1);
            AddAppItem("App 2", 2);
            AddAppItem("App 3", 3);
            AddAppItem("App 4", 4);
            AddAppItem("App 5", 5);
        }
    }
}
