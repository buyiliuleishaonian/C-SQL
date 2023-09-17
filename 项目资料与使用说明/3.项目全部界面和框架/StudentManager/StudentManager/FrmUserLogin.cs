using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 学生学习管理DAL;
using 学生管理Model;
using 学生管理系统Common;

namespace StudentManager
{
    public partial class FrmUserLogin : Form
    {
        private AdminDAL adm=new  AdminDAL();

        public FrmUserLogin()
        {
            InitializeComponent();
            this.txtLoginId.Focus();
        }

        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //登入之前需要判断是否,是否有输入信息
            if (this.txtLoginId.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入管理员的账号","提示信息");
                this.txtLoginId.Focus();
                return;
            }
            if (this.txLoginPwd.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入管理员的密码","提示信息");
                this.txLoginPwd.Focus();
                return;
            }
            //账号必须是正整数,通过二则表达式
            if (!DataValidate.IsInteger(this.txtLoginId.Text))
            {
                MessageBox.Show("请输入正整数的账户","提示信息");
                this.txtLoginId.Focus();
                this.txtLoginId.Text = null;
                return;
            }
            Program. admins = adm.GetAdmin(this.txtLoginId.Text,this.txLoginPwd.Text);
            if (Program.admins != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("登入失败，检查用户名或者密码是否正确","提示信息");
            }
        }
          
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// 当按下回车键，去到密码输入这一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLoginId_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtLoginId.Text.Trim().Length!=0 && e.KeyValue==13)
            {
                this.txLoginPwd.Focus();
                this.txLoginPwd.SelectAll();
                return;
            }
        }

        /// <summary>
        /// 按下回车键之后，去到登入按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txLoginPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txLoginPwd.Text.Trim().Length!=0 && e.KeyValue==13)
            {
                this.btnLogin.Focus();
                return;
            }
        }
    }
}
