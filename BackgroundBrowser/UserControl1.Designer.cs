namespace BackgroundBrowser
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.webview = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.webview)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(93, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(739, 20);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // webview
            // 
            this.webview.AllowExternalDrop = true;
            this.webview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webview.CreationProperties = null;
            this.webview.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webview.Location = new System.Drawing.Point(0, 24);
            this.webview.Name = "webview";
            this.webview.Size = new System.Drawing.Size(863, 426);
            this.webview.Source = new System.Uri("https://www.microsoft.com", System.UriKind.Absolute);
            this.webview.TabIndex = 4;
            this.webview.ZoomFactor = 1D;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add_plus_icon.png");
            this.ımageList1.Images.SetKeyName(1, "back_arrow_icon.png");
            this.ımageList1.Images.SetKeyName(2, "forward_arrow_icon.png");
            this.ımageList1.Images.SetKeyName(3, "refresh_arrows_multimedia_media_icon.png");
            this.ımageList1.Images.SetKeyName(4, "run.png");
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.ImageIndex = 4;
            this.btnRun.ImageList = this.ımageList1;
            this.btnRun.Location = new System.Drawing.Point(838, 1);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(25, 23);
            this.btnRun.TabIndex = 11;
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageIndex = 3;
            this.btnRefresh.ImageList = this.ımageList1;
            this.btnRefresh.Location = new System.Drawing.Point(62, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnForward
            // 
            this.btnForward.ImageIndex = 2;
            this.btnForward.ImageList = this.ımageList1;
            this.btnForward.Location = new System.Drawing.Point(31, 1);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(25, 23);
            this.btnForward.TabIndex = 9;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.ImageIndex = 1;
            this.btnBack.ImageList = this.ımageList1;
            this.btnBack.Location = new System.Drawing.Point(0, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.Controls.Add(this.txtUrl);
            this.panelMenu.Controls.Add(this.btnRun);
            this.panelMenu.Controls.Add(this.btnForward);
            this.panelMenu.Controls.Add(this.btnBack);
            this.panelMenu.Controls.Add(this.btnRefresh);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(863, 25);
            this.panelMenu.TabIndex = 13;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.webview);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(863, 462);
            ((System.ComponentModel.ISupportInitialize)(this.webview)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private Microsoft.Web.WebView2.WinForms.WebView2 webview;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.Panel panelMenu;
    }
}
