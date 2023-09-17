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

namespace StudentManager
{
     
    public partial class FrmStudentManage : Form
    {
        private ClassDAL classDal = new ClassDAL();

        private List<ClassinfosModel> listClass=new List<ClassinfosModel>();  

        private StudentDAL studentDal = new StudentDAL();

        private List<StudentsinfosModel> stulist=new List<StudentsinfosModel>();

        public StudentsinfosModel stu = new StudentsinfosModel();
        public FrmStudentManage()
        {
            InitializeComponent();
            //在窗体创建时，就将班级信息存储在下拉框中
            listClass=classDal.GetClass();
            this.cboClass.DataSource = listClass;
            this.cboClass.ValueMember = "classid";//索引
            this.cboClass.DisplayMember = "className";//索引对应的值
            this.cboClass.SelectedIndex=-1;
            //不自动生成列
            this.dgvStudentList.AutoGenerateColumns=false;
        }
        //按照班级查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //是否选择了班级进行查询
            if (this.cboClass.Text.Trim().Length==0)
            {
                MessageBox.Show("请选择班级查询","提示信息");
                return;
            }
            stulist=studentDal.SelectStu((int)this.cboClass.SelectedValue);
            if (stulist!=null)
            {
                this.dgvStudentList.DataSource=null;
                this.dgvStudentList.DataSource = this.stulist;
                new DataGridViewStyle().DgvStyle2(this.dgvStudentList);
            }
            else
            {
                MessageBox.Show("查询失败","提示信息");
                return;
            }
        }
        //根据学号查询
        private void btnQueryById_Click(object sender, EventArgs e)
        {
            //判断是否输入了学号
            if (this.txtStudentId.Text.Trim().Length==0) return;
            if (!DataValidate.IsInteger(this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("请输入正整数","提示信息");
                return;
            }
            stu=studentDal.SelectStuID(this.txtStudentId.Text);
            FrmStudentInfo studentInfo = new FrmStudentInfo(stu);
            studentInfo.Show();
        }
        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
         
        }
        //双击选中的学员对象并显示详细信息
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        //修改学员对象
        private void btnEidt_Click(object sender, EventArgs e)
        {
          
        }
        //删除学员对象
        private void btnDel_Click(object sender, EventArgs e)
        {
           
        }     
        //姓名降序
        private void btnNameDESC_Click(object sender, EventArgs e)
        {
            //先要判断DataGridView中的是否存在数据
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("没有学员信息","提示信息");
                return;
            }
            this.stulist.Sort(new NameDESC());
            this.dgvStudentList.Refresh();
        }
        //学号降序
        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("没有学员信息", "提示信息");
                return;
            }
            this.stulist.Sort(new StuNODESC());
            this.dgvStudentList.Refresh();
        }
        //添加行号
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList,e);
        }
        //打印当前学员信息
        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }
     
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    //通过学号和姓名排序
    class NameDESC : IComparer<StudentsinfosModel>
    {
        public int Compare(StudentsinfosModel x,StudentsinfosModel y)
        {
            return y.Studentname.CompareTo(x.Studentname);  
        }
    }
    class StuNODESC:IComparer<StudentsinfosModel> 
    {
        public int Compare(StudentsinfosModel x, StudentsinfosModel y)
        {
            return y.Studentid.CompareTo(x.Studentid);
        }
    }
}