using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 学生管理Model;
using 学生管理系统Common;

namespace StudentManager
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }
        public FrmStudentInfo(object obj):this() 
        {
            StudentsinfosModel stu=obj as StudentsinfosModel;
            //通过构造函数将所有的数据全部放入其中
            this.lblStudentName.Text=stu.Studentname;
            this.lblGender.Text=stu.Gender;
            this.lblBirthday.Text=stu.Birthday.ToString("yyyyMMdd");
            this.lblStudentIdNo.Text=stu.Studentidno;
            this.lblCardNo.Text=stu.Cardno;
            this.lblClass.Text=stu.ClassName;
            this.lblPhoneNumber.Text=stu.Phonenumber;
            this.lblAddress.Text=stu.Studentaddress;
            this.pbStu.Image=stu.Stuimage=="" ? Image.FromFile("图片1.png") : (Image)new SerializeObjectToString().DeserializeObject(stu.Stuimage);
        }

        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}