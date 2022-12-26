using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace BackgroundBrowser
{
    public partial class UserControl1 : UserControl
    {
        TabPage tab = null;
        string defaulturl = "https://www.google.com";
        public UserControl1(object obj)
        {
            InitializeComponent();
            tab = obj as TabPage;
            InitializeEdge();
            InitializeAsync();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020;
                return cp;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // dont code anything here. Leave blank
        }
        protected void InvalidateEx()
        {
            if (Parent == null)
                return;
            Rectangle rc = new Rectangle(this.Location, this.Size);
            Parent.Invalidate(rc, true);
        }
        private void Webview_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            string myUrl = ((Microsoft.Web.WebView2.WinForms.WebView2)sender).Source.ToString();
            txtUrl.Text = defaulturl;
            string ptx = webview.CoreWebView2.DocumentTitle.ToString();
            tab.ToolTipText = ptx;
            tab.Text = ptx.Length < 15 ? ptx : ptx.Substring(0, 10);//set the caption of browser tab
            tab.Width = tab.Text.Length < 15 ? 15 : tab.Text.Length;
        }

        async void InitializeAsync()
        {
            await webview.EnsureCoreWebView2Async(null);
            webview.CoreWebView2.WebMessageReceived += UpdateAddressBar;
            webview.NavigationCompleted += Webview_NavigationCompleted;
            await webview.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
        }

        async void InitializeEdge()
        {
            await webview.EnsureCoreWebView2Async(null);
            webview.CoreWebView2.Navigate(defaulturl);
            //webview.Source = new Uri(defaulturl);
            txtUrl.Text = defaulturl;
            btnRun_Click(btnRun, new EventArgs());
        }
        private async void UpdateTitleWithEvent(string v)
        {
            await webview.EnsureCoreWebView2Async(null);
        }
        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            UpdateTitleWithEvent(uri);
            txtUrl.Text = uri;
            webview.CoreWebView2.PostWebMessageAsString(uri);
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            var rawUrl = txtUrl.Text;
            Uri uri = null;

            if (Uri.IsWellFormedUriString(rawUrl, UriKind.Absolute))
            {
                uri = new Uri(rawUrl);
            }
            else if (!rawUrl.Contains(" ") && rawUrl.Contains("."))
            {
                // An invalid URI contains a dot and no spaces, try tacking http:// on the front.
                uri = new Uri("http://" + rawUrl);
            }
            webview.Source = uri;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webview.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webview.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webview.Refresh();                
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                webview.GoForward();
            }
        }

    }
}
