using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EarthGlobal.Common
{
    public static class DragForm
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        /// <summary>
        /// ListView更改间距需要的参数
        /// </summary>
        public const int LVM_SETICONSPACING = 0x1035;

        /// <summary>
        /// 拖动form
        /// </summary>
        /// <param name="frm"></param>
        public static void moveForm(Form frm)
        {
            ReleaseCapture();
            SendMessage(frm.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        public static void moveForm(UserControl frm)
        {
            ReleaseCapture();
            SendMessage(frm.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
