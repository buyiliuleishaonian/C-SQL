using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 学生学习管理DAL;

namespace StudentManager
{
    public partial class FrmModifyPwd : Form
    {
        private AdminDAL adminDAL=new AdminDAL();
        public FrmModifyPwd()
        {
            InitializeComponent();
        }
        //修改密码
        private void btnModify_Click(object sender, EventArgs e)
        {
            //修改密码，。需要先判断是否有输入旧密码，新密码，确认新密码
            //而且旧密码不可以和新密码想通过
            if (this.txtOldPwd.Text.Trim().Length==0)
            {
                MessageBox.Show("请输旧密码","提示信息");
                this.txtOldPwd.SelectAll();
                this.txtOldPwd.Focus();
                return;
            }
            if (this.txtNewPwd.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入新密码","提示信息");
                this.txtNewPwd.SelectAll(); 
                this.txtNewPwd.Focus();
                return;
            }
            if (this.txtNewPwdConfirm.Text.Trim().Length==0)
            {
                MessageBox.Show("请确认输入新密码", "提示信息");
                this.txtNewPwdConfirm.SelectAll();
                this.txtNewPwdConfirm.Focus();
                return;
            }
            if (this.txtNewPwd.Text==this.txtOldPwd.Text)
            {
                MessageBox.Show("旧密码和新密码重复，请修改新密码","提示信息");
                this.txtNewPwd.Text = null;
                this.txtNewPwd.Focus();
                return;
            }
            if (this.txtNewPwd.Text!=this.txtNewPwdConfirm.Text)
            {
                MessageBox.Show("新密码确认失败,请确认两次新密码是否输入相同","提示信息");
                this.txtNewPwd.Text = null;
                this.txtNewPwdConfirm.Text= null;
                this.txtNewPwd.Focus();
                return;
            }
            int number= adminDAL.UpdateAdmin(this.txtOldPwd.Text,this.txtNewPwd.Text,Program.admins.Username);
            if (number!=0)
            {
                MessageBox.Show("修改成功","提示信息");
                this.txtOldPwd.Text = null;
                this.txtNewPwd.Text = null;
                this.txtNewPwdConfirm.Text = null;
                return;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
