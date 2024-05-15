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
    public partial class UC_Settings : UserControl
    {

        public UC_Settings()
        {
            InitializeComponent();
        }
        private void UC_Settings_Load(object sender, EventArgs e)
        {
            if(ParentForm is MainForm mainForm)
            {
                double mainFormOpacity = mainForm.Opacity;
                int trackBarValue = (int)(mainFormOpacity * 100);
                Track_Opacity.Value = trackBarValue;
                Label_Opacity.Text = trackBarValue + "%";
            }
        }

        private void Opacity_Track_Scroll(object sender, EventArgs e)
        {
            Label_Opacity.Text = Track_Opacity.Value.ToString() + "%";
            double opacityValue = (double)Track_Opacity.Value / 100;
            if (Application.OpenForms["MainForm"] is MainForm mainForm)
            {
                mainForm.Opacity = opacityValue; // 메인폼의 투명도 값 설정
            }
        }
    }
}
