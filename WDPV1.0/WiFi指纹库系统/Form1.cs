using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WiFi指纹库系统
{

    public partial class FormMain : Form
    {
        string myfile = "";
        public frmLogin w1;
        public static string[] filename;/*定义了一个全局变量存储文件路径*/

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            tsslTime.Text = "||登录时间:" + System.DateTime.Now.ToLongDateString() + "" + System.DateTime.Now.ToLongTimeString();
            tsslName.Text = "||版权：北京航空航天大学（数字导航中心）";
            tsslWeb.Text = "||网址：www.dnc.buaa.edu.cn";
            w1 = new frmLogin();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*导入原始数据*/
        private void button1_Click(object sender, EventArgs e)
        {
            /*打开对话框*/
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog.FileNames;
            }
        }
        /*生成指纹数据库*/
        private void button2_Click(object sender, EventArgs e)
        {
            string[] file = filename;
            switch (comboBox1.SelectedIndex)
            {

                case 0:/*高斯过程回归*/

                    break;
                case 1:/*双线性插值法*/

                    break;

                case 2:/*克里金插值法*/

                    break;
                case 3:/*广义延拓逼近*/

                    break;
                case 4:/*反距离权重法*/

                    break;

                default: break;
            }
        }

        /*更新数据库*/
        private void button3_Click(object sender, EventArgs e)
        {
            w1.Show();/*显示远程服务器登陆界面*/

            /*更新数据库至远程服务器*/
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 曲面ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }      

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        /*保存生成的指纹数据库文件*/
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
    }

}