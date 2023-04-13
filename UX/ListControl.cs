

using System.Drawing.Drawing2D;

namespace WinWLAN.UX
{
    public class ListControl : ListBox
    {
        public ListControl()
        {
            ItemHeight = 80;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = Color.FromArgb(255,255,255);
            BorderStyle = BorderStyle.None;
            DrawMode = DrawMode.OwnerDrawFixed;
            ForeColor = Color.White;
            IntegralHeight = false;
        }

        // https://stackoverflow.com/questions/13169900/hide-vertical-scroll-bar-in-listbox-control
        #region Scrollbar
        private bool mShowScroll;
        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (!mShowScroll)
                    cp.Style = cp.Style & ~0x200000;
                return cp;
            }
        }
        public bool ShowScrollbar
        {
            get { return mShowScroll; }
            set
            {
                if (value != mShowScroll)
                {
                    mShowScroll = value;
                    if (IsHandleCreated)
                        RecreateHandle();
                }
            }
        }
        #endregion

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 15)
                CustomPaint();
        }

        private Image _Image;
        public Image ItemImage
        {
            get { return _Image; }
            set { _Image = value; }
        }

        protected override void OnDrawItem(System.Windows.Forms.DrawItemEventArgs e)
        {
            try
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255,255,255)), new Rectangle(e.Bounds.X, e.Bounds.Y - 1, e.Bounds.Width, e.Bounds.Height + 3));

                if (e.Index < 0)
                    return;

                Rectangle rect = new Rectangle(new Point(e.Bounds.Left, e.Bounds.Top + 2), new Size(Bounds.Width, 16));

                if (e.State.ToString().Contains("Selected,"))
                {
                    Rectangle x2 = e.Bounds;
                    LinearGradientBrush G1 = new LinearGradientBrush(new Point(x2.X, x2.Y), new Point(x2.X, x2.Y + x2.Height + 10), Color.FromArgb(141,172,110), Color.FromArgb(155,195,134)); // Main back fill

                    e.Graphics.FillRectangle(G1, x2.X + 1, x2.Y + 1, x2.Width, x2.Height + 1);
                    G1.Dispose();
                    e.Graphics.DrawString(" " + GetItemText(Items[e.Index]), Font, Brushes.Black, 5, e.Bounds.Y + 10);
                }
                else
                {
                    Rectangle x2 = e.Bounds;
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255)), x2.X + 1, x2.Y + 1, x2.Width, x2.Height + 10); // Not selected back fill
                    e.Graphics.DrawString(" " + GetItemText(Items[e.Index]), Font, Brushes.Black, 5, e.Bounds.Y + 10);
                }

                base.OnDrawItem(e);
            }
            catch
            {
            }
        }

        public void CustomPaint()
        {
        }
    }

}
