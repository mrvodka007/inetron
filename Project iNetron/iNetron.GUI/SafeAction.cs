using System;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Media;

namespace iNetron.GUI
{
    public class SafeAction
    {
        public class ScreenCapture
        {
            public Image CaptureScreen()
            {
                return CaptureWindow(User32.GetDesktopWindow());
            }
            public Image CaptureWindow(IntPtr handle)
            {
                IntPtr hdcSrc = User32.GetWindowDC(handle);
                User32.RECT windowRect = new User32.RECT();
                User32.GetWindowRect(handle, ref windowRect);
                int width = windowRect.right - windowRect.left;
                int height = windowRect.bottom - windowRect.top;
                IntPtr hdcDest = GDI32.CreateCompatibleDC(hdcSrc);
                IntPtr hBitmap = GDI32.CreateCompatibleBitmap(hdcSrc, width, height);
                IntPtr hOld = GDI32.SelectObject(hdcDest, hBitmap);
                GDI32.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, GDI32.SRCCOPY);
                GDI32.SelectObject(hdcDest, hOld);
                GDI32.DeleteDC(hdcDest);
                User32.ReleaseDC(handle, hdcSrc);
                Image img = Image.FromHbitmap(hBitmap);
                GDI32.DeleteObject(hBitmap);
                return img;
            }
            public void CaptureWindowToFile(IntPtr handle, string filename, ImageFormat format)
            {
                Image img = CaptureWindow(handle);
                img.Save(filename, format);
            }
            public void CaptureScreenToFile(string filename, ImageFormat format)
            {
                Image img = CaptureScreen();
                img.Save(filename, format);
            }
            private class GDI32
            {
                public const int SRCCOPY = 0x00CC0020;
                [DllImport("gdi32.dll")]
                public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest,
                    int nWidth, int nHeight, IntPtr hObjectSource,
                    int nXSrc, int nYSrc, int dwRop);
                [DllImport("gdi32.dll")]
                public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth,
                    int nHeight);
                [DllImport("gdi32.dll")]
                public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
                [DllImport("gdi32.dll")]
                public static extern bool DeleteDC(IntPtr hDC);
                [DllImport("gdi32.dll")]
                public static extern bool DeleteObject(IntPtr hObject);
                [DllImport("gdi32.dll")]
                public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
            }
            private class User32
            {
                [StructLayout(LayoutKind.Sequential)]
                public struct RECT
                {
                    public int left;
                    public int top;
                    public int right;
                    public int bottom;
                }
                [DllImport("user32.dll")]
                public static extern IntPtr GetDesktopWindow();
                [DllImport("user32.dll")]
                public static extern IntPtr GetWindowDC(IntPtr hWnd);
                [DllImport("user32.dll")]
                public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
                [DllImport("user32.dll")]
                public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);
            }
        }   
        #region PINVOKE
        [DllImport("user32.dll")]
        public static extern IntPtr CreateDesktop(string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, int dwFlags, uint dwDesiredAccess, IntPtr lpsa);

        [DllImport("user32.dll")]
        private static extern bool SwitchDesktop(IntPtr hDesktop);

        [DllImport("user32.dll")]
        public static extern bool CloseDesktop(IntPtr handle);

        [DllImport("user32.dll")]
        public static extern IntPtr GetThreadDesktop(int dwThreadId);

        [DllImport("user32.dll")]
        public static extern bool SetThreadDesktop(IntPtr hDesktop);

        [DllImport("kernel32.dll")]
        public static extern int GetCurrentThreadId();

        public enum DESKTOP_ACCESS : uint
        {
            DESKTOP_NONE = 0,
            DESKTOP_READOBJECTS = 0x0001,
            DESKTOP_CREATEWINDOW = 0x0002,
            DESKTOP_CREATEMENU = 0x0004,
            DESKTOP_HOOKCONTROL = 0x0008,
            DESKTOP_JOURNALRECORD = 0x0010,
            DESKTOP_JOURNALPLAYBACK = 0x0020,
            DESKTOP_ENUMERATE = 0x0040,
            DESKTOP_WRITEOBJECTS = 0x0080,
            DESKTOP_SWITCHDESKTOP = 0x0100,

            GENERIC_ALL = (DESKTOP_READOBJECTS | DESKTOP_CREATEWINDOW | DESKTOP_CREATEMENU |
                            DESKTOP_HOOKCONTROL | DESKTOP_JOURNALRECORD | DESKTOP_JOURNALPLAYBACK |
                            DESKTOP_ENUMERATE | DESKTOP_WRITEOBJECTS | DESKTOP_SWITCHDESKTOP),
        }
        #endregion

        class bForm : Form { public bForm() => this.DoubleBuffered = true; }
        static SoundPlayer sp = new SoundPlayer(Properties.Resources.blup);
        // Disgusting code. I know.
        public static bool Allow()
        {
            Bitmap bmp = new Bitmap(new ScreenCapture().CaptureScreen());
            Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (Brush cloud_brush = new SolidBrush(Color.FromArgb(192, Color.Black)))
                {
                    g.FillRectangle(cloud_brush, r);
                }
            }
            Form frm = new bForm();
            {
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.WindowState = FormWindowState.Maximized;
                frm.Size = Screen.PrimaryScreen.Bounds.Size;
                frm.StartPosition = FormStartPosition.Manual;
                frm.Location = new Point(0, 0);
                frm.BackgroundImage = bmp;
            }

            IntPtr hOldDesktop = GetThreadDesktop(GetCurrentThreadId());
            IntPtr hNewDesktop = CreateDesktop("iNetron_Secure", IntPtr.Zero, IntPtr.Zero, 0, (uint)DESKTOP_ACCESS.GENERIC_ALL, IntPtr.Zero);
            bool dResponse = false;

            Task.Factory.StartNew(() =>
            {
                SetThreadDesktop(hNewDesktop);
                frm.Show();

            CheckAgain:
                if (frm.Visible && frm.Handle != null)
                    SwitchDesktop(hNewDesktop);
                else
                    goto CheckAgain;

                sp.Play();

                var result = new dlgPopup().ShowDialog();
                SwitchDesktop(hOldDesktop);

                if (result == DialogResult.OK)
                    dResponse = true;
                else
                    dResponse = false;

                frm.Close();
            }).Wait();

            CloseDesktop(hNewDesktop);
            return dResponse;
        }
    }
}