using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using 学生学习管理系统.Model;
using 学生学习管理系统.BLL;
using 学生学习管理系统.Common;

namespace StudentManager
{
    public partial class FrmStudentManage : Form
    {
        //建立在FrmStudentManage窗体下的全局变量
        public StudnetBLL stuBll = new StudnetBLL();

        public ClassIDBLL classIDBLL = new ClassIDBLL();

        public List<StudentModel> Stulist=new List<StudentModel>();

        /// <summary>
        /// 在ComboBox中显示班级信息
        /// </summary>
        public FrmStudentManage()
        {
            InitializeComponent();
            //首先将班级信息读取出来之后，显示到下拉框中
            this.cboClass.DataSource = classIDBLL.GetClassID();
            this.cboClass.DisplayMember = "ClassName";//属性对应的文本
            this.cboClass.ValueMember = "ClassID";//属性
            this.cboClass.SelectedIndex = -1;
        }

        //按照班级查询
        /// <summary>
        /// 按班级查询学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //将满足班级信息的学员赛选出来，顺便下来
            if (this.cboClass.SelectedIndex==-1 )
            {
                MessageBox.Show("请选择班级查询");
            }
            else
            {
                this.Stulist = stuBll.SelectStudent(this.cboClass.Text);
                this.dgvStudentList.AutoGenerateColumns = false;
                this.dgvStudentList.DataSource = this.Stulist;
                new DataGridViewStyle().DgvStyle1(this.dgvStudentList);//对于DataGridView行列，进行颜色区分
            }
        }

        //根据学号查询
        /// <summary>
        /// 用学号来查询，学员详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQueryById_Click(object sender, EventArgs e)
        {
            //需要判断学号TextBox是否存在学号
            if (this.txtStudentId.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入学号之后查询信息","提示信息");
            }
            //需要判断学号是否是正整数
            if (!DataValidate.IsInteger(this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("请输入正整数","提示信息");
            }
            StudentModel student = new StudentModel();
            //如果查询不到需要提示学员信息不存
            if ((student = stuBll.SelectCardNo(this.txtStudentId.Text.Trim())) == null)
            {
                MessageBox.Show("此学号没有对应的学员", "提示信息");
            }
            //如果查询不到需要提示学员信息不存
            //之后需要展示学员的详细信息
            else
            {
                FrmStudentInfo frmstuinfo= new FrmStudentInfo(student);
                frmstuinfo.ShowDialog();
            }
        }

        /// <summary>
        /// 用户按下回车键之直接查询学员详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            //确保有学号输入，输入的是回车键
            if (this.txtStudentId.Text.Trim().Length!=0 && e.KeyValue==13 )
            {
                btnQueryById_Click(null,null);
            }
        }

        //双击选中的学员对象并显示详细信息
        /// <summary>
        /// 双击DataGridView中数据行时，显示学员的详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentModel model = new StudentModel();
            model= stuBll.SelectCardNo( this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
            FrmStudentInfo modelinfo = new FrmStudentInfo(model);
            modelinfo.ShowDialog();
        }

        //修改学员对象
        /// <summary>
        /// 点击按钮，显示学员详细信息，以便管理员修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEidt_Click(object sender, EventArgs e)
        {
            //判断DataGridVIew是否查询之后，存放了数据/是否选择了一行
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("没有数据可以修改","提示信息");
                return;
            }
            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("用户没有选中","提示信息");
                return;
            }
            //之后得到该行学员的学号
            StudentModel model= new StudentModel();
            model = stuBll.SelectCardNo(this.dgvStudentList.CurrentRow.Cells["Studentid"].Value.ToString());
            FrmEditStudent frmEditStu = new FrmEditStudent(model);
            if (frmEditStu.ShowDialog() == DialogResult.OK)
            {
                btnQuery_Click(null,null);
            }
        }

        //删除学员对象
        /// <summary>
        /// 删除学员对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("没有学员信息","提示信息");
            }
            if (this.dgvStudentList.CurrentCell == null)
            {
                MessageBox.Show("所选中的行没有数据");
            }
           DialogResult dlgrlt= MessageBox.Show("确认是否删除","提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dlgrlt==DialogResult.OK)
            {
                stuBll.DeleteStuinfo(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
                btnQuery_Click(null, null);
            }
        }

        //姓名降序
        /// <summary>
        /// 按学员的名字降序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNameDESC_Click(object sender, EventArgs e)
        {
            if(this.dgvStudentList.RowCount==0)
            { return; }
            this.Stulist.Sort(new StuNameDESC());
            this.dgvStudentList.Refresh();
        }

        //学号降序
        /// <summary>
        /// 按学号降序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0)
            { return; }
            this.Stulist.Sort(new StuIDDESC());
            this.dgvStudentList.Refresh();
        }

        //添加行号
        /// <summary>
        /// 在DataGridView显示的数据行，给每一行的给定序号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint( this.dgvStudentList,e);
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

        /// <summary>
        /// 当单击时，查询学员的详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiModifyStu_Click(object sender, EventArgs e)
        {
            btnEidt_Click(null, null);
        }

        /// <summary>
        /// 单击时，将学员信息删除掉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmidDeleteStu_Click(object sender, EventArgs e)
        {
            btnDel_Click(null,null);
        }
    }

    #region 排序类
    class StuNameDESC : IComparer<StudentModel>
    {
        public int Compare(StudentModel x, StudentModel y)
        {
            return x.StudentName.CompareTo(y.StudentName);
        }
    }

    class StuIDDESC : IComparer<StudentModel>
    {
        public int Compare(StudentModel x, StudentModel y)
        {
            return x.StudentID.CompareTo(y.StudentID);
        }
    }
    #endregion
}