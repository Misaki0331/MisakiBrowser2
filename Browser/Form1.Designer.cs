namespace Browser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            ReloadButton = new Button();
            URIBox = new TextBox();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            NextButton = new Button();
            BackButton = new Button();
            DockShowButton = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel2 = new Panel();
            label1 = new Label();
            checkBox1 = new CheckBox();
            MinimizeButton = new Button();
            MaximizeButton = new Button();
            CloseButton = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ReloadButton);
            panel1.Controls.Add(URIBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(NextButton);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(DockShowButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 38);
            panel1.TabIndex = 0;
            // 
            // ReloadButton
            // 
            ReloadButton.Dock = DockStyle.Right;
            ReloadButton.Location = new Point(879, 0);
            ReloadButton.Margin = new Padding(4, 5, 4, 5);
            ReloadButton.Name = "ReloadButton";
            ReloadButton.Size = new Size(76, 38);
            ReloadButton.TabIndex = 2;
            ReloadButton.Text = "Reload";
            ReloadButton.UseVisualStyleBackColor = true;
            ReloadButton.Click += ReloadButton_Click;
            // 
            // URIBox
            // 
            URIBox.Dock = DockStyle.Fill;
            URIBox.Location = new Point(160, 0);
            URIBox.Margin = new Padding(4, 5, 4, 5);
            URIBox.Name = "URIBox";
            URIBox.Size = new Size(795, 31);
            URIBox.TabIndex = 3;
            URIBox.KeyDown += URIBox_KeyDown;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Right;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(955, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 38);
            label2.TabIndex = 3;
            label2.Text = "0:00:00.00";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.MouseDown += label1_MouseDown;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Right;
            button4.Font = new Font("メイリオ", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(1041, 0);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(34, 38);
            button4.TabIndex = 10;
            button4.Text = "＿";
            button4.UseVisualStyleBackColor = true;
            button4.Click += MinimizeButton_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Right;
            button5.Font = new Font("メイリオ", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(1075, 0);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(34, 38);
            button5.TabIndex = 9;
            button5.Text = "□";
            button5.UseVisualStyleBackColor = true;
            button5.Click += MaximizeButton_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Right;
            button6.Font = new Font("メイリオ", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(1109, 0);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(34, 38);
            button6.TabIndex = 8;
            button6.Text = "×";
            button6.UseVisualStyleBackColor = true;
            button6.Click += CloseButton_Click;
            // 
            // NextButton
            // 
            NextButton.Dock = DockStyle.Left;
            NextButton.Location = new Point(97, 0);
            NextButton.Margin = new Padding(4, 5, 4, 5);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(63, 38);
            NextButton.TabIndex = 1;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // BackButton
            // 
            BackButton.Dock = DockStyle.Left;
            BackButton.Location = new Point(34, 0);
            BackButton.Margin = new Padding(4, 5, 4, 5);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(63, 38);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // DockShowButton
            // 
            DockShowButton.Dock = DockStyle.Left;
            DockShowButton.Location = new Point(0, 0);
            DockShowButton.Margin = new Padding(4, 5, 4, 5);
            DockShowButton.Name = "DockShowButton";
            DockShowButton.Size = new Size(34, 38);
            DockShowButton.TabIndex = 4;
            DockShowButton.Text = "↓";
            DockShowButton.UseVisualStyleBackColor = true;
            DockShowButton.Click += DockShowButton_Click;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 78);
            webView.Margin = new Padding(4, 5, 4, 5);
            webView.Name = "webView";
            webView.Size = new Size(1143, 672);
            webView.Source = new Uri("https://google.com", UriKind.Absolute);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            webView.CoreWebView2InitializationCompleted += webView_CoreWebView2InitializationCompleted;
            webView.NavigationStarting += webView_NavigationStarting;
            webView.NavigationCompleted += webView_NavigationCompleted;
            webView.WebMessageReceived += webView_WebMessageReceived;
            webView.SourceChanged += webView_SourceChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(MinimizeButton);
            panel2.Controls.Add(MaximizeButton);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 40);
            panel2.TabIndex = 2;
            panel2.Visible = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(400, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(566, 40);
            label1.TabIndex = 3;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            label1.MouseDown += label1_MouseDown;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Right;
            checkBox1.Location = new Point(966, 0);
            checkBox1.Margin = new Padding(4, 5, 4, 5);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 40);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Border";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Dock = DockStyle.Right;
            MinimizeButton.Font = new Font("メイリオ", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MinimizeButton.Location = new Point(1041, 0);
            MinimizeButton.Margin = new Padding(4, 5, 4, 5);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(34, 40);
            MinimizeButton.TabIndex = 7;
            MinimizeButton.Text = "＿";
            MinimizeButton.UseVisualStyleBackColor = true;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // MaximizeButton
            // 
            MaximizeButton.Dock = DockStyle.Right;
            MaximizeButton.Font = new Font("メイリオ", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeButton.Location = new Point(1075, 0);
            MaximizeButton.Margin = new Padding(4, 5, 4, 5);
            MaximizeButton.Name = "MaximizeButton";
            MaximizeButton.Size = new Size(34, 40);
            MaximizeButton.TabIndex = 6;
            MaximizeButton.Text = "□";
            MaximizeButton.UseVisualStyleBackColor = true;
            MaximizeButton.Click += MaximizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Dock = DockStyle.Right;
            CloseButton.Font = new Font("メイリオ", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(1109, 0);
            CloseButton.Margin = new Padding(4, 5, 4, 5);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(34, 40);
            CloseButton.TabIndex = 5;
            CloseButton.Text = "×";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(366, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(230, 0);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(136, 40);
            button3.TabIndex = 2;
            button3.Text = "LiveDoor News";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(107, 0);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(123, 40);
            button2.TabIndex = 1;
            button2.Text = "Yahoo! News";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 40);
            button1.TabIndex = 0;
            button1.Text = "Google";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(webView);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox URIBox;
        private Button ReloadButton;
        private Button NextButton;
        private Button BackButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Button DockShowButton;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button MinimizeButton;
        private Button MaximizeButton;
        private Button CloseButton;
        private CheckBox checkBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}