using System;
using System.Net;
using Tanji.Dialogs;
using Tanji.Services;
using Sulakore.Protocol;
using Tanji.Applications;
using System.Windows.Forms;
using Sulakore.Communication;
using System.Threading.Tasks;
using Sulakore.Protocol.Encryption;
using Sulakore.Communication.Bridge;
using Sulakore.Protocol.Controls;

namespace Tanji
{
    public partial class Main : Form
    {
        #region Private Fields
        private bool _debugging;
        private TanjiExtensions _tanjiExtensions;
        private byte[] _fakeClientKey, _fakeServerKey;

        private readonly TanjiConnect _tanjiConnect;
        private readonly Packetlogger _packetloggerF;
        private readonly Action _initiate, _reinitiate;
        private readonly HKeyExchange _fakeClient, _fakeServer;

        private const string ProtocolFormat = "Protocol: {0}";
        private const string ScheduleFormat = "Schedules Active: {0}/{1}";
        private const string CorrPack = "The given packet seems to be corrupted.";
        private const string BadHeader = "The header you've specified does not qualify as an UInt16 type.";
        private const string NotInt32 = "The given value does not qualify as an Int32 type.";
        private const string NotUInt16 = "The given value does not qualify as an UInt16 type.";
        private const string InjClientCanc = "The specified data is corrupted, injection to client cancelled!";
        private const string InjServerCanc = "The specified data is corrupted, injection to server cancelled!";
        #endregion

        #region Public Properties/Fields
        public const string TanjiAlert = "Tanji ~ Alert!";
        public const string TanjiError = "Tanji ~ Error!";
        public const string TanjiWarning = "Tanji ~ Warning!";

        public static string BannerUrl { get; set; }
        public static string UserAgent { get; set; }
        public static HConnection Game { get; set; }
        public static CookieContainer Cookies { get; set; }

        private string _realModulus;
        public string RealModulus
        {
            get
            {
                if (!string.IsNullOrEmpty(_realModulus)) return _realModulus;
                LoadRsaKeys();
                return _realModulus;
            }
        }

        private int? _realExponent;
        public int RealExponent
        {
            get
            {
                if (_realExponent != null) return (int)_realExponent;
                LoadRsaKeys();
                return (int)_realExponent;
            }
        }

        private string _fakeModulus;
        public string FakeModulus
        {
            get
            {
                if (!string.IsNullOrEmpty(_fakeModulus)) return _fakeModulus;
                LoadRsaKeys();
                return _fakeModulus;
            }
        }

        private int? _fakeExponent;
        public int FakeExponent
        {
            get
            {
                if (_fakeExponent != null) return (int)_fakeExponent;
                LoadRsaKeys();
                return (int)_fakeExponent;
            }
        }

        private string _fakePrivateExponent;
        public string FakePrivateExponent
        {
            get
            {
                if (!string.IsNullOrEmpty(_fakePrivateExponent)) return _fakePrivateExponent;
                LoadRsaKeys();
                return _fakePrivateExponent;
            }
        }
        #endregion

        #region Constructor(s)
        public Main(bool debugging)
        {
            InitializeComponent();

            _debugging = debugging;
            _fakeClient = new HKeyExchange(RealExponent, RealModulus);
            _fakeServer = new HKeyExchange(FakeExponent, FakeModulus, FakePrivateExponent);

            if (_debugging)
                _tanjiExtensions = new TanjiExtensions(Game, ExtensionViewer);

            _packetloggerF = new Packetlogger();
            _tanjiConnect = new TanjiConnect(this);

            _initiate = Initiate;
            _reinitiate = Reinitiate;

            ISDirectionTxt.SelectedIndex = 1;
        }
        #endregion

        #region User Interface Event Listeners
        private void Main_Load(object sender, EventArgs e)
        {
            if (!_debugging)
                Initiate();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_debugging)
            {
                e.Cancel = true;
                Task.Factory.StartNew(Game.Disconnect, TaskCreationOptions.LongRunning);
            }
        }

        private void SendToServerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IPacketTxt.Text)) return;
            AttemptSendToServer(new HMessage(IPacketTxt.Text));
        }
        private void SendToClientBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IPacketTxt.Text)) return;
            AttemptSendToClient(new HMessage(IPacketTxt.Text));
        }

        private void ExtensionViewer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect != DragDropEffects.Copy) return;

            string filePath = ((string[])(e.Data.GetData(DataFormats.FileDrop)))[0];
            IHExtension extension = _tanjiExtensions.LoadExtension(filePath);
            if (extension != null) extension.InitializeExtension();
        }
        private void ExtensionViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (((string[])(e.Data.GetData(DataFormats.FileDrop)))[0].EndsWith(".dll"))
                e.Effect = DragDropEffects.Copy;
        }

        #region Constructer Related Methods
        private void ICAppendIntegerBtn_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(ICValueTxt.Text, out value) || string.IsNullOrWhiteSpace(ICValueTxt.Text))
                ICTanjiConstructer.AppendChunk(value);
            else MessageBox.Show(NotInt32, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ICAppendStringBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.AppendChunk(ICValueTxt.Text);
        }
        private void ICAppendBooleanBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.AppendChunk((!string.IsNullOrEmpty(ICValueTxt.Text) && (ICValueTxt.Text[0] == 't' || ICValueTxt.Text[0] == '1')));
        }

        private void ICMoveUpBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.MoveSelectedUp();
        }
        private void ICMoveDownBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.MoveSelectedDown();
        }

        private void ICClearBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.ClearChunks();
            ICEditBtn.Enabled = ICRemoveBtn.Enabled = ICMoveDownBtn.Enabled = ICMoveUpBtn.Enabled = false;
        }
        private void ICRemoveBtn_Click(object sender, EventArgs e)
        {
            ICTanjiConstructer.RemoveSelected();
        }
        private void ICEditBtn_Click(object sender, EventArgs e)
        {
            var tanjiEditF = new TanjiConstructEdit(ICTanjiConstructer);
            tanjiEditF.ShowDialog();
        }
        private void ICTransferBtn_Click(object sender, EventArgs e)
        {
            HMessage packet = GetConstructerPacket();
            if (packet != null) IPacketTxt.Text = packet.ToString();
        }

        private void ICCopyPacketBtn_Click(object sender, EventArgs e)
        {
            HMessage packet = GetConstructerPacket();
            if (packet != null) Clipboard.SetText(packet.ToString());
        }
        private void ICSendToServerBtn_Click(object sender, EventArgs e)
        {
            HMessage packet = GetConstructerPacket();
            if (packet == null) return;
            AttemptSendToServer(packet);
        }
        private void ICSendToClientBtn_Click(object sender, EventArgs e)
        {
            HMessage packet = GetConstructerPacket();
            if (packet == null) return;
            AttemptSendToClient(packet);
        }

        private void ICTanjiConstructer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ICTanjiConstructer.SelectedItems.Count == 1)
                ICEditBtn_Click(sender, e);
        }
        private void ICTanjiConstructer_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ICEditBtn.Enabled = ICRemoveBtn.Enabled = true;
                if (ICTanjiConstructer.Items.Count > 1)
                {
                    ICMoveUpBtn.Enabled = e.ItemIndex != 0;
                    ICMoveDownBtn.Enabled = e.ItemIndex != ICTanjiConstructer.Items.Count - 1;
                }
            }
            else ICEditBtn.Enabled = ICRemoveBtn.Enabled = ICMoveUpBtn.Enabled = ICMoveDownBtn.Enabled = false;
        }
        #endregion

        #region Encode/Decoder Related Methods
        private void ModernCypherIntegerBtn_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(ModernIntegerInputTxt.Text, out value))
                ModernIntegerOutputTxt.Text = HMessage.ToString(Modern.CypherInt(value));
            else MessageBox.Show(NotInt32, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ModernDecypherIntegerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ModernIntegerOutputTxt.Text))
                ModernIntegerInputTxt.Text = Modern.DecypherInt(HMessage.ToBytes(ModernIntegerOutputTxt.Text)).ToString();
        }

        private void ModernCypherShortBtn_Click(object sender, EventArgs e)
        {
            ushort value;
            if (ushort.TryParse(ModernShortInputTxt.Text, out value))
                ModernShortOutputTxt.Text = HMessage.ToString(Modern.CypherShort(value));
            else MessageBox.Show(NotUInt16, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ModernDecypherShortBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ModernShortOutputTxt.Text))
                ModernShortInputTxt.Text = Modern.DecypherShort(HMessage.ToBytes(ModernShortOutputTxt.Text)).ToString();
        }

        private void AncientCypherIntegerBtn_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(AncientIntegerInputTxt.Text, out value))
                AncientIntegerOutputTxt.Text = HMessage.ToString(Ancient.CypherInt(value));
            else MessageBox.Show(NotInt32, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void AncientDecypherIntegerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AncientIntegerOutputTxt.Text))
                AncientIntegerInputTxt.Text = Ancient.DecypherInt(HMessage.ToBytes(AncientIntegerOutputTxt.Text)).ToString();
        }
        private void AncientCypherShortBtn_Click(object sender, EventArgs e)
        {
            ushort value;
            if (ushort.TryParse(AncientShortInputTxt.Text, out value))
                AncientShortOutputTxt.Text = HMessage.ToString(Ancient.CypherShort(value));
            else MessageBox.Show(NotUInt16, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void AncientDecypherShortBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AncientShortOutputTxt.Text))
                AncientShortInputTxt.Text = Ancient.DecypherShort(HMessage.ToBytes(AncientShortOutputTxt.Text)).ToString();
        }

        private void ExtractValuesBtn_Click(object sender, EventArgs e)
        {
            VL64Chunks.Items.Clear();
            VL64ChunkTxt.Text = VL64ValueTxt.Text = string.Empty;
            ChunksFoundLbl.Text = "Chunks Found: 0";

            string vl64String = VL64StringTxt.Text;
            while (vl64String.Length != 0)
            {
                int chunkLength = (vl64String[0] >> 3) & 7;
                if (chunkLength > 0 && chunkLength <= vl64String.Length)
                {
                    string chunk = vl64String.Substring(0, chunkLength);
                    int value = Ancient.DecypherInt(chunk);

                    var vl64Item = new ListViewItem(new[] { chunk, value.ToString() });
                    VL64Chunks.Items.Add(vl64Item);
                    vl64String = vl64String.Substring(chunkLength);
                }
                else return;
            }
            ChunksFoundLbl.Text = "Chunks Found: " + VL64Chunks.Items.Count;
            VL64Chunks.Items[0].Selected = true;
            VL64Chunks.Select();
        }
        private void VL64Chunks_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = VL64Chunks.Columns[e.ColumnIndex].Width;
        }
        private void VL64Chunks_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                VL64ChunkTxt.Text = e.Item.SubItems[0].Text;
                VL64ValueTxt.Text = e.Item.SubItems[1].Text;
            }
            else VL64ChunkTxt.Text = VL64ValueTxt.Text = string.Empty;
        }
        #endregion

        #region Scheduler Related Methods
        private void ISStopAllBtn_Click(object sender, EventArgs e)
        {
            ISTanjiScheduler.StopAll();
            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.SchedulesRunning, ISTanjiScheduler.Items.Count);
        }
        private void ISToggleBtn_Click(object sender, EventArgs e)
        {
            ISTanjiScheduler.ToggleSelected();
            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.SchedulesRunning, ISTanjiScheduler.Items.Count);
        }
        private void ISRemoveBtn_Click(object sender, EventArgs e)
        {
            ISTanjiScheduler.RemoveSelected();
            ISStopAllBtn.Enabled = (ISTanjiScheduler.Items.Count > 0);
            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.SchedulesRunning, ISTanjiScheduler.Items.Count);
        }
        private void ISEditBtn_Click(object sender, EventArgs e)
        {

        }
        private void ISCreateBtn_Click(object sender, EventArgs e)
        {
            var packet = GetSchedulerPacket();
            if (packet == null) return;

            ISStopAllBtn.Enabled = true;
            ISTanjiScheduler.AddSchedule(new HSchedule(packet, (int)ISIntervalTxt.Value, (int)ISBurstTxt.Value), true, ISDescriptionTxt.Text);

            SchedulesTxt.Text = string.Format(ScheduleFormat, ISTanjiScheduler.SchedulesRunning, ISTanjiScheduler.Items.Count);
        }

        private void ISTanjiScheduler_ItemActivate(object sender, EventArgs e)
        {
            if (ISTanjiScheduler.SelectedItems.Count == 1)
                ISToggleBtn_Click(sender, e);
        }
        private void ISTanjiScheduler_ScheduleTriggered(object sender, ScheduleTriggeredEventArgs e)
        {
            if (e.Packet.IsCorrupted) return;

            if (e.Packet.Destination == HDestinations.Client)
                AttemptSendToClient(e.Packet);
            else if (e.Packet.Destination == HDestinations.Server)
                AttemptSendToServer(e.Packet);
        }
        private void ISTanjiScheduler_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (ISEditBtn.Enabled != e.IsSelected)
                /* ISEditBtn.Enabled = */ ISRemoveBtn.Enabled = ISToggleBtn.Enabled = e.IsSelected;
        }
        #endregion
        #endregion

        #region Game Connection Event Listeners
        private void Handshake_ToServer(object sender, DataToEventArgs e)
        {
            try
            {
                switch (e.Step)
                {
                    case 3:
                    {
                        _fakeServerKey = _fakeServer.GetSharedKey(e.Packet.ReadString());
                        e.Packet = new HMessage(e.Packet.Header, HDestinations.Server, HProtocols.Modern, _fakeClient.PublicKey);
                        break;
                    }
                    case 4:
                    {
                        if (e.Packet.IsCorrupted)
                        {
                            Game.ClientEncrypt = new Rc4(_fakeClientKey);
                            Game.ClientDecrypt = new Rc4(_fakeServerKey);
                            Game.ClientDecrypt.Parse(e.Packet.ToBytes());
                            e.Packet = new HMessage(e.Packet.ToBytes(), HDestinations.Server);
                        }
                        break;
                    }
                }
            }
            catch { _packetloggerF.DisplayMessage("Client > Server: Handshake failed!"); HandshakeFinished(); }

            Game_DataToServer(sender, e);
        }
        private void Handshake_ToClient(object sender, DataToEventArgs e)
        {
            try
            {
                switch (e.Step)
                {
                    case 1:
                    {
                        _fakeClient.DoHandshake(e.Packet.ReadString(), e.Packet.ReadString());
                        e.Packet = new HMessage(e.Packet.Header, HDestinations.Client, HProtocols.Modern, _fakeServer.SignedPrime, _fakeServer.SignedGenerator);
                        break;
                    }
                    case 2:
                    {
                        _fakeClientKey = _fakeClient.GetSharedKey(e.Packet.ReadString());
                        e.Packet = new HMessage(e.Packet.Header, HDestinations.Client, HProtocols.Modern, _fakeServer.PublicKey, true);
                        break;
                    }
                    case 3:
                    {
                        if (e.Packet.IsCorrupted)
                        {
                            Game.ServerDecrypt = new Rc4(_fakeClientKey);
                            Game.ServerEncrypt = new Rc4(_fakeServerKey);
                            Game.ServerDecrypt.Parse(e.Packet.ToBytes());
                            e.Packet = new HMessage(e.Packet.ToBytes(), HDestinations.Client);
                        }
                        break;
                    }
                    default: HandshakeFinished(); break;
                }
            }
            catch { _packetloggerF.DisplayMessage("Server > Client: Handshake failed!"); HandshakeFinished(); }

            Game_DataToClient(sender, e);
        }

        private void Game_DataToServer(object sender, DataToEventArgs e)
        {
            if (_packetloggerF.ViewOutgoing)
                _packetloggerF.PushToQueue(e.Packet);

            _tanjiExtensions.DistributeToServer(e.Packet.ToBytes());
        }
        private void Game_DataToClient(object sender, DataToEventArgs e)
        {
            if (_packetloggerF.ViewIncoming)
                _packetloggerF.PushToQueue(e.Packet);

            _tanjiExtensions.DistributeToClient(e.Packet.ToBytes());
        }

        private void Game_Disconnected(object sender, DisconnectedEventArgs e)
        {
            Game.LockEvents = Game.CaptureEvents = false;
            e.UnsubscribeFromEvents = true;
            Task.Factory.StartNew(Reinitiate, TaskCreationOptions.LongRunning);
        }
        #endregion

        #region Overrided Methods
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResize(e);
            var screen = Screen.FromPoint(Location);
            if (DoSnap(Left, screen.WorkingArea.Left)) Left = screen.WorkingArea.Left;
            if (DoSnap(Top, screen.WorkingArea.Top)) Top = screen.WorkingArea.Top;
            if (DoSnap(screen.WorkingArea.Right, Right)) Left = screen.WorkingArea.Right - Width;
            if (DoSnap(screen.WorkingArea.Bottom, Bottom)) Top = screen.WorkingArea.Bottom - Height;
        }
        #endregion

        #region Private Methods
        private void Initiate()
        {
            if (InvokeRequired) { Invoke(_initiate); return; }

            _tanjiConnect.ShowDialog();

            const string TanjiTitleFormat = "Tanji ~ Connected[{0}:{1}]";
            Text = string.Format(TanjiTitleFormat, Game.Host, Game.Port);

            ProtocolTxt.Text = string.Format(ProtocolFormat, Game.Protocol);

            Show();
            BringToFront();

            _packetloggerF.Show();
            _packetloggerF.BringToFront();
        }
        private void Reinitiate()
        {
            if (InvokeRequired) { Invoke(_reinitiate); return; }

            _fakeClient.Flush();
            _fakeServer.Flush();

            _packetloggerF.Halt();

            Hide();
            _packetloggerF.Hide();

            Task.Factory.StartNew(Initiate);
        }

        private void LoadRsaKeys()
        {
            _realModulus = "e052808c1abef69a1a62c396396b85955e2ff522f5157639fa6a19a98b54e0e4d6e44f44c4c0390fee8ccf642a22b6d46d7228b10e34ae6fffb61a35c11333780af6dd1aaafa7388fa6c65b51e8225c6b57cf5fbac30856e896229512e1f9af034895937b2cb6637eb6edf768c10189df30c10d8a3ec20488a198063599ca6ad";
            _realExponent = 10001;

            _fakeModulus = "bb48f10b18b0c2ad9c535a6a9265de239f37380a21af09646d266bcf0895d332f7435c14816d8921f5e0f770725891dd42b205d2d67121585056f0c7e570db71ceb3cada4cfbc9ca525f1582e004b9c8ab8b2d8137de5b2e199dac134db042a71983a38f372474be26e6b8e28e2d46e0d24f69ed18477a092d7f80c0136f1011";
            _fakeExponent = 10001;
            _fakePrivateExponent = "75c7ae875af4b6c9b5d919b091f6ec579ca67e60a8c44a74d4cbe7dae0bc5080e9cd7bd80d7954577e290793b8e5887e0c96a660eca962de065056c66fbda4d2fd00c056f643f567debf496031adb657ea66159143e4e608a9518ed8bb843446f71bd8b1930a564faf389919f6bf9bef3cef674b2b6c384e196a29549d92954d";

        }
        private void HandshakeFinished()
        {
            Game.DataToClient -= Handshake_ToClient;
            Game.DataToClient += Game_DataToClient;

            Game.DataToServer -= Handshake_ToServer;
            Game.DataToServer += Game_DataToServer;
        }

        private void AttemptSendToServer(HMessage packet)
        {
            if (!packet.IsCorrupted) Game.SendToServer(packet.ToBytes());
            else MessageBox.Show(InjServerCanc, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void AttemptSendToClient(HMessage packet)
        {
            if (!packet.IsCorrupted) Game.SendToClient(packet.ToBytes());
            else MessageBox.Show(InjClientCanc, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private HMessage GetSchedulerPacket()
        {
            var packet = new HMessage(ISPacketTxt.Text, (HDestinations)(ISDirectionTxt.SelectedIndex + 1));
            if (!packet.IsCorrupted) return packet;
            MessageBox.Show(CorrPack, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        private HMessage GetConstructerPacket()
        {
            ushort header;
            if (ushort.TryParse(ICHeaderTxt.Text, out header))
                return ICTanjiConstructer.Construct(header);

            MessageBox.Show(BadHeader, TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        #endregion

        #region Public Methods
        public void HookGameEvents()
        {
            if (_tanjiExtensions == null)
                _tanjiExtensions = new TanjiExtensions(Game, ExtensionViewer);

            if (Main.Game.Protocol == HProtocols.Modern && _tanjiConnect.UseCustomClient)
            {
                Game.DataToClient += Handshake_ToClient;
                Game.DataToServer += Handshake_ToServer;
            }
            else
            {
                Game.DataToClient += Game_DataToClient;
                Game.DataToServer += Game_DataToServer;
            }
            Game.Disconnected += Game_Disconnected;
        }

        public static bool DoSnap(int position, int edge)
        {
            int delta = position - edge;
            return delta < 0 || delta > 0 && delta <= 100;
        }
        #endregion
    }
}