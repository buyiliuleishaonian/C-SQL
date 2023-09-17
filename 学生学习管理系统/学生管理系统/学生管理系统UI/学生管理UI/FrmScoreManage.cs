using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 学生学习管理DAL;
using 学生管理Model;
using 学生管理Model.ExeEnd;
using 学生管理系统Common;

namespace 学生管理UI
{
    public partial class FrmScoreManage : Form
    {
        private ClassDAL classDal = new ClassDAL();
        /// <summary>
        /// 显示班级信息
        /// </summary>
        private List<ClassinfosModel> listClass = new List<ClassinfosModel>();

        private ScoreDAL scoreDAL = new ScoreDAL();

        private List<AddObjectModel> AddObjectModel = new List<AddObjectModel>();
        public FrmScoreManage()
        {
            InitializeComponent();
            //在窗体创建时，就将班级信息存储在下拉框中
            listClass=classDal.GetClass();
            this.cboClass.DataSource = listClass;
            this.cboClass.ValueMember = "classid";//索引
            this.cboClass.DisplayMember = "className";//索引对应的值
            this.cboClass.SelectedIndex=-1;
            this.dgvScoreList.AutoGenerateColumns = false;
            //这里需要先将TextBox中Select这个删除
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
        }
        //根据班级查询      
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboClass.Text.Trim().Length==0)
            {
                MessageBox.Show("请选择班级，进行查询","提示信息");
                return;
            }
            Score(Convert.ToInt32( this.cboClass.SelectedValue));
        }

        private void Score(int classid)
        {
            //按照班级查询学员信息
             this.AddObjectModel=scoreDAL.SelectStuScore(classid);
            this.dgvScoreList.DataSource=this.AddObjectModel;
            //查询结果
            
            Dictionary<string, string> dic = scoreDAL.SelectPeopleSco( classid);
            this.lblAttendCount.Text = dic["stucount"];
            this.lblCount.Text = dic["stuentcount"];
            this.lblCSharpAvg.Text = dic["csharpAvg"];
            this.lblDBAvg.Text = dic["sqlServerAvg"];

            //3、显示缺号人员列表
            List<string> list = scoreDAL.SelectName(classid);
            this.lblList.Items.Clear();
            if (list.Count == 0)
            {
                this.lblList.Text = "没人缺考";
            }
            else
            {
                //list无法被listbox的属性items接，需要将其转化为数组
                this.lblList.Items.AddRange(list.ToArray());
            }
        }
        //统计全校考试成绩
        private void btnStat_Click(object sender, EventArgs e)
        {
            Score(Convert.ToInt32(0));
        }
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 判断单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvScoreList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
                //需要判断该列属于什么对象，并且判断该列属于第几列
                if (e.ColumnIndex==0 && e.Value is StudentsinfosModel)
                {
                    e.Value=(e.Value as StudentsinfosModel).Studentid;
                }
                if (e.ColumnIndex == 1 && e.Value is StudentsinfosModel)
                {
                    e.Value = (e.Value as StudentsinfosModel).Studentname;
                }
                if (e.ColumnIndex == 2 && e.Value is ClassinfosModel)
                {
                    e.Value = (e.Value as ClassinfosModel).Classname;
                }
                if (e.ColumnIndex == 3 && e.Value is ScorelistinfosModel)
                {
                    e.Value = (e.Value as ScorelistinfosModel).Csharp;
                }
                if (e.ColumnIndex == 4 && e.Value is ScorelistinfosModel)
                {
                    e.Value = (e.Value as ScorelistinfosModel).Sqlserver成绩;
                }
            
        }
        /// <summary>
        /// 行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList,e);
        }
    }
}