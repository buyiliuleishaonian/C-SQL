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
    public partial class FrmAttendance : Form
    {
        private AttendanceDal atDal=new AttendanceDal();

        private StudentDAL stuDal = new StudentDAL();

        private List<StudentsinfosModel> stulist=new   List<StudentsinfosModel>();
        public FrmAttendance()
        {
            InitializeComponent();
            //防止出现当窗体绘制之后才出现时间，这样会慢几秒
            timer1_Tick(null,null);
            //打卡人数
           this.lblReal.Text=atDal.CardStu().ToString();
            //实际人数
            this.lblCount.Text=atDal.RealStuAll().ToString();
            //缺考人数
            this.lblAbsenceCount.Text=(atDal.RealStuAll()-atDal.CardStu()).ToString();

            this.dataGridView1.AutoGenerateColumns=false;
        }      
        //显示当前时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblYear.Text=DateTime.Now.Year.ToString();
            this.lblMonth.Text=DateTime.Now.Month.ToString();
            this.lblDay.Text=DateTime.Now.Day.ToString();
            this.lblTime.Text=DateTime.Now.ToLongTimeString ();
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    this.lblWeek.Text="一";
                    break;
                case DayOfWeek.Tuesday:
                    this.lblWeek.Text="二";
                    break;
                case DayOfWeek.Wednesday:
                    this.lblWeek.Text="三";
                    break;
                case DayOfWeek.Thursday:
                    this.lblWeek.Text="四";
                    break;
                case DayOfWeek.Friday:
                    this.lblWeek.Text="五";
                    break;
                case DayOfWeek.Saturday:
                    this.lblWeek.Text="六";
                    break;
                case DayOfWeek.Sunday:
                    this.lblWeek.Text="日";
                    break;
            }
        }
        
        //学员打卡        
        private void txtStuCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtStuCardNo.Text.Trim().Length==0) return;
            if (e.KeyValue==13)
            {
                int nums = atDal.InsertStu(this.txtStuCardNo.Text);
                if (nums!=0)
                {
                    this.lblInfo.Text="打卡成功";
                    //打卡人数
                    this.lblReal.Text=atDal.CardStu().ToString();
                    this.lblAbsenceCount.Text=(atDal.RealStuAll()-atDal.CardStu()).ToString();
                    StudentsinfosModel stu =this.stuDal.SelectCard(this.txtStuCardNo.Text);
                    this.stulist.Add(stu);
                    //
                    stu.DTtime=Convert.ToDateTime( DateTime.Now.ToShortDateString());
                    this.dataGridView1.DataSource=this.stulist;
                    new DataGridViewStyle().DgvStyle2(this.dataGridView1);
                    this.lblStuClass.Text=stu.ClassName;
                    this.lblStuId.Text= stu.Studentid.ToString();
                    this.lblStuName.Text=stu.Studentname;
                    this.pbStu.Image=stu.Stuimage==""?Image.FromFile("图片1.png"): (Image)new SerializeObjectToString().DeserializeObject(stu.Stuimage);
                    return;
                }
                else
                {
                    this.lblInfo.Text="打卡失败";
                    this.lblStuClass.Text="";
                    this.lblStuId.Text="";
                    this.lblStuName.Text="";
                    this.pbStu.Image=null;
                    MessageBox.Show("打卡失败","提示信息");
                    return;
                }
            }
        }
        //结束打卡
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dataGridView1,e);
        }
    }
}
