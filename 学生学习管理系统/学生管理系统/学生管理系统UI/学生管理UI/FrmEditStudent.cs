using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using 学生学习管理DAL;
using 学生管理Model;
using 学生管理系统Common;

namespace 学生管理UI
{
    public partial class FrmEditStudent : Form
    {
        private ClassDAL ClassDAL = new ClassDAL();
        List<ClassinfosModel> listclas = new List<ClassinfosModel>();
        private StudentDAL studal = new StudentDAL();
        public FrmEditStudent()
        {
            InitializeComponent();
            this.listclas= ClassDAL.GetClass();
            this.cboClassName.DataSource =this. listclas;
            this.cboClassName.ValueMember = "classid";
            this.cboClassName.DisplayMember="classname";
            this.cboClassName.SelectedIndex = -1;
        }
        /// <summary>
        /// 将学生的详细情况放入窗体
        /// </summary>
        /// <param name="stu"></param>
        public FrmEditStudent(StudentsinfosModel stu) : this()
        {
            //通过构造函数将所有的数据全部放入其中
            this.txtStudentName.Text=stu.Studentname;
            if (stu.Gender=="男")
            { this.rdoMale.Checked=true; }
            else
            { this.rdoFemale.Checked=true; }
            this.txtStudentId.Text= stu.Studentid.ToString();
            this.dtpBirthday.Text=stu.Birthday.ToShortDateString();
            this.txtStudentIdNo.Text=stu.Studentidno;
            this.txtCardNo.Text=stu.Cardno;
            this.cboClassName.Text=stu.ClassName;
            this.txtPhoneNumber.Text=stu.Phonenumber;
            this.txtAddress.Text=stu.Studentaddress;
            this.pbStu.Image=stu.Stuimage=="" ? Image.FromFile("图片1.png") : (Image)new SerializeObjectToString().DeserializeObject(stu.Stuimage);

            this.txtStudentId.Enabled=false;
        }
        public bool ISEmpty(string text, string name)
        {
            if (text.Trim().Length==0)
            {
                MessageBox.Show($"{name}为空", "提示信息");
                return true;
            }
            else
            {
                return false;
            }
        }

        //提交修改
        private void btnModify_Click(object sender, EventArgs e)
        {
            //在修改之前，需要判断是否为空
            #region 添加学员之前的判断
            //在添加学员之前，需要确保，姓名，身份证，手机号，
            //并且确保身份证号和身份证号码是相同的。
            //判断姓名
            if (this.txtStudentName.Text.Trim().Length==0)
            {
                MessageBox.Show("没有输入姓名","提示休息");
                return;
            }
            //判断性别
            if (this.rdoMale.Checked==false && this.rdoFemale.Checked==false)
            {
                MessageBox.Show("没有选择性别", "提示信息");
                return;
            }

            //判断班级是否为空
            if (this.cboClassName.SelectedIndex==-1)
            {
                MessageBox.Show("没有选择班级", "提示信息");
                this.cboClassName.Focus();
                return;
            }

            //需要判断身份证号是空
            if (this.txtStudentIdNo.Text.Trim().Length==0)
            {
                MessageBox.Show("身份证为空", "提示休息");
                return;
            }

            //还需要判断身份证信息是正整数
            if (!DataValidate.IsInteger(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("身份证不是正整数", "提示信息");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //判断身份证上的出生日期和选择的生日是否一样
            string time = Convert.ToDateTime(this.dtpBirthday.Text).ToString("yyyyMMdd");
            if (!this.txtStudentIdNo.Text.Contains(time))
            {
                MessageBox.Show("身份证和选择的出生日期，不匹配", "提示信息");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //判断身份证是否长度满足要求
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("身份证长度不够", "提示信息");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //判断年纪是否满足18~35岁
            int age = DateTime.Now.Year-Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age<18 ||age>35)
            {
                MessageBox.Show("年龄超过要求", "提示信息");
                return;
            }

            //家庭住址不能为空
            if (this.txtAddress.Text.Trim().Length==0)
            {
                MessageBox.Show("家庭地址为空", "提示休息");
                return;
            }

            //考勤卡号，不能为空，并且为正整数
            if (this.txtCardNo.Text.Trim().Length==0)
            {
                MessageBox.Show("考勤卡号为空", "提示休息");
                return;
            }

            //电话号码不能为空
            if (this.txtPhoneNumber.Text.Trim().Length==0)
            {
                MessageBox.Show("电话号码不能为空","提示休息");
                return;
            }
            //不能电话为非正整数
            if (!DataValidate.IsInteger(this.txtPhoneNumber.Text.Trim()))
            {
                MessageBox.Show("卡号不是正整数", "提示信息");
                this.txtPhoneNumber.SelectAll();
                this.txtPhoneNumber.Focus();
                return;
            }
            #endregion
            //修改之后的考勤卡号和身份证号是否存在
            if (studal.SelectStuORCard(this.txtCardNo.Text,this.txtStudentIdNo.Text)!=null)
            {
                MessageBox.Show("修改的卡号或者身份证号，已经存在于数据库中");
                return;
            }
            int nums= studal.UpdateStu(Convert.ToInt32( this.txtStudentId.Text));
            if (nums!=0)
            {
                MessageBox.Show("修改成功", "成功");
                return;
            }
            else
            {
                MessageBox.Show("修改失败", "失败");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //选择照片
        private void btnChoseImage_Click(object sender, EventArgs e)
        {

        }
    }
}