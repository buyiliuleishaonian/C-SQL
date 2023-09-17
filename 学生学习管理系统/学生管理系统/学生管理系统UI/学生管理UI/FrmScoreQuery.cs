using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 学生学习管理DAL;
using 学生管理Model;
using 学生管理UI.Excel;
using 学生管理系统Common;

namespace 学生管理UI
{
    public partial class FrmScoreQuery : Form
    {
        private ClassDAL classDal = new ClassDAL();
        /// <summary>
        /// 显示班级信息
        /// </summary>
        private List<ClassinfosModel> listClass = new List<ClassinfosModel>();

        private DataSet ds = null;

        private  ScoreDAL scoreDAL = new ScoreDAL();    
        public FrmScoreQuery()
        {
            InitializeComponent();
            //在窗体创建时，就将班级信息存储在下拉框中
            listClass=classDal.GetClass();
            this.cboClass.DataSource = listClass;
            this.cboClass.ValueMember = "classid";//索引
            this.cboClass.DisplayMember = "className";//索引对应的值
            this.cboClass.SelectedIndex=-1;
            //首先需要显示所有班级的学员成绩
            this.ds=scoreDAL.SelectStuScore();
            this.dgvScoreList.DataSource=this.ds.Tables[0];
        }  
   
        //根据班级名称动态筛选
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ds==null)
            { return; }
            this.ds.Tables[0].DefaultView.RowFilter=string.Format(" classname='{0}'",this.cboClass.Text.Trim());
        }
        //显示全部成绩
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.ds.Tables[0].DefaultView.RowFilter="classname like '%%'";
        }
        //根据C#成绩动态筛选
        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            if (this.txtScore.Text.Trim().Length==0) return;
            if (!DataValidate.IsInteger(this.txtScore.Text.Trim()))
            {
                MessageBox.Show("请输入正整数","提示信息");
                return;
            }
            this.ds.Tables[0].DefaultView.RowFilter="Csharp>"+this.txtScore.Text.Trim();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintScore_Click(object sender, EventArgs e)
        {
            DataExport de=new   DataExport();
            de.PrintExcel(this.dgvScoreList);
        }
    }
}

