using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 学生学习管理系统.Model;
using 学生学习管理系统.Common;
namespace StudentManager
{
    public partial class FrmStudentInfo : Form
    {
        public List<StudentModel> stulist=new List<StudentModel>();
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        public FrmStudentInfo(StudentModel student) : this()
        {
            this.lblStudentName.Text = student.StudentName;
            this.lblStudentIdNo.Text = student.StudentIdNo;
            this.lblCardNo.Text = student.CardNO;
            this.lblBirthday.Text = student.Bithday.ToShortDateString();
            this.lblAddress.Text = student.StudentAddress;
            this.lblClass.Text = student.ClassName;
            this.lblPhoneNumber.Text = student.PhoneNumber; 
            this.lblGender.Text = student.Gender;

            this.pbStu.Image = student.StuImage.Trim().Length != 0 ?
               (Image)new SerializeObjectToString().DeserializeObject(student.StuImage) :
               null;
            //在DataGridView显示数据
            this.stulist.Add(student);
            //需要将其设置为不自动生成，自生成对应studney对象建立好的列
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = stulist;
            
        }

        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}