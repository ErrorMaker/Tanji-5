using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Tanji.Components
{
    [System.ComponentModel.DesignerCategory("Code")]
    public sealed class TanjiTabControl : TabControl
    {
        #region Public Properties
        private bool _displayBoundary;
        #region Attributes
        [DefaultValue(false)]
        #endregion
        public bool DisplayBoundary
        {
            get { return _displayBoundary; }
            set { _displayBoundary = value; Invalidate(); }
        }

        public new Size ItemSize
        {
            get
            {
                if (Alignment == TabAlignment.Left || Alignment == TabAlignment.Right)
                    return new Size(base.ItemSize.Height, base.ItemSize.Width);
                return base.ItemSize;
            }
            set
            {
                if (Alignment == TabAlignment.Left || Alignment == TabAlignment.Right)
                    base.ItemSize = new Size(value.Height, value.Width);
                else
                    base.ItemSize = value;

                Invalidate();
            }
        }
        #endregion

        #region Constructor(s)
        public TanjiTabControl()
        {
            SetStyle((ControlStyles)2050, true);
            DoubleBuffered = true;

            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(95, 24);

            DrawMode = TabDrawMode.OwnerDrawFixed;
        }
        #endregion

        #region Protected Methods ( Overrides )
        protected override void OnControlAdded(ControlEventArgs e)
        {
            var tabPage = e.Control as TabPage;
            if (tabPage != null)
                tabPage.BackColor = Color.White;
            base.OnControlAdded(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            foreach (TabPage tabPage in TabPages)
            {
                int curIndex = TabPages.IndexOf(tabPage);
                Rectangle tabRect = GetTabRect(curIndex);
                var titleR = new Rectangle(tabRect.X, tabRect.Y, tabRect.Width, tabRect.Height);
                var ntr = new Rectangle(tabRect.X + (curIndex == 0 ? 2 : 0), (tabRect.Y + tabRect.Height) - 3, tabRect.Width - (curIndex == 0 ? 4 : 2), 2);

                if (Alignment == TabAlignment.Top)
                {
                    e.Graphics.FillRectangle(SelectedIndex == curIndex ? Color.FromArgb(243, 63, 63) : Color.Silver, ntr);
                    e.Graphics.DrawString(tabPage.Text, Font, Color.Black, titleR, StringAlignment.Center);
                }
                else if (Alignment == TabAlignment.Right)
                {
                    titleR = new Rectangle(titleR.X + 4, titleR.Y, titleR.Width, titleR.Height);
                    ntr = new Rectangle(tabRect.X, tabRect.Y + (curIndex == 0 ? 2 : 0), 2, tabRect.Height - (curIndex == 0 ? 4 : 2));
                    e.Graphics.FillRectangle(SelectedIndex == curIndex ? Color.FromArgb(243, 63, 63) : Color.Silver, ntr);
                    e.Graphics.DrawString(tabPage.Text, Font, Color.Black, titleR, StringAlignment.Near, StringAlignment.Center);
                }
            }

            if (_displayBoundary)
                e.Graphics.DrawLine(Color.FromArgb(243, 63, 63), 0, Height - 1, Width - 1, Height - 1);
            base.OnPaint(e);
        }
        #endregion
    }
}