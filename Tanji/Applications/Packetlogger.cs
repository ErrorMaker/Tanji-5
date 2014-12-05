using System;
using System.Linq;
using System.Drawing;
using System.Threading;
using Sulakore.Protocol;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tanji.Applications
{
    public partial class Packetlogger : Form
    {
        #region Private Fields
        private Queue<HMessage> _displayQueue;
        private bool _loaded, _wasClosed, _queueRunning;

        private readonly object _queuePushLock;
        private readonly Color _defaultHightlight;

        private const string TitlePrefix = "Tanji ~ Packetlogger";
        private const string InfoChunkFormat = "( {0} - {1} )";
        private const string IncomingFormat = "<- Incoming{0} <- {1}";
        private const string OutgoingFormat = "-> Outgoing{0} -> {1}";
        private const string CorruptedChunkFormat = "( Corrupted - {0} )";
        #endregion

        #region Public Properties
        public Color IncomingHighlight { get; set; }
        public Color OutgoingHighlight { get; set; }

        public bool ViewOutgoing { get; private set; }
        public bool ViewIncoming { get; private set; }

        public bool DisplayFilters { get; private set; }
        public bool DisplayVisualSplit { get; private set; }
        #endregion

        #region Constructor(s)
        public Packetlogger()
        {
            InitializeComponent();

            _queuePushLock = new object();
            _displayQueue = new Queue<HMessage>();
            _defaultHightlight = Color.FromArgb(225, 225, 225);

            IncomingHighlight = Color.Firebrick;
            OutgoingHighlight = SystemColors.HotTrack;
            ViewOutgoing = ViewIncoming = DisplayVisualSplit = true;

            LoggerTxt.ForeColor = _defaultHightlight;
        }
        #endregion

        #region User Interface Event Listeners
        private void ItemClicked(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            bool isChecked = (item.Checked = !item.Checked);

            switch (item.Name)
            {
                case "ToggleIncomingBtn":
                {
                    CapturingINLbl.Text = "Capturing Incoming: " + isChecked;
                    ViewIncoming = isChecked;

                    if (!ViewIncoming)
                        _displayQueue = new Queue<HMessage>(_displayQueue.Where(x => x.Destination != HDestination.Client));

                    break;
                }
                case "ToggleOutgoingBtn":
                {
                    CapturingOUTLbl.Text = "Capturing Outgoing: " + isChecked;
                    ViewOutgoing = isChecked;

                    if (!ViewOutgoing)
                        _displayQueue = new Queue<HMessage>(_displayQueue.Where(x => x.Destination != HDestination.Server));

                    break;
                }
                case "DisplayFiltersBtn": DisplayFilters = isChecked; break;
                case "DisplayVisualSplitBtn": DisplayVisualSplit = isChecked; break;
            }
        }
        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LoggerTxt.SelectedText))
                Clipboard.SetText(LoggerTxt.SelectedText);
        }
        private void TopMostBtn_Click(object sender, EventArgs e)
        {
            TopMost = TopMostBtn.Checked;
        }
        private void ClearLogBtn_Click(object sender, EventArgs e)
        {
            LoggerTxt.Clear();
        }

        private void Packetlogger_Activated(object sender, EventArgs e)
        {
            _loaded = true;
            if (_wasClosed)
            {
                _wasClosed = false;
                Text = TitlePrefix;

                ToggleItem(ToggleIncomingBtn, true);
                ToggleItem(ToggleOutgoingBtn, true);
                ToggleItem(DisplayFiltersBtn, false);
                ToggleItem(DisplayVisualSplitBtn, true);
            }
        }
        private void Packetlogger_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loaded = false;
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;

            Halt();
            Text = TitlePrefix + " [Paused]";
        }
        #endregion

        #region Public Methods
        public void Halt()
        {
            _wasClosed = true;
            ToggleItem(ToggleIncomingBtn, false);
            ToggleItem(ToggleOutgoingBtn, false);
            ToggleItem(DisplayFiltersBtn, false);
            ToggleItem(DisplayVisualSplitBtn, false);
            _displayQueue.Clear();
            LoggerTxt.Clear();
        }
        public void PushToQueue(HMessage packet)
        {
            bool toServer = (packet.Destination == HDestination.Server);
            if (!ViewOutgoing && toServer || !ViewIncoming && !toServer) return;

            _displayQueue.Enqueue(packet);
            if (!_queueRunning) Task.Factory.StartNew(RunQueue);
        }
        public void DisplayMessage(string message)
        {
            Invoke(new MethodInvoker(() => Display(message, _defaultHightlight)));
        }
        #endregion

        #region Private Methods
        private void RunQueue()
        {
            if (_queueRunning) return;
            _queueRunning = true;

            try
            {
                while (_displayQueue.Count > 0)
                {
                    if (_displayQueue.Count == 0) break;
                    HMessage packet = _displayQueue.Dequeue();
                    if (packet == null) continue;

                    bool toServer = (packet.Destination == HDestination.Server);
                    if (!ViewOutgoing && toServer || !ViewIncoming && !toServer) continue;

                    object[] arguments = packet.IsCorrupted ? new object[] { packet.Length } : new object[] { packet.Header, packet.Length };
                    string infoChunk = string.Format(packet.IsCorrupted ? CorruptedChunkFormat : InfoChunkFormat, arguments);
                    string message = string.Format(toServer ? OutgoingFormat : IncomingFormat, infoChunk, packet);

                    while (!_loaded) Thread.Sleep(100);
                    Invoke(new MethodInvoker(() => Display(message, toServer ? OutgoingHighlight : IncomingHighlight)));
                }
            }
            catch (Exception ex) { DisplayMessage(ex.ToString()); }
            finally { _queueRunning = false; }
        }
        private void Display(string message, Color highlight)
        {
            LoggerTxt.SelectionStart = LoggerTxt.TextLength;
            LoggerTxt.SelectionLength = 0;
            LoggerTxt.SelectionColor = highlight;
            LoggerTxt.AppendText(message + (DisplayVisualSplit ? "\n--------------------\n" : "\n"));
            LoggerTxt.SelectionStart = LoggerTxt.TextLength;
            LoggerTxt.ScrollToCaret();
            Application.DoEvents();
        }
        private void ToggleItem(ToolStripMenuItem item, bool check)
        {
            item.Checked = !check;
            ItemClicked(item, EventArgs.Empty);
        }
        #endregion
    }
}