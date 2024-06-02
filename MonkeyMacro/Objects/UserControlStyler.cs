using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MonkeyMacro.Objects
{
    public class UserControlStyler
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public static void ApplyRoundedCorners(Control control, int ellipseWidth, int ellipseHeight)
        {
            if (control != null)
            {
                control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, ellipseWidth, ellipseHeight));
                control.Resize += (sender, e) =>
                {
                    control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, ellipseWidth, ellipseHeight));
                };
            }
        }
    }
}
