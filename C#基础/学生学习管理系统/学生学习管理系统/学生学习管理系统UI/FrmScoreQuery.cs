using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 学生学习管理系统.Model;
using 学生学习管理系统.BLL;
using 学生学习管理系统.Common;

namespace StudentManager
{
    public partial class FrmScoreQuery : Form
    {
        private ClassIDBLL ci = new ClassIDBLL();
        private  ScoreListBll scobll = new ScoreListBll();
        private DataSet ds = null;//用来保存查询的结果

        public FrmScoreQuery()
        {
            InitializeComponent();
            //将班级信息读取到下拉框中
            DataTable dt= ci.GetClassid();
            this.cboClass.DataSource = dt;
            this.cboClass.ValueMember = "classid";
            this.cboClass.DisplayMember = "classname";
            
            //将所有学员信息读取到DataGriodView
            this.dgvScoreList.AutoGenerateColumns = false;
            this.ds= new DataSet();
            this.ds = this.scobll.GetScoure();
            this.dgvScoreList.DataSource = this.ds.Tables[0];
            new DataGridViewStyle().DgvStyle2(this.dgvScoreList);
        }

        //根据班级名称动态筛选
        /// <summary>
        /// 根据班级名称动态筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ds==null) return;
           this.ds.Tables[0].DefaultView.RowFilter = string.Format("ClassName='{0}'", this.cboClass.Text.Trim());
            
        }
        /// <summary>
        /// 显示全部成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //显示全部成绩
        private void btnShowAll_Click(object sender, EventArgs e)
        {
                this.ds.Tables[0].DefaultView.RowFilter = "ClassName like  '%%'";//表示ClassName什么都没有
                //就表示可以获取全部的。            
        }

        //根据C#成绩动态筛选
        /// <summary>
        /// 根据C#成绩动态筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            if (this.txtScore.Text.Trim() == null) return;
            if (DataValidate.IsInteger(this.txtScore.Text.Trim()))
            {
                this.ds.Tables[0].DefaultView.RowFilter="Csharp>="+this.txtScore.Text.Trim();
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 当单元格出现变化之后。对应的行号也变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList,e);
        }
    }
}

