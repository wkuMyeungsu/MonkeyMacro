using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MonkeyMacro.Objects
{
    public class FormStyling
    {
        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        // 그림자 효과 적용 메서드
        public static void ApplyShadow(Form form)
        {
            MARGINS margins = new MARGINS()
            {
                cxLeftWidth = 1,
                cxRightWidth = 1,
                cyTopHeight = 1,
                cyBottomHeight = 1
            };

            IntPtr hwnd = form.Handle;
            int attrValue = 2; // DWMNCRP_ENABLED
            DwmSetWindowAttribute(hwnd, 2, ref attrValue, 4); // DWMWA_NCRENDERING_POLICY
            DwmExtendFrameIntoClientArea(hwnd, ref margins);
        }

        // 둥근 모서리 효과 적용 메서드
        public static void ApplyRoundedCorners(Form form, int ellipseWidth, int ellipseHeight)
        {
            form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, ellipseWidth, ellipseHeight));
            form.Resize += (sender, e) =>
            {
                form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, ellipseWidth, ellipseHeight));
            };
        }
    }

    public struct MARGINS
    {
        public int cxLeftWidth;
        public int cxRightWidth;
        public int cyTopHeight;
        public int cyBottomHeight;
    }
}
