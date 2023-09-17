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
using 学生管理Model.ExeEnd;
using 学生管理UI.Excel;

namespace 学生管理UI
{
     
    public partial class FrmStudentManage : Form
    {
        private ClassDAL classDal = new ClassDAL();
        /// <summary>
        /// 显示班级信息
        /// </summary>
        private List<ClassinfosModel> listClass=new List<ClassinfosModel>();  

        private StudentDAL studentDal = new StudentDAL();

        /// <summary>
        /// 用来给DataGridView提供学员数据
        /// </summary>
        private List<StudentsinfosModel> stulist=new List<StudentsinfosModel>();

        /// <summary>
        /// 用来显示单个人的详细信息
        /// </summary>
        public StudentsinfosModel stu = new StudentsinfosModel();

        private AddObjectModel objectModel = new AddObjectModel();

        
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
            if (this.txtStudentId.Text.Trim().Length!=0 && e.KeyValue==13)
            {
                this.btnQueryById.Focus();
                return;
            }
        }
        //双击选中的学员对象并显示详细信息
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //判断是否有学员信息，可以查询
            if (this.dgvStudentList.RowCount ==0  )
            {
                MessageBox.Show("没有学员信息","提示信息");
                return;
            }
            stu=null;
            stu=studentDal.SelectStuID(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
            FrmStudentInfo studentInfo = new FrmStudentInfo(stu);
            studentInfo.Show();
        }
        //修改学员对象
        private void btnEidt_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("没有学员信息", "提示信息");
                return;
            }
            stu=null;
            stu=studentDal.SelectStuID(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
            FrmEditStudent studentInfo = new FrmEditStudent(stu);
            studentInfo.Show();
        }
        //删除学员对象
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("没有学员信息", "提示信息");
                return;
            }
            int nums= studentDal.DeleteStu(Convert.ToInt32(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString()));
            if (nums!=0)
            {
                MessageBox.Show("删除成功","提示信息");
                //执行一次班级查询，修改显示在DataGridView中显示的数据
                btnQuery_Click(null, null);
            }
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
            if (this.dgvStudentList.RowCount!=0)
            {
               objectModel.Objstu=studentDal.SelectStuID(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
                PrintStudentInfos prstu=new PrintStudentInfos();
                prstu.PrintExcel(objectModel, @"\StudentInfos.xlsx");
            }
            else
            {
                return;
            }
        }
     
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 邮件修改学员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiModifyStu_Click(object sender, EventArgs e)
        {
            btnEidt_Click(null, null);
        }
        /// <summary>
        /// 右键删除学员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmidDeleteStu_Click(object sender, EventArgs e)
        {
            btnDel_Click(null, null);
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