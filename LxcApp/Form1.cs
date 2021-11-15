using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxcApp
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap btmp;
        Point pt1, pt2;
        Pen mypen = new Pen(Color.Black, 3);
        bool is_pen_down = false;
        bool is_pen_up = true;
        bool is_first_point = true;



        public Form1()
        {
            InitializeComponent();
            button1.Hide();
            pictureBox1.Hide();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void 柳笑辰的GithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //显示webBrowser组件
            webBrowser1.Show();
            //隐藏按钮
            button1.Hide();
            //隐藏图片层
            pictureBox1.Hide();
            //跳转页面
            webBrowser1.Navigate("https://www.github.com/liuxiaochen712");
        }

        private void 柳笑辰的个人网站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Show();
            button1.Hide();
            pictureBox1.Hide();
            webBrowser1.Navigate("http://www.alxcy.xyz:8080");
        }

        private void 示例ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Hide();
            button1.Hide();
            pictureBox1.Hide();
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Black,8);
            //柳 第一笔 横
            Point p1 = new Point(100, 120);
            Point p2 = new Point(180, 120);
            graphics.DrawLine(pen, p1, p2);
            //柳 第二笔 竖
            p1.X = 140;p1.Y = 80;
            p2.X = 140;p2.Y = 300;
            graphics.DrawLine(pen, p1, p2);
            //柳 第三笔 撇
            p1.X = 140;p1.Y = 120;
            p2.X = 100; p2.Y = 250;
            graphics.DrawLine(pen, p1, p2);
            //柳 第四笔 捺
            p1.X = 140;p1.Y = 120;
            p2.X = 180;p2.Y = 250;
            graphics.DrawLine(pen, p1, p2);
            //柳 第五笔 撇
            p1.X = 180; p1.Y = 90;
            p2.X = 215; p2.Y = 80;
            graphics.DrawLine(pen, p1, p2);
            //柳 第六笔1 竖
            p1.X = 182;p1.Y = 89;
            p2.X = 182;p2.Y = 250;
            graphics.DrawLine(pen, p1, p2);
            //柳 第六笔2 提
            p1.X = 182;p1.Y = 250;
            p2.X = 215;p2.Y = 240;
            graphics.DrawLine(pen, p1, p2);
            //柳 第七笔1 竖
            p1.X = 215;p1.Y = 170;
            p2.X = 215;p2.Y = 288;
            graphics.DrawLine(pen, p1, p2);
            //柳 第七笔2 撇
            p1.X = 215;p1.Y = 285;
            p2.X = 182;p2.Y = 300;
            graphics.DrawLine(pen, p1, p2);
            //柳 第八笔1 横
            p1.X = 220;p1.Y = 125;
            p2.X = 290;p2.Y = 125;
            graphics.DrawLine(pen, p1, p2);
            //柳 第八笔2 竖
            p1.X = 288;p1.Y = 123;
            p2.X = 288;p2.Y = 252;
            graphics.DrawLine(pen, p1, p2);
            //柳 第八笔3 提
            p1.X = 288;p1.Y = 248;
            p2.X = 260;p2.Y = 230;
            graphics.DrawLine(pen, p1, p2);
            //柳 第九笔 竖
            p1.X = 245;p1.Y = 125;
            p2.X = 245;p2.Y = 300;
            graphics.DrawLine(pen, p1, p2);
        }

        private void 自由画图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //清屏
            webBrowser1.Hide();
            pictureBox1.Show();
            button1.Show();
            g = this.CreateGraphics();
            //清空绘图区域
            g.Clear(this.BackColor);
            g.Dispose();
            
        }


        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //清屏
            webBrowser1.Hide();
            Graphics g = this.CreateGraphics() ;
            //清空绘图区域
            g.Clear(this.BackColor);
            g.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //鼠标左键按下
            is_pen_down = true;
            is_first_point = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //鼠标左键释放
            is_pen_down = false;
            is_pen_up = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //鼠标移动 绘制
            if (is_first_point)
            {
                //将第一次的落点 标记并清除
                pt1 = new Point(e.X, e.Y);
                is_first_point = false;
            }
            if (is_pen_down)
            {
                //笔落下时拖动绘制线段
                pt2 = new Point(e.X, e.Y);
                g.DrawLine(mypen, pt1, pt2);
                pt1 = pt2;
                pictureBox1.Image = btmp;
            }
        }

        private void pictureBox1_VisibleChanged(object sender, EventArgs e)
        {
            //当可见性改变时 进行初始化操作
            btmp = new Bitmap(pictureBox1.Width, pictureBox1.Height) ;
            g = Graphics.FromImage(btmp);
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
