using System;
using System.Windows.Forms;

namespace MonkeyMacro.UserControls
{
    public partial class UserControlSettings : UserControl
    {
        private bool useTrayMinimize { get; set; }
        private bool isTopMost { get; set; }
        private double opacityValue { get; set; }

        private UserSettings userSettings;

        public UserControlSettings()
        {
            InitializeComponent();
        }

        private void OnUserControlSettingsLoad(object sender, EventArgs e)
        {
            if (ParentForm is MainForm mainForm)
            {
                userSettings = mainForm.userDataStorage.UserSettings;

                this.useTrayMinimize = userSettings.UseTrayMinimize;
                this.opacityValue = userSettings.Opacity;
                this.isTopMost = userSettings.TopMost;

                int trackBarValue = (int)(opacityValue * 100);
                trackBarOpacity.Value = trackBarValue;
                labelOpacity.Text = trackBarValue + "%";

                if (useTrayMinimize)
                {
                    radioButtonUseTrayMinimize.Checked = true;
                    radioButtonNotUseTrayMinimize.Checked = false;
                }

                SetOpacity(mainForm); // SetOpacity 호출
            }
        }

        private void OnOpacityTrackScroll(object sender, EventArgs e)
        {
            labelOpacity.Text = trackBarOpacity.Value.ToString() + "%";

            if (ParentForm is MainForm mainForm)
            {
                this.opacityValue = trackBarOpacity.Value / 100.0;
                SetOpacity(mainForm); // SetOpacity 호출
            }
        }

        private void SetOpacity(MainForm mainForm)
        {
            mainForm.Opacity = opacityValue; // 메인폼에 투명도 값 적용
            userSettings.Opacity = opacityValue; // 유저데이터에 투명도 값 업데이트
        }

        private void OnTrayCheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUseTrayMinimize.Checked)
            {
                if (ParentForm is MainForm mainForm)
                {
                    mainForm.useTrayMinimize = true;
                    userSettings.UseTrayMinimize = true;
                }
            }
            else
            {
                if (ParentForm is MainForm mainForm)
                {
                    mainForm.useTrayMinimize = false;
                    userSettings.UseTrayMinimize = false;
                }
            }
        }
    }
}
