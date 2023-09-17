using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using 学生学习管理系统UI;

namespace StudentManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //显示用户
            this.lblCurrentUser.Text = Program.adminModel.AdminName+"]";
            //显示窗体图片
            this.panelForm.BackgroundImage = Image.FromFile(@"mainbg.png");
            this.panelForm.BackgroundImageLayout =ImageLayout.Stretch;
            //显示版本号
            this.lblVersion.Text ="当前版本:"+ ConfigurationManager.AppSettings["banben"].ToString();
            //权限设定
        }    

        #region 嵌入窗体显示

     
        //显示添加新学员窗体       
        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {          
            FrmAddStudent objForm = new FrmAddStudent();
            ShowForm(objForm);
        }
        //考勤打卡      
        private void tsmi_Card_Click(object sender, EventArgs e)
        {
            FrmAttendance objForm = new FrmAttendance();
            ShowForm(objForm);


        }
        //成绩快速查询【嵌入显示】
        private void tsmiQuery_Click(object sender, EventArgs e)
        {
          FrmScoreQuery objForm = new FrmScoreQuery();
            ShowForm(objForm);
        }
        //学员管理【嵌入显示】
        private void tsmiManageStudent_Click(object sender, EventArgs e)
        {
           FrmStudentManage objForm = new FrmStudentManage();
            ShowForm(objForm);
        }
        //显示成绩查询与分析窗口    
        private void tsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
            FrmScoreManage objForm = new FrmScoreManage();
            ShowForm(objForm);
        }
        //考勤查询
        private void tsmi_AQuery_Click(object sender, EventArgs e)
        {
            FrmAttendanceQuery objForm = new FrmAttendanceQuery();
            ShowForm(objForm);
        }
        #endregion

        #region 退出系统确认

        //退出系统
        private void tmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        #endregion

        #region 其他

        //密码修改
        private void tmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objPwd = new FrmModifyPwd();
            objPwd.ShowDialog();
        }

        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tsmiManageStudent_Click(null, null);
        }
        private void tsbScoreAnalysis_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        private void tsbModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }   
     
        //访问官网
        private void tsmi_linkxkt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.xiketang.com");
        }

        private void tsmi_about_Click(object sender, EventArgs e)
        {
            FrmAbout objAbout = new FrmAbout();
            objAbout.Show();
        }

        #endregion

        /// <summary>
        /// 添加学员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStuInsert_Click(object sender, EventArgs e)
        {
            //创建对应按钮的窗体的对象
            FrmAddStudent frmAddStudent = new FrmAddStudent();
            ShowForm(frmAddStudent);
        }

        /// <summary>
        /// 嵌入窗体的常用方法
        /// </summary>
        public  void ShowForm(Form objfrm)
        {
            //判断容器中是否有别的窗体存在，将其他窗体关闭
            foreach (Control item in this.panelForm.Controls)
            {
                if (item is Form)//判断容器中的是否是窗体，因为窗体嵌入，容器变为父级，可以使用里氏变换
                {
                    Form frm = (Form)item;//将其转换为窗体对象，之后将其关闭
                    frm.Close();
                }
            }
            //嵌入窗体的步骤
            //1、将子窗体设置成非顶级控件，这样窗体才可以显示在容器上方
            objfrm.TopLevel = false;
            //2、去掉窗体的边框
            objfrm.FormBorderStyle = FormBorderStyle.None;
            //3、指定子窗体显示的容器，指定窗体的父级
            objfrm.Parent = this.panelForm;
            //4、设置窗体随着容器的大小自动给调整窗体的大小
            objfrm.Dock = DockStyle.Fill;
            //5、显示窗体
            this.lblTitle.Visible = false;
            objfrm.Show();
        }

        #region  按钮窗体的嵌入
        /// <summary>
        /// 学员管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStunInfos_Click(object sender, EventArgs e)
        {
            FrmStudentManage objForm=new FrmStudentManage();
            ShowForm(objForm);
        }

        /// <summary>
        /// 考勤打卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCard_Click(object sender, EventArgs e)
        {
            FrmAddStudent objForm=new FrmAddStudent();
            ShowForm(objForm);
        }

        /// <summary>
        /// 考勤查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCardInfos_Click(object sender, EventArgs e)
        {
            FrmAttendance objForm=new FrmAttendance();
            ShowForm(objForm);
        }

        /// <summary>
        /// 成绩浏览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScoreInfos_Click(object sender, EventArgs e)
        {
           FrmScoreQuery objForm=new FrmScoreQuery();
            ShowForm(objForm);
        }

        /// <summary>
        /// 成绩管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScore_Click(object sender, EventArgs e)
        {
            FrmScoreManage objForm=new FrmScoreManage();
            ShowForm(objForm);
        }

        /// <summary>
        /// 密码修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objForm=new FrmModifyPwd();
            ShowForm(objForm);
        }

        /// <summary>
        /// 账号切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminUser_Click(object sender, EventArgs e)
        {
            FrmUserLogin objForm=new FrmUserLogin();
            objForm.Text = "账号切换";
            DialogResult result= objForm.ShowDialog();
            if (result==DialogResult.OK)
            {
                this.lblCurrentUser.Text = Program.adminModel.AdminName + "]";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            FrmAbout objForm=new FrmAbout();
            ShowForm(objForm);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FrmStudentInfo objForm=new FrmStudentInfo();
            ShowForm(objForm);
        }
        #endregion

        /// <summary>
        /// 系统关闭前的确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("退出询问","确认退出",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question  );//messageboxbuttons.okcancel用来增加确认和取消按钮，
            //messageboxlcon.question用来增加一个问号图片
            if (dialogResult!=DialogResult.OK)
            {
                e.Cancel= true; //告诉窗体关闭这个事件取消
            }
        }
    }
}