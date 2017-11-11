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
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //直接读取文件
            this.openFileDialog1.ShowDialog();
            string MyFileName = this.openFileDialog1.FileName;
            if (MyFileName.Trim() == "")
                return;
            StreamReader MyReader = null;
            try
            {
                MyReader = new StreamReader(MyFileName, System.Text.Encoding.Default);
                this.richTextBox1.Text = MyReader.ReadToEnd();
            }
            catch (Exception Err)
            {
                MessageBox.Show("读取文件发生错误！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            finally
            {
                if (MyReader != null)
                {
                    MyReader.Close();
                }
            }
        }

       /* private void button7_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                myfile = saveFileDialog1.FileName;
            }
            StreamWriter Writer = new StreamWriter(myfile, false, Encoding.Default);
            try
            {
                foreach (string line in richTextBox1.Lines)
                {
                    Writer.Write(line + "\n", Encoding.Default);

                }
                Writer.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存文件失败！" + ex.Message);
            }
            finally
            {
                Writer.Close();
            }
        }*/

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 曲面ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            w1.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tsslTime.Text = "||登录时间:" + System.DateTime.Now.ToLongDateString() + "" + System.DateTime.Now.ToLongTimeString();
            tsslName.Text = "||版权：北京航空航天大学（数字导航中心）";
            tsslWeb.Text = "||网址：www.dnc.buaa.edu.cn";
            w1 = new frmLogin();
            
            
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

        private void 生成指纹库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                myfile = saveFileDialog1.FileName;
            }
            StreamWriter Writer = new StreamWriter(myfile, false, Encoding.Default);
            try
            {
                foreach (string line in richTextBox1.Lines)
                {
                    Writer.Write(line + "\n", Encoding.Default);

                }
                Writer.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存文件失败！" + ex.Message);
            }
            finally
            {
                Writer.Close();
            }
        }
    }

}