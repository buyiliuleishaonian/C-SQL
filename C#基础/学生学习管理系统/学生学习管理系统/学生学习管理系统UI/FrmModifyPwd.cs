using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 学生学习管理系统UI;
using 学生学习管理系统.BLL;
using 学生学习管理系统.Model;
namespace StudentManager
{
    public partial class FrmModifyPwd : Form
    {
        public FrmModifyPwd()
        {
            InitializeComponent();
            
        }
        //修改密码
        /// <summary>
        /// 验证旧密码，修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            # region    验证密码

            //1、判断旧密码不能为空
            if (this.txtOldPwd.Text == null)
            {
                MessageBox.Show("旧密码输入错误");
                this.txtOldPwd.Focus();
                return;
            }
            //2、判断旧密码的正确性
            if (this.txtOldPwd.Text!=Program.adminModel.Logirpwd)
            {
                MessageBox.Show("旧密码输入错误");
                this.txtOldPwd.Text = null;
                this.txtOldPwd.Focus();
                return;
            }
            //3、判断新密码长度
            if(this.txtNewPwd.Text.Length<6)
            {
                MessageBox.Show("新密码长度太短，不安全");
                this.txtNewPwd.Focus();
                return;
            }
            //4、判断两次输入新密码的正确性
            if (this.txtNewPwd.Text!=this.txtNewPwdConfirm.Text)
            {
                MessageBox.Show("两次新密码输入不对");
                this.txtNewPwdConfirm.Focus();
                return;
            }
            //5、新密码和旧密码一样
            if (this.txtOldPwd.Text==this.txtNewPwd.Text)
            {
                MessageBox.Show("旧密码和新密码一样，请修改新密码");
                this.txtNewPwd.Focus();
                return;
            }

            #endregion

            //修改密码
            try
            {
                //得到sql修改语句 限制的用户名
                AdmisModel adminModel = new AdmisModel()
                {
                    AdminName = Program.adminModel.AdminName,
                    Logirpwd = this.txtNewPwd.Text.Trim()
                };
                //调用BLL，执行修改
                if (AdminBLL.GetPwd(adminModel)==1)
                {
                    MessageBox.Show("修改成功");
                    Program.adminModel.Logirpwd=this.txtNewPwd.Text;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 当输入就旧密码之后按下tab键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOldPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtOldPwd.Text.Trim().Length != 0 && e.KeyValue==13)
            {
                this.txtNewPwd.Focus();
                this.txtNewPwd.SelectAll();
            }
        }
        /// <summary>
        /// 当第一次输入新密码时，按下tab键往下进行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNewPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtNewPwd.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.txtNewPwdConfirm.Focus();
                this.txtNewPwdConfirm.SelectAll();
            }
        }

        /// <summary>
        /// 确认新密码之后，按下tab键等修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNewPwdConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtNewPwdConfirm.Text.Trim().Length != 0 && e.KeyValue == 13)
            {
                this.btnModify.Focus();
            }
        }

    }
}
