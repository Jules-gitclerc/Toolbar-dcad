using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DesignCAD;
using Microsoft.VisualBasic;
using Application = DesignCAD.Application;

namespace DcadToolBar
{
    public static class WindowTools
    {
        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out LPRECT lpRect);
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        private struct LPRECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public static Rectangle GetWindowRect(string processName)
        {
            var allProcesses = Process.GetProcesses();
            IntPtr? hWnd = allProcesses.FirstOrDefault(process => process.ProcessName == processName)?
                .MainWindowHandle;
            if (hWnd == null)
                return new Rectangle(0, 0, 0, 0);
            GetWindowRect(hWnd.Value, out LPRECT r);

            Rectangle rect = new Rectangle(new Point(r.Left, r.Top), new Size(Math.Abs(r.Right - r.Left), Math.Abs(r.Bottom - r.Top)));
            if (rect.Width < 500)
                return new Rectangle(new Point(-10000, -10000), new Size(Math.Abs(r.Right - r.Left), Math.Abs(r.Bottom - r.Top)));
            return rect;
        }

        public static bool IsDesignCADActive(Application app)
        {
            IntPtr hWnd = GetForegroundWindow();

            try
            {
                int i = hWnd.ToInt32();
                return i == app.HWnd;
            }
            catch (OverflowException e)
            {
                Debug.WriteLine(e);
                long l = hWnd.ToInt64();
                return l == app.HWnd;
            }
            catch
            {
                //unused
            }

            return false;
        }
    }
}
