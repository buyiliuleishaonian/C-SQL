using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 学生管理Model;
using 学生学习管理DAL;
using 学生管理系统Common;

namespace StudentManager
{
    public partial class FrmAddStudent : Form
    {
        //先要将所有班级信息读取到下拉款控件中
        private ClassDAL classDal = new ClassDAL();

        private StudentDAL studentDal = new StudentDAL();   

        private List<ClassinfosModel> listClass = new List<ClassinfosModel>();

        private List<StudentsinfosModel> stulist = new List<StudentsinfosModel>();
        public FrmAddStudent()
        {
            InitializeComponent();
            //在窗体创建时，就将班级信息存储在下拉框中
            listClass=classDal.GetClass();
            this.cboClassName.DataSource = listClass;
            this.cboClassName.ValueMember = "classid";//索引
            this.cboClassName.DisplayMember = "className";//索引对应的值
            this.cboClassName.SelectedIndex=-1;
            //不能自动生成行
            this.dataGridView1.AutoGenerateColumns = false;
        }
        //添加新学员
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 添加学员之前的判断
            //在添加学员之前，需要确保，姓名，身份证，手机号，
            //并且确保身份证号和身份证号码是相同的。
            //判断姓名
            if (ISEmpty(this.txtStudentName.Text, this.lblStudentName.Text))
            {
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
            if (ISEmpty(this.txtStudentIdNo.Text, this.lblStudentIDNO.Text))
            {
                return;
            }

            //还需要判断身份证信息是正整数
            if (!DataValidate.IsInteger(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("身份证不是正整数","提示信息");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //判断身份证上的出生日期和选择的生日是否一样
            string time =Convert.ToDateTime( this.dtpBirthday.Text).ToString("yyyyMMdd");
            if (!this.txtStudentIdNo.Text.Contains(time))
            {
                MessageBox.Show("身份证和选择的出生日期，不匹配","提示信息");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //判断身份证是否长度满足要求
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("身份证长度不够","提示信息");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //判断年纪是否满足18~35岁
            int age=DateTime.Now.Year-Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age<18 ||age>35)
            {
                MessageBox.Show("年龄超过要求","提示信息");
                return;
            }

            //家庭住址不能为空
            if(ISEmpty(this.txtAddress.Text, this.lblHome.Text) )
            {
                return;
            }

            //考勤卡号，不能为空，并且为正整数
            if (ISEmpty(this.txtCardNo.Text, this.lblCard.Text))
            {
                return;
            }

            //电话号码不能为空
            if (ISEmpty(this.txtPhoneNumber.Text, this.lblPhome.Text))
            {
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

            //判断身份证号码和卡号是否正常
            if (studentDal.GetStuIDNOorCard(this.txtStudentIdNo.Text,this.txtCardNo.Text)==null)
            {
                MessageBox.Show("数据库中已经存在身份证或者卡号","提示信息");
                this.txtCardNo.Text=null;
                this.txtStudentIdNo.Text=null;
                return;
            }
            #endregion

            //添加学员
            #region  添加学员
            StudentsinfosModel stu = new StudentsinfosModel()
            {
                Studentname=this.txtStudentName.Text,
                Gender=this.rdoMale.Checked==true ? "男" : "女",
                Birthday=Convert.ToDateTime(this.dtpBirthday.Text),
                ClassName=this.cboClassName.Text,
                Studentidno=this.txtStudentIdNo.Text,
                Cardno=this.txtCardNo.Text,
                Phonenumber=this.txtPhoneNumber.Text,
                Stuimage=this.pbStu.Image==null ? "" : new SerializeObjectToString().SerializeObject(this.pbStu.Image),
                Studentaddress=this.txtAddress.Text,
                Classid=Convert.ToInt32( this.cboClassName.SelectedValue)
           };
            int nums = studentDal.AddStudent(stu);
            if (nums!=0)
            {
                MessageBox.Show("添加成功", "提示信息");
                stu.Studentid=nums;
                stulist.Add(stu);
                this.dataGridView1.DataSource=null;
                this.dataGridView1.DataSource =this.stulist ;
                new DataGridViewStyle().DgvStyle2(this.dataGridView1);
            }
            else
            {
                MessageBox.Show("添加失败", "提示信息");
            }
            #endregion

        }

        /// <summary>
        /// 判断一个TextBox.Text中是否为空
        /// </summary>
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

        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //选择新照片

        /// <summary>
        /// 选择照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title="选择照片";
            openFileDialog.Filter="所有文件|*.*|照片|*.jgp";
            openFileDialog.InitialDirectory=@"F:\桌面";
            openFileDialog.Multiselect=false;
            DialogResult ds = openFileDialog.ShowDialog();
            if (ds==DialogResult.OK)
            {
                this.pbStu.Image=Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 将选择的照片清除掉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.pbStu.Image= null;
        }

 
        /// <summary>
        /// 自动生成行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dataGridView1,e);
        }
    }
}