using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
namespace Browser
{
    public partial class Form1 : Form
    {
        Stopwatch sw;
        List<string> beginargs = new List<string>();
        public Form1(List<string> args)
        {
            InitializeComponent();
            sw = new();
            beginargs = args;
            if (beginargs.Count > 0) TopMost = true;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webView.GoBack();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            webView.GoForward();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            if (ReloadButton.Text == "Stop") webView.Stop();
            else webView.Reload();
        }

        private void webView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            ReloadButton.Text = "Stop";
            ReloadButton.ForeColor = Color.Red;
        }

        private void webView_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            ReloadButton.Text = "Reload";
            ReloadButton.ForeColor = Color.Black;
            NextButton.Enabled = webView.CanGoForward;
            BackButton.Enabled = webView.CanGoBack;
        }

        private void webView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            URIBox.Text = webView.Source.ToString();
        }

        private void URIBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (URIBox.Text.StartsWith("/"))
                {
                    switch (URIBox.Text.ToLower().Split(' ')[0])
                    {
                        case "/google":
                            webView.CoreWebView2.Navigate("https://google.com/");
                            break;
                        case "/yahoo":
                            webView.CoreWebView2.Navigate("https://yahoo.co.jp/");
                            break;
                        case "/remote":
                            webView.CoreWebView2.Navigate("https://remotedesktop.google.com/access");
                            break;
                        case "/bing":
                            webView.CoreWebView2.Navigate("https://www.bing.com/");
                            break;
                        case "/chatgpt":
                            webView.CoreWebView2.Navigate("https://chat.openai.com/");
                            break;
                        case "/reset":
                            sw.Reset();
                            break;
                        case "/start":
                            sw.Start();
                            break;
                        case "/stop":
                            sw.Stop();
                            break;
                        case "/title":
                            this.Invoke(() =>
                            {
                                if (URIBox.Text.Length <= 7) Text = "";
                                else Text = URIBox.Text[7..];
                            });
                            break;
                        default:
                            URIBox.Text = webView.Source.ToString();
                            break;
                    }
                    return;
                }
                try
                {
                    webView.CoreWebView2.Navigate(URIBox.Text);
                }
                catch
                {
                    try
                    {
                        webView.CoreWebView2.Navigate("https://" + URIBox.Text);
                    }
                    catch
                    {
                        URIBox.Text = webView.Source.ToString();
                    }
                }
            }
        }

        private void webView_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            MessageBox.Show(e.WebMessageAsJson);
        }

        private void webView_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (TopMost)
            {
                Activate();
                TopMost = false;
            }
            sw.Start();
            if (beginargs.Count > 0)
            {
                webView.Source = new Uri(beginargs[0]);
            }
            webView.CoreWebView2.DocumentTitleChanged += (s, e) => { label1.Text = webView.CoreWebView2.DocumentTitle; };
            webView.CoreWebView2.FaviconChanged += async (s, e) =>
            {
                using (var wc = new HttpClient())
                {
                    Bitmap bitmap;
                    try
                    {
                        var stream = await wc.GetByteArrayAsync(webView.CoreWebView2.FaviconUri);//wc.OpenRead(webView.CoreWebView2.FaviconUri);
                        bitmap = new Bitmap(new MemoryStream(stream));
                    }
                    catch
                    {
                        bitmap = new(64, 64);
                    }
                    bitmap = new Bitmap(bitmap, new(24, 24));
                    pictureBox1.Image = bitmap;
                }
            };
            webView.CoreWebView2.NewWindowRequested += (s, e) =>
            {
                e.Handled = true;
                Process.Start(Application.ExecutablePath, $"{e.Uri}");
            };
        }

        private void DockShowButton_Click(object sender, EventArgs e)
        {
            if (DockShowButton.Text == "↓")
            {
                panel2.Visible = true;
                DockShowButton.Text = "↑";
            }
            else
            if (DockShowButton.Text == "↑")
            {
                panel2.Visible = false;
                DockShowButton.Text = "↓";
            }

            button4.Visible = !panel2.Visible;
            button5.Visible = !panel2.Visible;
            button6.Visible = !panel2.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://www.google.co.jp/");
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://news.yahoo.co.jp/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://news.livedoor.com/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                //枠だけのフォーム
                CreateParams cp = base.CreateParams;
                if (this.FormBorderStyle != FormBorderStyle.None)
                {
                    cp.Style = cp.Style & (~0x00800000);
                }
                return cp;
            }
        }
        private static class Win32Api
        {

            #region SendMessage

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

            #endregion

            #region ReleaseCapture

            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool ReleaseCapture();

            #endregion

            #region MouseLeftDownOnFormTitleBar
            /// <summary>
            /// タイトルバーを左クリックする
            /// </summary>
            /// <param name="frm">対象のフォーム</param>
            public static void MouseLeftDownOnFormTitleBar(System.Windows.Forms.Form frm)
            {
                ReleaseCapture();
                SendMessage(frm.Handle, (int)0x00A1, new IntPtr(0x0002), IntPtr.Zero);
            }
            public static void MouseLeftDownOnFormSize(System.Windows.Forms.Form frm)
            {
                ReleaseCapture();
                SendMessage(frm.Handle, (int)0xF008, new IntPtr(0x0002), IntPtr.Zero);
            }
            #endregion

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Win32Api.MouseLeftDownOnFormTitleBar(this);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Win32Api.MouseLeftDownOnFormSize(this);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) FormBorderStyle = FormBorderStyle.Sizable;
            else FormBorderStyle = FormBorderStyle.None;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = $"{sw.Elapsed:h\\:mm\\:ss\\:ff}";
        }
    }
}