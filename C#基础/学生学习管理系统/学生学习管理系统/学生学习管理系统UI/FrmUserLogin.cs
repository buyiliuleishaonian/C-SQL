using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 学生学习管理系统.BLL;
using 学生学习管理系统.Model;
using 学生学习管理系统.Common;
using 学生学习管理系统UI;

namespace StudentManager
{
    public partial class FrmUserLogin : Form
    {
        public FrmUserLogin()
        {
            InitializeComponent();
            this.txtLoginId.Focus();
        }

        //登录
        /// <summary>
        /// 登入账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //1、验证数据
            //先判断是否输入用户名和密码
            if (this.txtLoginId.Text==null)
            {
                MessageBox.Show("请输入用户名");
            }
            //利用正则函数判断输入是否是正整数
            if (!DataValidate.IsInteger(this.txtLoginId.Text.Trim()))
            {
                MessageBox.Show("请输入正整数");
            }
            if (this.txtLoginPwd.Text == null)
            {
                MessageBox.Show("请输入密码");
            }
            //登入账号和密码不能包含敏感字符，要是不想要敏感字符，就在DAL层，参数化

            //2、封装对象(包含要提交的数据)
            //创建管理员类的对象
            AdmisModel ModeL = new AdmisModel();
            ModeL.LogInId=Convert.ToInt32(this.txtLoginId.Text);
            ModeL.Logirpwd = this.txtLoginPwd.Text;
            //3、和后台交互，BLL
            //需要验证返回值
            Program.adminModel= AdminBLL.GetUser(ModeL);
            //4、处理交互结果，需要保存数据，需要返回值
            if (Program.adminModel != null)//登入成功，关闭登入窗体，显示主窗体
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入正确的用户名和密码");
            }
        }
          
        //关闭
        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// 当输入用户名完毕之后tab进入下一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLoginId_KeyDown(object sender, KeyEventArgs e)
        {
            //这里的13代表tab键
            if (this.txtLoginId.Text.Trim().Length!=0 && e.KeyValue==13)
            {
                this.txtLoginPwd.Focus();//聚焦到控件上
                this.txtLoginPwd.SelectAll();//包含所有的文本
            }
        }

        /// <summary>
        /// 输入密码之后通过tab键到登入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txLoginPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtLoginPwd.Text.Trim().Length!=0 && e.KeyValue==13)
            {
                this.btnLogin.Focus();
            }
        }
    }
}
