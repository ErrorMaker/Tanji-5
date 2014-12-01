using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Tanji.Components
{
    public class TanjiForm : Form
    {
        #region Public Properties
        [DefaultValue(100)]
        public int SnapDistance { get; set; }
        #endregion

        #region Constructor(s)
        public TanjiForm()
        { }
        #endregion

        #region Overrided Methods
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            var screen = Screen.FromPoint(Location);
            if (DoSnap(Left, screen.WorkingArea.Left)) Left = screen.WorkingArea.Left;
            if (DoSnap(Top, screen.WorkingArea.Top)) Top = screen.WorkingArea.Top;
            if (DoSnap(screen.WorkingArea.Right, Right)) Left = screen.WorkingArea.Right - Width;
            if (DoSnap(screen.WorkingArea.Bottom, Bottom)) Top = screen.WorkingArea.Bottom - Height;
        }
        #endregion

        #region Private Methods
        private bool DoSnap(int position, int edge)
        {
            int delta = position - edge;
            return delta < 0 || delta > 0 && delta <= SnapDistance;
        }
        #endregion
    }
}