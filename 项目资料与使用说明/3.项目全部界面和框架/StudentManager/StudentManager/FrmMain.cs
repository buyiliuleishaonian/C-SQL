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
            //显示那个管理员登入了
            this.lblCurrentUser.Text = Program.admins.Adminname+"]";
            //显示那个当前软件的版
            this.lblVersion.Text = "版本：" + ConfigurationManager.AppSettings["banben"].ToString();
            //确定容器的背景图片
            this.panelForm.BackgroundImage = Image.FromFile("mainbg.png");
            this.panelForm.BackgroundImageLayout = ImageLayout.Zoom;
        }


        #region 嵌入窗体显示


        //显示添加新学员窗体       
        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddStudent objForm = new FrmAddStudent();
            //先要判断容器中是否存在其他窗体
            ShowForm(objForm);

        }
        /// <summary>
        /// 在Panel容器中显示子窗体
        /// </summary>
        /// <param name="objFrm"></param>
        public void ShowForm(Form objFrm)
        {
            this.lblTitle.Visible = false;
            foreach (var item in this.panelForm.Controls)
            {
                if (item is Form)
                {
                    Form frm = (Form)item;
                    frm.Close();
                }
                //设置为非顶级窗体
                objFrm.TopLevel = false;
                //去掉窗体边框
                objFrm.FormBorderStyle = FormBorderStyle.None;
                //指定窗体的父级
                objFrm.Parent = this.panelForm;
                //将窗体在容器中完全展示
                objFrm.Dock = DockStyle.Fill;
                //显示窗体
                objFrm.Show();
            }
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
            ShowForm(objPwd);
        }

        /// <summary>
        /// 添加学员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }

        /// <summary>
        /// 查看学员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// 将Excel的表格导入到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            FrmExcel frm=new FrmExcel();
            ShowForm(frm);
        }



        /// <summary>
        /// 显示主窗体，登入其他账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminUser_Click(object sender, EventArgs e)
        {
            FrmUserLogin frm = new FrmUserLogin();
                DialogResult ds = frm.ShowDialog();
            if (ds == DialogResult.OK)
            {
                this.lblCurrentUser.Text = Program.admins.Username + "]";
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 当窗体关闭前，必须确认退出系统，才可以关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //在此对话框中，需要显示确认和取消按钮，并且显示问号
            DialogResult dia= MessageBox.Show("确认退出窗体","提示信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dia != DialogResult.OK)
            {
                e.Cancel= true;
                return;
            }
            else
            {
                return;
            }
        }
    }
}