using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using 学生管理Model;

namespace StudentManager
{
   
    static class Program
    {
        //创建一个管理员信息,在登入页面需要显示
        public static AdminsModel admins = new AdminsModel();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmUserLogin frmuser=new    FrmUserLogin();
            DialogResult result = frmuser.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                //如果没有选择登入，则整个程序关闭
                Application.Exit();
            }
        }

    }
}
