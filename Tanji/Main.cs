using System;
using Sulakore;
using System.Net;
using Tanji.Dialogs;
using Tanji.Services;
using System.Drawing;
using Sulakore.Protocol;
using Tanji.Applications;
using System.Windows.Forms;
using Sulakore.Communication;
using System.Threading.Tasks;
using Sulakore.Protocol.Controls;
using System.Collections.Generic;
using Sulakore.Protocol.Encryption;
using Sulakore.Communication.Bridge;

namespace Tanji
{
    public partial class Main : Form
    {
        #region Private Fields
        private bool _debugging;
        private int _clientStepShift;
        private byte[] _fakeClientKey, _fakeServerKey;
        private HKeyExchange _fakeClient, _fakeServer;

        private readonly HContractor _contractor;
        private readonly TanjiConnect _tanjiConnect;
        private readonly Packetlogger _packetloggerF;
        private readonly Action _initiate, _reinitiate;

        private const string ProtocolFormat = "Protocol: {0}";
        private const string ScheduleFormat = "Schedules Active: {0}/{1}";
        private const string TanjiTitleFormat = "Tanji ~ Connected[{0}:{1}]";
        private const string CorrPack = "The given packet seems to be corrupted.";
        private const string BadHeader = "The header you've specified does not qualify as an UInt16 type.";
        private const string NotInt32 = "The given value does not qualify as an Int32 type.";
        private const string NotUInt16 = "The given value does not qualify as an UInt16 type.";
        private const string InjClientCanc = "The specified data is corrupted, injection to client cancelled!";
        private const string InjServerCanc = "The specified data is corrupted, injection to server cancelled!";
        #endregion

        #region Public Properties/Fields
        public IList<string[]> RsaKeys;

        public const string TanjiAlert = "Tanji ~ Alert!";
        public const string TanjiError = "Tanji ~ Error!";
        public const string TanjiWarning = "Tanji ~ Warning!";

        public static string BannerUrl { get; set; }
        public static string UserAgent { get; set; }
        public static HConnection Game { get; set; }
        public static CookieContainer Cookies { get; set; }

        public const int RealExponent = 10001;
        public const string RealModulus = "e052808c1abef69a1a62c396396b85955e2ff522f5157639fa6a19a98b54e0e4d6e44f44c4c0390fee8ccf642a22b6d46d7228b10e34ae6fffb61a35c11333780af6dd1aaafa7388fa6c65b51e8225c6b57cf5fbac30856e896229512e1f9af034895937b2cb6637eb6edf768c10189df30c10d8a3ec20488a198063599ca6ad";
        #endregion

        #region Constructor(s)
        public Main(bool debugging)
        {
            InitializeComponent();

            #region Populate Fake Keys
            RsaKeys = new List<string[]>();
            RsaKeys.Add(new[]
            {
                "3",
                "86851dd364d5c5cece3c883171cc6ddc5760779b992482bd1e20dd296888df91b33b936a7b93f06d29e8870f703a216257dec7c81de0058fea4cc5116f75e6efc4e9113513e45357dc3fd43d4efab5963ef178b78bd61e81a14c603b24c8bcce0a12230b320045498edc29282ff0603bc7b7dae8fc1b05b52b2f301a9dc783b7",
                "59ae13e243392e89ded305764bdd9e92e4eafa67bb6dac7e1415e8c645b0950bccd26246fd0d4af37145af5fa026c0ec3a94853013eaae5ff1888360f4f9449ee023762ec195dff3f30ca0b08b8c947e3859877b5d7dced5c8715c58b53740b84e11fbc71349a27c31745fcefeeea57cff291099205e230e0c7c27e8e1c0512b"
            });
            RsaKeys.Add(new[]
            {
                "10001",
                "bb48f10b18b0c2ad9c535a6a9265de239f37380a21af09646d266bcf0895d332f7435c14816d8921f5e0f770725891dd42b205d2d67121585056f0c7e570db71ceb3cada4cfbc9ca525f1582e004b9c8ab8b2d8137de5b2e199dac134db042a71983a38f372474be26e6b8e28e2d46e0d24f69ed18477a092d7f80c0136f1011",
                "75c7ae875af4b6c9b5d919b091f6ec579ca67e60a8c44a74d4cbe7dae0bc5080e9cd7bd80d7954577e290793b8e5887e0c96a660eca962de065056c66fbda4d2fd00c056f643f567debf496031adb657ea66159143e4e608a9518ed8bb843446f71bd8b1930a564faf389919f6bf9bef3cef674b2b6c384e196a29549d92954d"
            });
            RsaKeys.Add(new[]
            {
                "10001",
                "a55bb171aefecc9844b44970eedb4e94e74373a775642b0ea827326eeea039969385c59bc48b3a3fac4455768e2248f8d16ad244481c2c47e0f0c17c7643408ef2dc9205825852bc7f050d3681670bf9f6ebe5cdad4cded26b031ec45f1e36f1ba0aa7e1dda23682132aeaad4f05fec723dc589c30a17dcca8e4e839de3001ff",
                "854ab0728f395cfab10712dc31ee1e1df17d71d0ded3ebd158c29fe8c3f9ebf1f0e0b835a3ed06fb2485c0ce5c2c4ede231114856e0b27b6991ff917b6cce75007c93a94846890df86cf51abc555eb94a7f6ad62bc1f4f232579abe62a0f4b464b4354a956919a8437b684ca8e2c229b3d5c48d7d9869d712a78b7c8339ab001",
            });
            #endregion

            _contractor = new HContractor();
            _packetloggerF = new Packetlogger();
            _tanjiConnect = new TanjiConnect(this);

            _initiate = Initiate;
            _reinitiate = Reinitiate;
            _debugging = debugging;

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

            if (e.Packet.Destination == HDestination.Client)
                AttemptSendToClient(e.Packet);
            else if (e.Packet.Destination == HDestination.Server)
                AttemptSendToServer(e.Packet);
        }
        private void ISTanjiScheduler_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (ISEditBtn.Enabled != e.IsSelected)
                ISRemoveBtn.Enabled = ISToggleBtn.Enabled = e.IsSelected;
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

        #region Extensions Related Methods
        private void ExtensionViewer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect != DragDropEffects.Copy) return;

            string path = ((string[])(e.Data.GetData(DataFormats.FileDrop)))[0];
            AddExtension(path);
        }
        private void ExtensionViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (((string[])(e.Data.GetData(DataFormats.FileDrop)))[0].EndsWith(".dll"))
                e.Effect = DragDropEffects.Copy;
        }

        private void EInstallExtensionBtn_Click(object sender, EventArgs e)
        {
            ChooseExtensionDlg.FileName = ChooseExtensionDlg.SafeFileName;
            if (ChooseExtensionDlg.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            AddExtension(ChooseExtensionDlg.FileName);
        }

        private void ExtensionViewer_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ExtensionViewer.Columns[e.ColumnIndex].Width;
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
                        _fakeServerKey = !string.IsNullOrWhiteSpace(BannerUrl) ? new byte[] { 1 } : _fakeServer.GetSharedKey(e.Packet.ReadString());
                        e.Packet = new HMessage(e.Packet.Header, HDestination.Server, HProtocol.Modern, _fakeClient.PublicKey);
                        break;
                    }
                    case 4:
                    {
                        if (e.Packet.IsCorrupted)
                        {
                            Game.ClientEncrypt = new Rc4(_fakeClientKey);
                            Game.ClientDecrypt = new Rc4(_fakeServerKey);
                            Game.ClientDecrypt.Parse(e.Packet.ToBytes());
                            e.Packet = new HMessage(e.Packet.ToBytes(), HDestination.Server);
                        }
                        break;
                    }
                }
            }
            catch { HandshakeFinished(); }
            Game_DataToServer(sender, e);
        }
        private void Handshake_ToClient(object sender, DataToEventArgs e)
        {
            try
            {
                switch (e.Step - _clientStepShift)
                {
                    case 1:
                    {
                        try
                        {
                            _fakeClient.DoHandshake(e.Packet.ReadString(), e.Packet.ReadString());
                        }
                        catch
                        {
                            if (!AttemptHandshake(e.Packet))
                                HandshakeFinished();
                        }

                        if (string.IsNullOrWhiteSpace(BannerUrl))
                            e.Packet = new HMessage(e.Packet.Header, HDestination.Client, HProtocol.Modern, _fakeServer.SignedPrime, _fakeServer.SignedGenerator);
                        break;
                    }
                    case 2:
                    {
                        if (e.Packet.Length == 2) { _clientStepShift++; break; }
                        _fakeClientKey = _fakeClient.GetSharedKey(e.Packet.ReadString());

                        e.Packet = new HMessage(e.Packet.Header, HDestination.Client, HProtocol.Modern, (string.IsNullOrWhiteSpace(BannerUrl) ? _fakeServer.PublicKey : "1"), _tanjiConnect.IsOriginal);
                        break;
                    }
                    case 3:
                    {
                        if (e.Packet.IsCorrupted)
                        {
                            Game.ServerDecrypt = new Rc4(_fakeClientKey);
                            Game.ServerEncrypt = new Rc4(_fakeServerKey);
                            Game.ServerDecrypt.Parse(e.Packet.ToBytes());
                            e.Packet = new HMessage(e.Packet.ToBytes(), HDestination.Client);
                        }
                        break;
                    }
                    default: HandshakeFinished(); break;
                }
            }
            catch { HandshakeFinished(); }
            Game_DataToClient(sender, e);
        }

        private void Game_DataToServer(object sender, DataToEventArgs e)
        {
            if (_packetloggerF.ViewOutgoing)
                _packetloggerF.PushToQueue(e.Packet);

            _contractor.DistributeOutgoing(e.Packet.ToBytes());
        }
        private void Game_DataToClient(object sender, DataToEventArgs e)
        {
            if (_packetloggerF.ViewIncoming)
                _packetloggerF.PushToQueue(e.Packet);

            _contractor.DistributeIncoming(e.Packet.ToBytes());
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

            Text = string.Format(TanjiTitleFormat, Game.Host, Game.Port);
            ProtocolTxt.Text = string.Format(ProtocolFormat, Game.Protocol);
            _contractor.Connection = Game;

            Show();
            BringToFront();

            _packetloggerF.Show();
            _packetloggerF.BringToFront();
        }
        private void Reinitiate()
        {
            if (InvokeRequired) { Invoke(_reinitiate); return; }

            _clientStepShift = 0;
            BannerUrl = string.Empty;

            _fakeClient.Flush();
            _fakeServer.Flush();

            _packetloggerF.Halt();

            Hide();
            _packetloggerF.Hide();

            Task.Factory.StartNew(Initiate);
        }
        private void HandshakeFinished()
        {
            Game.DataToClient -= Handshake_ToClient;
            Game.DataToClient += Game_DataToClient;

            Game.DataToServer -= Handshake_ToServer;
            Game.DataToServer += Game_DataToServer;
        }
        private void AddExtension(string path)
        {
            IHExtension extension = _contractor.LoadExtension(path);

            if (extension != null)
                extension.InitializeExtension();
        }

        private bool AttemptHandshake(HMessage packet)
        {
            int position = 0;
            Bitmap banner = null;
            string signedPrime = null, signedGenerator = null, token = null;

            if (packet.Length > (packet.ReadShort(0) + 5))
            {
                signedPrime = packet.ReadString(ref position);
                signedGenerator = packet.ReadString(ref position);
            }
            else if (!string.IsNullOrWhiteSpace(BannerUrl))
            {
                token = packet.ReadString(ref position);
                banner = SKore.GetHotelBanner(BannerUrl, Cookies, UserAgent);
            }

            return RsaKeyVerifier(_fakeClient, signedPrime, signedGenerator, banner, token);
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
        private bool RsaKeyVerifier(HKeyExchange handshakee, string signedPrime, string signedGenerator, Bitmap banner, string token)
        {
            foreach (string[] fakeKeys in RsaKeys)
            {
                try
                {
                    int exponent = int.Parse(fakeKeys[0]);
                    string modulus = fakeKeys[1];
                    string privateExponent = fakeKeys[2];

                    _fakeClient = new HKeyExchange(exponent, modulus);
                    _fakeServer = new HKeyExchange(exponent, modulus, privateExponent);

                    if (banner == null || string.IsNullOrWhiteSpace(token)) _fakeClient.DoHandshake(signedPrime, signedGenerator);
                    else _fakeClient.DoHandshake(banner, token);
                    return true;
                }
                catch { }
            }
            return false;
        }

        private HMessage GetSchedulerPacket()
        {
            var packet = new HMessage(ISPacketTxt.Text, (HDestination)(ISDirectionTxt.SelectedIndex));
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
            if (Main.Game.Protocol == HProtocol.Modern &&
                (_tanjiConnect.UseCustomClient || _tanjiConnect.TanjiMode == TanjiModes.Automatic))
            {
                _fakeClient = new HKeyExchange(RealExponent, RealModulus);
                _fakeServer = new HKeyExchange(int.Parse(RsaKeys[0][0]), RsaKeys[0][1], RsaKeys[0][2]);

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
            return delta < 0 || delta > 0 && delta <= 20;
        }
        #endregion
    }
}