using System;
using System.Windows.Forms;
using Sulakore.Communication;
using System.Collections.Generic;
using Sulakore.Communication.Bridge;

namespace Tanji.Services
{
    public class TanjiExtensions : HContractor
    {
        private readonly HConnection _connection;
        private readonly ListView _extensionViewer;
        private readonly AppDomain _extensionsDomain;
        private readonly Dictionary<ListViewItem, IHExtension> _extensionItems;

        public override IHConnection Connection
        {
            get { return _connection; }
        }

        public TanjiExtensions(HConnection connection, ListView extensionViewer)
        {
            _connection = connection;
            _extensionViewer = extensionViewer;
            _extensionsDomain = AppDomain.CreateDomain("TanjiExtensions");
            _extensionItems = new Dictionary<ListViewItem, IHExtension>();
        }
    }
}