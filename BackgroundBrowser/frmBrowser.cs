using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundBrowser
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;//set tab drawable
            AddTab();
        }
        Rectangle closeX = Rectangle.Empty;
        private void btnNewTab_Click(object sender, EventArgs e)
        {
            AddTab();
        }
        private void AddTab() 
        {
            tabControl1.TabPages.Add("New Tab ");
            TabPage tb = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            tb.Controls.Add(new UserControl1(tb));
            tb.Controls[0].Dock= DockStyle.Fill;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Size xSize = new Size(13, 13);
            TabPage tp = tabControl1.TabPages[e.Index];
            e.DrawBackground();
            using (SolidBrush brush = new SolidBrush(e.ForeColor))
                e.Graphics.DrawString(tp.Text + "   ", e.Font, brush,
                                      e.Bounds.X + 3, e.Bounds.Y + 4);

            if (e.State == DrawItemState.Selected)
            {
                closeX = new Rectangle(
                    e.Bounds.Right - xSize.Width, e.Bounds.Top, xSize.Width, xSize.Height);
                /*use x character without using a image*/
                    using (SolidBrush brush = new SolidBrush(Color.LightGray))
                    e.Graphics.DrawString("x", e.Font, brush,
                                           e.Bounds.Right - xSize.Width, e.Bounds.Y + 4);
                
                /*e.Graphics.DrawImage(imgList.Images[0], closeX,
                            new Rectangle(0, 0, 16, 16), GraphicsUnit.Pixel);*/
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (closeX.Contains(e.Location))
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void addTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab();
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void sizableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void sendToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(2000);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Re(trackBar1.Value == 100);
        }
        private void Re(bool panelvisible) 
        {
            int dgr = trackBar1.Value;
            this.Opacity = dgr / 100f;
            if (dgr == 100)
            {
                this.TransparencyKey = Color.FromArgb(0, 0, 0, 0);
                menuStrip1.Visible = true;
                chkTopMost.Visible = true;
            }
            else
            {
                this.TransparencyKey = (BackColor);
                menuStrip1.Visible = false;
                chkTopMost.Visible = false;
            }
            foreach (TabPage tab in tabControl1.TabPages)
            {
                foreach (Control ctrl in tab.Controls)
                {
                    if (ctrl is UserControl1)
                    {
                        UserControl1 uc = ctrl as UserControl1;
                        uc.panelMenu.Visible = panelvisible;

                        foreach (Control c in ctrl.Controls)
                        {
                            if (!(c is Microsoft.Web.WebView2.WinForms.WebView2))
                            {
                                c.Visible = panelvisible;
                            }
                            foreach (Control c2 in c.Controls)
                            {
                                if (!(c2 is Microsoft.Web.WebView2.WinForms.WebView2))
                                {
                                    c2.Visible = panelvisible;
                                }
                            }
                        }
                    }
                }
            }
        }


        private void TopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private void menuBorderStyle_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = this.FormBorderStyle == FormBorderStyle.None ? FormBorderStyle.Sizable : FormBorderStyle.None;
        }

        private void frmBrowser_Resize(object sender, EventArgs e)
        {
            chkTopMost.Checked = false;
            this.TransparencyKey = Color.FromArgb(0, 0, 0, 0);
            if (trackBar1.Value == 100)
            {
                Re(true);
            }
            else
            {
                trackBar1.Value = 100;
            }
        }
    }
}
