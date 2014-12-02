using System;
using System.Windows.Forms;
using Sulakore.Protocol.Controls;

namespace Tanji.Dialogs
{
    public partial class TanjiConstructEdit : Form
    {
        #region Private Fields
        private readonly HMConstructer _hmConstructer;
        #endregion

        #region Constructor(s)
        public TanjiConstructEdit(HMConstructer hmConstructer)
        {
            InitializeComponent();
            _hmConstructer = hmConstructer;
            TypeTxt.Text = _hmConstructer.SelectedItems[0].SubItems[0].Text;
            ValueTxt.Text = _hmConstructer.SelectedItems[0].SubItems[1].Text;
        }
        #endregion

        #region User Interface Event Listeners
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            switch (TypeTxt.Text)
            {
                case "String": _hmConstructer.ReplaceSelected(ValueTxt.Text); break;
                case "Integer": _hmConstructer.ReplaceSelected(int.Parse(ValueTxt.Text)); break;
                case "Boolean": _hmConstructer.ReplaceSelected((!string.IsNullOrEmpty(ValueTxt.Text) && (ValueTxt.Text[0] == 't' || ValueTxt.Text[0] == '1'))); break;
            }
            Close();
        }
        #endregion

        #region Method Overrides
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0112:
                {
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == 0xF010) return;
                }
                break;
            }
            base.WndProc(ref m);
        }
        #endregion
    }
}