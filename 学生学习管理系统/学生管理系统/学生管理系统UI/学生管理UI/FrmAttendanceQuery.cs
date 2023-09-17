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
using 学生管理系统Common;

namespace 学生管理UI
{
    public partial class FrmAttendanceQuery : Form
    {
      private AttendanceDal atDal=new AttendanceDal();

        private List<StudentsinfosModel> stulist=new List<StudentsinfosModel>();

        public FrmAttendanceQuery()
        {
            InitializeComponent();
            this.dgvStudentList.AutoGenerateColumns = false;
            this.lblCount.Text= this.atDal.RealStuAll().ToString();
            this.lblReal.Text=this.atDal.DateStu(Convert.ToDateTime(this.dtpTime.Value.ToShortDateString())).ToString();
            this.lblAbsenceCount.Text=(this.atDal.RealStuAll()-this.atDal.DateStu(Convert.ToDateTime(this.dtpTime.Value.ToShortDateString()))).ToString();
        }

        /// <summary>
        /// 按下查询学员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime( this.dtpTime.Value.ToShortDateString());
            this.lblCount.Text= this.atDal.RealStuAll().ToString();
            this.lblReal.Text=this.atDal.DateStu(Convert.ToDateTime(this.dtpTime.Value.ToShortDateString())).ToString();
            this.lblAbsenceCount.Text=(this.atDal.RealStuAll()-this.atDal.DateStu(Convert.ToDateTime(this.dtpTime.Value.ToShortDateString()))).ToString();
            StudentsinfosModel stu = this.atDal.SelectStuNameAndDate(this.txtName.Text,dt,dt.AddDays(1.0));
            this.stulist.Add(stu);
            this.dgvStudentList.DataSource= this.stulist;
            new DataGridViewStyle().DgvStyle2(this.dgvStudentList);
        }
        //添加行号
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
          DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList,e); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
