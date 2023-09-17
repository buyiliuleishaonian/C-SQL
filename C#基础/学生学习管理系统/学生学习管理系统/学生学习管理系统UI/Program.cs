using StudentManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using 学生学习管理系统.Model;
namespace 学生学习管理系统UI
{

    internal static class Program
    {
        /// <summary>
        /// 建立全局的管理员对象
        /// </summary>
        public static AdmisModel adminModel =new AdmisModel();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //首先显示登入窗体,在使用窗体显示时，使用showdialog方法
            FrmUserLogin frmUserLogin=new FrmUserLogin();
            DialogResult  diaresult=frmUserLogin.ShowDialog();
            if (diaresult == DialogResult.OK)
            {
                //窗体登入之后需要判断，登入是否成功
                Application.Run(new FrmMain());
            }
            else
            {
                //如果关闭窗体，就将所有的程序关闭
                Application.Exit();
            }
        }
    }
}
