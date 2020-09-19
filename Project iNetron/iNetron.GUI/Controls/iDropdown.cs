using System.Drawing;
using System.Windows.Forms;
using iNetron.GUI.Properties;

namespace iNetron.GUI.Controls
{
    public partial class iDropdown : ComboBox
    {
        public iDropdown()
        {
            this.BackColor = Color.FromArgb(8, 12, 16);
            this.FlatStyle = FlatStyle.Flat;
        }

        public Color BorderColor { get; set; } = Color.FromArgb(0, 96, 192);
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;

        private const int WM_PAINT = 0xF;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {

                    using (var p = new Pen(this.BorderColor, 1))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                        g.DrawImageUnscaled(Resources.dropdown, new Point(Width - buttonWidth - 1));
                    }
                }
            }
        }
    }
}
