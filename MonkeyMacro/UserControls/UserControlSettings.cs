using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MonkeyMacro.UserControls
{
    public partial class UserControlSettings : UserControl
    {

        public UserControlSettings()
        {
            InitializeComponent();
        }

        private void OnUserControlSettingsLoad(object sender, EventArgs e)
        {
            if (ParentForm is MainForm mainForm)
            {
                bool setTrayicon = mainForm.user_setTray;
                double mainFormOpacity = mainForm.user_Opacityvalue;

                int trackBarValue = (int)(mainFormOpacity * 100);
                TrackOpacity.Value = trackBarValue;
                LabelOpacity.Text = trackBarValue + "%";

                if (setTrayicon)
                {
                    SetTray.Checked = true;
                    QuitProgram.Checked = false;
                }
            }
        }

        private void OnOpacityTrackScroll(object sender, EventArgs e)
        {
            LabelOpacity.Text = TrackOpacity.Value.ToString() + "%";
            double opacityValue = (double)TrackOpacity.Value / 100;
            if (ParentForm is MainForm mainForm)
            {
                mainForm.user_Opacityvalue = opacityValue; //사용자 투명도값 설정
                mainForm.Opacity = opacityValue; // 메인폼의 투명도 값 설정
            }
        }

        private void SetTray_CheckedChanged(object sender, EventArgs e)
        {
            if (SetTray.Checked)
            {
                if (ParentForm is MainForm mainForm)
                {
                    mainForm.user_setTray = true;
                }
            }
            else
            {
                if (ParentForm is MainForm mainForm)
                {
                    mainForm.user_setTray = false;
                }
            }
        }
    }
}
