using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSEControls
{
    public partial class Viewer : UserControl
    {
        public Viewer()
        {
            InitializeComponent();
            InitBrowser();
        }

        private async Task EnsureCoreWebView2()
        {
            await webView.EnsureCoreWebView2Async(null);
        }

        public async void InitBrowser()
        {
            string htmlContent = Properties.Resources.viewer;
            await EnsureCoreWebView2();
            webView.CoreWebView2.SetVirtualHostNameToFolderMapping("pse.viewer", "assets", CoreWebView2HostResourceAccessKind.DenyCors);
            webView.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            webView.CoreWebView2.NavigateToString(htmlContent);
        }

        public void ShowDXF(string dxf)
        {
            webView.CoreWebView2?.ExecuteScriptAsync(string.Format("ShowDXF(`{0}`)", dxf));
        }
        public void ClearViewer()
        {
            webView.CoreWebView2?.ExecuteScriptAsync("ClearViewer()");
        }
    }
}
