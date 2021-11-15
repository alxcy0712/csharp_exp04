namespace LxcApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.柳笑辰的GithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.柳笑辰的个人网站ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.画图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.示例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自由画图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.画图ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.柳笑辰的GithubToolStripMenuItem,
            this.柳笑辰的个人网站ToolStripMenuItem});
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.显示ToolStripMenuItem.Text = "显示";
            // 
            // 柳笑辰的GithubToolStripMenuItem
            // 
            this.柳笑辰的GithubToolStripMenuItem.Name = "柳笑辰的GithubToolStripMenuItem";
            this.柳笑辰的GithubToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.柳笑辰的GithubToolStripMenuItem.Text = "柳笑辰的Github";
            this.柳笑辰的GithubToolStripMenuItem.Click += new System.EventHandler(this.柳笑辰的GithubToolStripMenuItem_Click);
            // 
            // 柳笑辰的个人网站ToolStripMenuItem
            // 
            this.柳笑辰的个人网站ToolStripMenuItem.Name = "柳笑辰的个人网站ToolStripMenuItem";
            this.柳笑辰的个人网站ToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.柳笑辰的个人网站ToolStripMenuItem.Text = "柳笑辰的个人网站";
            this.柳笑辰的个人网站ToolStripMenuItem.Click += new System.EventHandler(this.柳笑辰的个人网站ToolStripMenuItem_Click);
            // 
            // 画图ToolStripMenuItem
            // 
            this.画图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.示例ToolStripMenuItem,
            this.自由画图ToolStripMenuItem});
            this.画图ToolStripMenuItem.Name = "画图ToolStripMenuItem";
            this.画图ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.画图ToolStripMenuItem.Text = "画图";
            // 
            // 示例ToolStripMenuItem
            // 
            this.示例ToolStripMenuItem.Name = "示例ToolStripMenuItem";
            this.示例ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.示例ToolStripMenuItem.Text = "示例";
            this.示例ToolStripMenuItem.Click += new System.EventHandler(this.示例ToolStripMenuItem_Click);
            // 
            // 自由画图ToolStripMenuItem
            // 
            this.自由画图ToolStripMenuItem.Name = "自由画图ToolStripMenuItem";
            this.自由画图ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.自由画图ToolStripMenuItem.Text = "自由画图";
            this.自由画图ToolStripMenuItem.Click += new System.EventHandler(this.自由画图ToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 31);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(882, 523);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "清屏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 488);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.VisibleChanged += new System.EventHandler(this.pictureBox1_VisibleChanged);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 柳笑辰的GithubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 柳笑辰的个人网站ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 画图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 示例ToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem 自由画图ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

