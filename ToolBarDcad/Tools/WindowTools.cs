using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using Application = DesignCAD.Application;
using System.Drawing;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using System.IO;

namespace ToolBarDcad.Tools
{
    class WindowTools
    {
        [Flags]
        public enum ExtendedWindowStyles
        {
            // ...
            WS_EX_TOOLWINDOW = 0x00000080,
            // ...
        }

        public enum GetWindowLongFields
        {
            // ...
            GWL_EXSTYLE = (-20),
            // ...
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

        public static IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {
            int error = 0;
            IntPtr result = IntPtr.Zero;
            // Win32 SetWindowLong doesn't clear error on success
            SetLastError(0);

            if (IntPtr.Size == 4)
            {
                // use SetWindowLong
                Int32 tempResult = IntSetWindowLong(hWnd, nIndex, IntPtrToInt32(dwNewLong));
                error = Marshal.GetLastWin32Error();
                result = new IntPtr(tempResult);
            }
            else
            {
                // use SetWindowLongPtr
                result = IntSetWindowLongPtr(hWnd, nIndex, dwNewLong);
                error = Marshal.GetLastWin32Error();
            }

            if ((result == IntPtr.Zero) && (error != 0))
            {
                throw new System.ComponentModel.Win32Exception(error);
            }

            return result;
        }

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr", SetLastError = true)]
        private static extern IntPtr IntSetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong", SetLastError = true)]
        private static extern Int32 IntSetWindowLong(IntPtr hWnd, int nIndex, Int32 dwNewLong);

        private static int IntPtrToInt32(IntPtr intPtr)
        {
            return unchecked((int)intPtr.ToInt64());
        }

        [DllImport("kernel32.dll", EntryPoint = "SetLastError")]
        public static extern void SetLastError(int dwErrorCode);

        public static void HideFromProgramSwitcher(Window window)
        {
            WindowInteropHelper wndHelper = new WindowInteropHelper(window);

            int exStyle = (int)GetWindowLong(wndHelper.Handle, (int)WindowTools.GetWindowLongFields.GWL_EXSTYLE);

            exStyle |= (int)WindowTools.ExtendedWindowStyles.WS_EX_TOOLWINDOW;
            SetWindowLong(wndHelper.Handle, (int)WindowTools.GetWindowLongFields.GWL_EXSTYLE, (IntPtr)exStyle);
        }

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out LPRECT lpRect);
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);

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
                return i == app?.HWnd;
            }
            catch (OverflowException e)
            {
                Debug.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
                string log = $"{e.Message} {Environment.NewLine} {e.StackTrace}";

                long l = hWnd.ToInt64();
                return l == app?.HWnd;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
                string log = $"{ex.Message} {Environment.NewLine} {ex.StackTrace}";
                return false;
            }
        }

        public static bool IsActive(Window window)
        {
            IntPtr hWnd = GetForegroundWindow();
            var wih = new WindowInteropHelper(window);
            IntPtr appHwnd = wih.Handle;

            try
            {
                return hWnd == appHwnd;
            }
            catch
            {
                //unused
            }

            return false;
        }

        public static void PrintFullScreenBounds()
        {
            int width = GetSystemMetrics(0);
            int height = GetSystemMetrics(1);
            Debug.WriteLine(width + " " + height);
        }
    }
}
