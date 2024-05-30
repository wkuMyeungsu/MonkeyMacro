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
            if(ParentForm is MainForm mainForm)
            {
                double mainFormOpacity = mainForm.Opacity;
                int trackBarValue = (int)(mainFormOpacity * 100);
                TrackOpacity.Value = trackBarValue;
                LabelOpacity.Text = trackBarValue + "%";
            }
        }

        private void OnOpacityTrackScroll(object sender, EventArgs e)
        {
            LabelOpacity.Text = TrackOpacity.Value.ToString() + "%";
            double opacityValue = (double)TrackOpacity.Value / 100;
            if (Application.OpenForms["MainForm"] is MainForm mainForm)
            {
                mainForm.Opacity = opacityValue; // 메인폼의 투명도 값 설정
            }
        }
    }
}
