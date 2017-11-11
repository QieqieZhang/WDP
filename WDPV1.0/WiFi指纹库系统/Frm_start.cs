using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WiFi指纹库系统
{
    public partial class Frm_start : Form
    {
        public Frm_start()
        {
            InitializeComponent();
        }

        private void Frm_start_Load(object sender, EventArgs e)
        {
            //const string showInfo = "欢迎使用指纹库系统V1.0，请稍后...";
           // C:\Users\dell\Desktop\WiFi指纹库系统\WiFi指纹库软件V1.0师兄版\WiFi指纹库系统带加载图片版\WiFi指纹库系统\Resources\Start.bmp
            //AppDomain.CurrentDomain.BaseDirectory+@"..\..\Resources\Strat.bmp
            this.FormBorderStyle = FormBorderStyle.None;  //设置启动窗体为无标题栏窗体 
            this.BackgroundImage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory+@"..\..\Resources\Start.bmp");//设置启动窗体的背景图片  
            this.BackgroundImageLayout = ImageLayout.Stretch;//设置图片自动适应窗体大小  
            
            this.timer1.Start();//启动计时器  
            this.timer1.Interval = 3000;//设置启动窗体的停留时间  
            this.label1.Text = "WiFi/蓝牙指纹库处理软件V1.0";
            this.label1.BackColor = Color.Transparent;
            this.label2.Text = "版本V1.0";
            this.label2.BackColor = Color.Transparent;
            this.pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\Resources\StartCursor.bmp");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
