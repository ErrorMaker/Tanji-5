using System;
using Sulakore;
using System.IO;
using System.Text;
using Tanji.Services;
using System.Drawing;
using Tanji.Properties;
using System.Windows.Forms;
using Sulakore.Communication;
using Sulakore.Communication.Proxy;

namespace Tanji.Dialogs
{
    public partial class TanjiConnect : Form
    {
        #region Private Fields
        private Main _main;

        private int _aTick, _maskPort;
        private byte[] _customClientData;
        private string _aStatus, _maskHost;
        private bool _setupFinished, _wasSetInManual;

        private readonly Color _tanjiC;
        private readonly EventHandler _onConnected;

        private const int DefaultPort = 38101;
        private const int EavesdropperPort = 8080;

        private const string ASprite = "...";
        private const string DefaultHost = "game-us.habbo.com";
        private const string InfoHost = "\"connection.info.host\" : ";
        private const string InfoPort = "\"connection.info.port\" : ";
        private const string FlashClientUrl = "\"flash.client.url\" : ";
        private const string HotelViewBannerUrl = "\"hotelview.banner.url\" : ";
        private const string ManualMissing = "You must fill in both fields(Host/Port) to continue with the connection process.";
        private const string HostExtractFail = "Unable to retrieve the target's 'connection.info.host' value, a mask is needed to bypass this problem.";
        private const string PortExtractFail = "Unable to retrieve the target's 'connection.info.port' value, a mask is needed to bypass this problem.";
        private const string ResourceDownloadFailed = "Unable to download resource '{0}.swf', you must manually place the needed modded client build in the 'Patched Clients' folder.";
        #endregion

        #region Public Properties
        public string RealHost { get; private set; }
        public string RealPort { get; private set; }
        public TanjiModes TanjiMode { get; private set; }
        public bool UseCustomClient { get; private set; }
        #endregion

        #region Constructor(s)
        public TanjiConnect(Main main)
        {
            _main = main;

            InitializeComponent();

            Eavesdropper.DisableCache = true;
            Eavesdropper.OnEavesRequest += Eavesdropper_OnEavesRequest;
            Eavesdropper.OnEavesResponse += Eavesdropper_OnEavesResponse;

            _tanjiC = Color.FromArgb(243, 63, 63);
            _onConnected = Game_Connected;
        }
        #endregion

        #region User Interface Event Listeners
        private void TanjiConnect_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            ushort port;
            string host = GameHostTxt.Text.Trim();
            bool portConversionSuccess = ushort.TryParse(GamePortTxt.Text.Trim(), out port);

            switch (TanjiMode)
            {
                case TanjiModes.Automatic:
                {
                    StartAnimation("Altering Response%");

                    if (!string.IsNullOrWhiteSpace(host)) _maskHost = host.ToLower();
                    if (portConversionSuccess) _maskPort = port;

                    Eavesdropper.Initiate(EavesdropperPort);
                    break;
                }
                case TanjiModes.Manual:
                {
                    if (string.IsNullOrWhiteSpace(host) || !portConversionSuccess)
                    {
                        const string message = "You've specified invalid details into the connection input boxes, please correct these issues before you can continue.";
                        MessageBox.Show(message, Main.TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (UseCustomClient)
                        Eavesdropper.Initiate(EavesdropperPort);

                    StartAnimation("Connecting% | Port: " + port);

                    Main.Game = new HConnection(host, port);
                    Main.Game.Connected += Game_Connected;
                    Main.Game.Connect(true);
                    break;
                }
            }

            ProcessBtn.Text = "Cancel";
            ProcessBtn.Click -= Connect_Click;
            ProcessBtn.Click += Cancel_Click;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            StopAnimation("Standing by...");
            Eavesdropper.Terminate();

            if (Main.Game != null)
            {
                Main.Game.Dispose();
                Main.Game = null;
            }

            ProcessBtn.Text = "Connect";
            ProcessBtn.Click -= Cancel_Click;
            ProcessBtn.Click += Connect_Click;
        }

        private void Manual_Click(object sender, EventArgs e)
        {
            if (!SetTanjiMode(TanjiModes.Manual)) return;

            if (CustomChckbx.Checked && !_wasSetInManual)
                CustomChckbx.Checked = PromptUseCustomClient();
        }
        private void Automatic_Click(object sender, EventArgs e)
        {
            SetTanjiMode(TanjiModes.Automatic);
        }

        private void ATimer_Tick(object sender, EventArgs e)
        {
            StatusTxt.Text = _aStatus.Replace("%", ASprite.Substring(0, _aTick + 1));
            _aTick += _aTick == 2 ? -2 : 1;
        }
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            ChooseClientDlg.FileName = ChooseClientDlg.SafeFileName;
            if (ChooseClientDlg.ShowDialog() != DialogResult.OK) return;

            ProcessSwf(ChooseClientDlg.FileName);
        }
        private void CustomChckbx_CheckedChanged(object sender, EventArgs e)
        {
            _wasSetInManual = (TanjiMode == TanjiModes.Manual);

            bool enable = (CustomChckbx.Checked && _wasSetInManual ? PromptUseCustomClient() : CustomChckbx.Checked);
            CustomChckbx.Checked = CustomClientTxt.Enabled = BrowseBtn.Enabled = enable;

            UseCustomClient = (_customClientData != null && _customClientData.Length > 0 && enable);
        }
        private void GameHostTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TanjiMode == TanjiModes.Manual)
                GamePortTxt.SelectedIndex = Convert.ToInt32(GameHostTxt.SelectedIndex != 0);
        }

        private void TanjiConnect_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect != DragDropEffects.Copy) return;
            CustomChckbx.Checked = true;

            if (CustomChckbx.Checked)
                ProcessSwf(((string[])(e.Data.GetData(DataFormats.FileDrop)))[0]);
        }
        private void TanjiConnect_DragEnter(object sender, DragEventArgs e)
        {
            if (((string[])(e.Data.GetData(DataFormats.FileDrop)))[0].EndsWith(".swf"))
                e.Effect = DragDropEffects.Copy;
        }

        private void TanjiConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            if (!_setupFinished)
            {
                Eavesdropper.Terminate();

                if (Main.Game != null)
                    Main.Game.Dispose();

                Environment.Exit(0);
            }
            ResetSetup();
        }
        #endregion

        #region Eavesdropper Event Listeners
        private void Eavesdropper_OnEavesRequest(object sender, EavesRequestEventArgs e)
        {
            if (e.Url.Contains("cacheCheck?r="))
                e.Cancel = true;
        }
        private void Eavesdropper_OnEavesResponse(object sender, EavesResponseEventArgs e)
        {
            if (UseCustomClient && e.IsSwf && e.ResponeData.Length > 3000000)
            {
                e.ResponeData = _customClientData;
                Eavesdropper.Terminate();
                return;
            }

            if (TanjiMode == TanjiModes.Manual) return;
            string response = Encoding.UTF8.GetString(e.ResponeData);
            if (response.Contains(InfoHost) && response.Contains(InfoPort))
            {
                bool isOriginal = SKore.IsOriginal(e.Host);

                string flashVars = response.GetChild("var flashvars", '}');
                while (!flashVars.Contains(InfoHost) || !flashVars.Contains(InfoPort))
                    flashVars = flashVars.GetChild("var flashvars = {", '}');

                string extractedHost = flashVars.GetChild(InfoHost, ',').Trim();
                string extractedPort = flashVars.GetChild(InfoPort, ',').Trim();

                #region Extract 'connection.info.host'
                if (string.IsNullOrEmpty(_maskHost))
                {
                    if (!extractedHost.StartsWith("\""))
                    {
                        PromptEavesdropperReset(HostExtractFail, Main.TanjiError, MessageBoxIcon.Error);
                        return;
                    }
                    else _maskHost = extractedHost.Split('"')[1];
                }
                #endregion
                #region Extract 'connection.info.port'
                if (_maskPort == 0)
                {
                    if (!extractedPort.StartsWith("\""))
                    {
                        PromptEavesdropperReset(PortExtractFail, Main.TanjiError, MessageBoxIcon.Error);
                        return;
                    }
                    else _maskPort = ushort.Parse(extractedPort.Split(',')[0].Split('"')[1]);
                }
                #endregion
                #region Extract 'hotelview.banner.url'
                if (!isOriginal && response.Contains(HotelViewBannerUrl))
                {
                    Main.Cookies = e.Cookies;
                    Main.UserAgent = e.UserAgent;
                    Main.BannerUrl = response.GetChild(HotelViewBannerUrl, ',');
                    if (Main.BannerUrl.StartsWith("\"")) Main.BannerUrl = Main.BannerUrl.Split('"')[1] + "?token=";
                    if (Main.BannerUrl.StartsWith("//")) Main.BannerUrl = "http://" + Main.BannerUrl;
                }
                #endregion

                if (!isOriginal)
                {
                    response = response.Replace(string.Format("{0}{1},", InfoHost, extractedHost), InfoHost + "\"127.0.0.1\",");
                    e.ResponeData = Encoding.UTF8.GetBytes(response);
                }
                else
                {
                    //_flashClientRevision = ("http://" + response.GetChild(FlashClientUrl, ',').Split('"')[1].Substring(3)).Split('/')[4];
                    //if (!DownloadClient(_flashClientRevision))
                    //{
                    //    ResetTanji();
                    //    MessageBox.Show(string.Format(ResourceDownloadFailed, _flashClientRevision), "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                }

                if (!UseCustomClient) Eavesdropper.Terminate();
                SetAnimation("Connecting% | Port: " + _maskPort);

                Main.Game = new HConnection(_maskHost, _maskPort);
                Main.Game.Connected += Game_Connected;
                Main.Game.Connect(isOriginal);
            }
        }
        #endregion

        #region Game Connection Event Listeners
        private void Game_Connected(object sender, EventArgs e)
        {
            if (InvokeRequired) { Invoke(_onConnected, sender, e); return; }

            _main.HookGameEvents();

            _setupFinished = true;
            Close();
        }
        #endregion

        #region Overrided Methods
        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
            var screen = Screen.FromPoint(Location);
            if (Main.DoSnap(Left, screen.WorkingArea.Left)) Left = screen.WorkingArea.Left;
            if (Main.DoSnap(Top, screen.WorkingArea.Top)) Top = screen.WorkingArea.Top;
            if (Main.DoSnap(screen.WorkingArea.Right, Right)) Left = screen.WorkingArea.Right - Width;
            if (Main.DoSnap(screen.WorkingArea.Bottom, Bottom)) Top = screen.WorkingArea.Bottom - Height;
        }
        #endregion

        #region Private Methods
        private void ResetSetup()
        {
            Eavesdropper.Terminate();

            _maskPort = 0;
            _maskHost = string.Empty;

            _setupFinished = false;

            StopAnimation("Standing By...");
            if (ProcessBtn.Text == "Cancel")
            {
                ProcessBtn.Text = "Connect";
                ProcessBtn.Click -= Cancel_Click;
                ProcessBtn.Click += Connect_Click;
            }
        }
        private void ProcessSwf(string path)
        {
            CustomClientTxt.Text = path;
            Cursor = Cursors.WaitCursor;
            try { _customClientData = File.ReadAllBytes(path); }
            catch (Exception ex)
            {
                _customClientData = null;
                CustomChckbx.Checked = false;
                CustomClientTxt.Text = string.Empty;
                MessageBox.Show(ex.ToString(), Main.TanjiError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UseCustomClient = (_customClientData != null && _customClientData.Length > 0);
            Cursor = Cursors.Default;
        }
        private bool PromptUseCustomClient()
        {
            const string message = "The connection mode is currently set to manual which will not run Eavesdropper(proxy), although specifying a custom client will override that rule and enable Eavesdropper to inject our own client; Do you still wish to use a custom client?";
            DialogResult result = MessageBox.Show(message, Main.TanjiWarning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
        private void PromptEavesdropperReset(string message, string title, MessageBoxIcon icon)
        {
            ResetSetup();
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        private void SetAnimation(string status)
        {
            if (!status.Contains("%")) status += "%";
            _aStatus = status;
        }
        private void StopAnimation(string status)
        {
            ATimer.Stop();
            StatusTxt.Text = status;
        }
        private void StartAnimation(string status)
        {
            if (!status.Contains("%")) status += "%";

            _aStatus = status;
            ATimer.Start();
        }

        private void LoadSettings()
        {
            string port = Settings.Default.LastPort;
            string host = Settings.Default.LastHost;
            TanjiModes mode = (TanjiModes)Settings.Default.LastMode;

            if (!string.IsNullOrWhiteSpace(port))
            {
                ushort gamePort = 0;
                if (ushort.TryParse(port, out gamePort))
                {
                    if (!GamePortTxt.Items.Contains(port))
                        GamePortTxt.Items.Add(port);

                    GamePortTxt.Text = port;
                }
            }
            else if (mode == TanjiModes.Manual) GamePortTxt.SelectedIndex = 0;

            if (!string.IsNullOrWhiteSpace(host))
            {
                if (!GameHostTxt.Items.Contains(host))
                    GameHostTxt.Items.Add(host);

                GameHostTxt.Text = host;
            }

            if (Enum.IsDefined(typeof(TanjiModes), mode))
                SetTanjiMode(mode);
        }
        private void SaveSettings()
        {
            Settings.Default.LastPort = GamePortTxt.Text;
            Settings.Default.LastHost = GameHostTxt.Text;
            Settings.Default.LastMode = (int)TanjiMode;

            Settings.Default.Save();
        }
        private bool SetTanjiMode(TanjiModes mode)
        {
            if (TanjiMode == mode) return false;

            TanjiMode = mode;
            Text = string.Format("Tanji ~ Connection Setup [{0}]", mode);

            ManualH.BackColor = (mode == TanjiModes.Manual ? _tanjiC : Color.Silver);
            AutomaticH.BackColor = (mode == TanjiModes.Automatic ? _tanjiC : Color.Silver);

            string labelSuffix = (mode == TanjiModes.Automatic ? " ( Mask )" : string.Empty);
            GameHostLbl.Text = "Game Host" + labelSuffix;
            GamePortLbl.Text = "Game Port" + labelSuffix;

            if (TanjiMode == TanjiModes.Automatic)
            {
                GameHostTxt.SelectedIndex = -1;
                GamePortTxt.SelectedIndex = -1;
                GameHostTxt.Text = GamePortTxt.Text = string.Empty;
            }
            else if (GameHostTxt.SelectedIndex < 0) GameHostTxt.SelectedIndex = 0;
            else GamePortTxt.SelectedIndex = Convert.ToInt32(GameHostTxt.SelectedIndex != 0);
            return true;
        }
        #endregion
    }
}