using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinPG.Forms
{
    public class NoneBorderForm : Form
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HTCAPTION = 0x2;

        private void SetWindowRegion(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90); // 左上角
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90); // 右上角
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90); // 右下角
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90); // 左下角
            path.CloseFigure();

            this.Region = new Region(path);
        }
        protected void MoveForm(object? s, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();                                  // 释放鼠标捕获
                _ = SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0); // 把拖动消息交给系统
            }
        }

        protected void ApplyFormEffects()
        {

            if (Environment.OSVersion.Version.Major >= 6) // Vista+
            {
                int val = 2;
                _ = DwmSetWindowAttribute(this.Handle, 2, ref val, 4);
                MARGINS margins = new()
                {
                    leftWidth = 1,
                    rightWidth = 1,
                    topHeight = 1,
                    bottomHeight = 1
                };
                _ = DwmExtendFrameIntoClientArea(this.Handle, ref margins);
            }
        }
    }
}
