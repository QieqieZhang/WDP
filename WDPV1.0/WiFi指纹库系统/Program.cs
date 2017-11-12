using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WiFi指纹库系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_start());//启动界面一定要在主窗体之前  
            Application.Run(new FormMain());
        }
    }
}
