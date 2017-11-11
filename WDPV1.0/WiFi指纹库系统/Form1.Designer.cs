namespace WiFi指纹库系统
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入原始数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入楼层图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成指纹库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成测试报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.双线性法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高斯过程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.曲面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.广义延拓ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反距离法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslWeb = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(208, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 474);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox1.Location = new System.Drawing.Point(6, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(599, 454);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(12, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 474);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numericUpDown4);
            this.groupBox6.Controls.Add(this.numericUpDown3);
            this.groupBox6.Location = new System.Drawing.Point(23, 200);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(132, 49);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "阈值参数";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(71, 21);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(55, 21);
            this.numericUpDown4.TabIndex = 1;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(7, 21);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(55, 21);
            this.numericUpDown3.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown2);
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Location = new System.Drawing.Point(23, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(132, 51);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RSSI强度范围";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(71, 21);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 21);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(7, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 21);
            this.numericUpDown1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox3);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Location = new System.Drawing.Point(23, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(132, 48);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "设置点距";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(71, 21);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(55, 20);
            this.comboBox3.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(7, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(55, 20);
            this.comboBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 50);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择插值方法";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 40);
            this.button5.TabIndex = 2;
            this.button5.Text = "生成指纹库";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(23, 409);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(132, 40);
            this.button8.TabIndex = 5;
            this.button8.Text = "更新指纹库";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "导入原始数据";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "文本文件（*.txt）|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "文本文件（*.txt）|*.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助HToolStripMenuItem,
            this.帮助HToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入原始数据ToolStripMenuItem,
            this.导入楼层图ToolStripMenuItem,
            this.生成指纹库ToolStripMenuItem,
            this.生成测试报告ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 导入原始数据ToolStripMenuItem
            // 
            this.导入原始数据ToolStripMenuItem.Name = "导入原始数据ToolStripMenuItem";
            this.导入原始数据ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.导入原始数据ToolStripMenuItem.Text = "打开(O)";
            // 
            // 导入楼层图ToolStripMenuItem
            // 
            this.导入楼层图ToolStripMenuItem.Name = "导入楼层图ToolStripMenuItem";
            this.导入楼层图ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.导入楼层图ToolStripMenuItem.Text = "关闭(C)";
            // 
            // 生成指纹库ToolStripMenuItem
            // 
            this.生成指纹库ToolStripMenuItem.Name = "生成指纹库ToolStripMenuItem";
            this.生成指纹库ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.生成指纹库ToolStripMenuItem.Text = "保存(S)";
            this.生成指纹库ToolStripMenuItem.Click += new System.EventHandler(this.生成指纹库ToolStripMenuItem_Click);
            // 
            // 生成测试报告ToolStripMenuItem
            // 
            this.生成测试报告ToolStripMenuItem.Name = "生成测试报告ToolStripMenuItem";
            this.生成测试报告ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.生成测试报告ToolStripMenuItem.Text = "退出(X)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.双线性法ToolStripMenuItem,
            this.高斯过程ToolStripMenuItem,
            this.曲面ToolStripMenuItem,
            this.广义延拓ToolStripMenuItem,
            this.反距离法ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.帮助HToolStripMenuItem.Text = "操作(&A)";
            // 
            // 双线性法ToolStripMenuItem
            // 
            this.双线性法ToolStripMenuItem.Name = "双线性法ToolStripMenuItem";
            this.双线性法ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.双线性法ToolStripMenuItem.Text = "双线性法";
            // 
            // 高斯过程ToolStripMenuItem
            // 
            this.高斯过程ToolStripMenuItem.Name = "高斯过程ToolStripMenuItem";
            this.高斯过程ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.高斯过程ToolStripMenuItem.Text = "高斯过程";
            // 
            // 曲面ToolStripMenuItem
            // 
            this.曲面ToolStripMenuItem.Name = "曲面ToolStripMenuItem";
            this.曲面ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.曲面ToolStripMenuItem.Text = "曲面拟合";
            this.曲面ToolStripMenuItem.Click += new System.EventHandler(this.曲面ToolStripMenuItem_Click);
            // 
            // 广义延拓ToolStripMenuItem
            // 
            this.广义延拓ToolStripMenuItem.Name = "广义延拓ToolStripMenuItem";
            this.广义延拓ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.广义延拓ToolStripMenuItem.Text = "广义延拓";
            // 
            // 反距离法ToolStripMenuItem
            // 
            this.反距离法ToolStripMenuItem.Name = "反距离法ToolStripMenuItem";
            this.反距离法ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.反距离法ToolStripMenuItem.Text = "反距离法";
            // 
            // 帮助HToolStripMenuItem1
            // 
            this.帮助HToolStripMenuItem1.Name = "帮助HToolStripMenuItem1";
            this.帮助HToolStripMenuItem1.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem1.Text = "帮助(&H)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslTime,
            this.tsslName,
            this.tsslWeb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(831, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked_1);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tsslTime
            // 
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(131, 17);
            this.tsslTime.Text = "toolStripStatusLabel2";
            this.tsslTime.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // tsslName
            // 
            this.tsslName.Name = "tsslName";
            this.tsslName.Size = new System.Drawing.Size(131, 17);
            this.tsslName.Text = "toolStripStatusLabel2";
            // 
            // tsslWeb
            // 
            this.tsslWeb.Name = "tsslWeb";
            this.tsslWeb.Size = new System.Drawing.Size(131, 17);
            this.tsslWeb.Text = "toolStripStatusLabel2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 527);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WiFi/蓝牙指纹库处理软件V1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入原始数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入楼层图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成指纹库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成测试报告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 双线性法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高斯过程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 曲面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 广义延拓ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反距离法ToolStripMenuItem;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslName;
        private System.Windows.Forms.ToolStripStatusLabel tsslWeb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}

