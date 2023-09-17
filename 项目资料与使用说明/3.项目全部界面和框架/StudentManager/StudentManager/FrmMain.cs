using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using ѧ��ѧϰ����ϵͳUI;

namespace StudentManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //��ʾ�Ǹ�����Ա������
            this.lblCurrentUser.Text = Program.admins.Adminname+"]";
            //��ʾ�Ǹ���ǰ����İ�
            this.lblVersion.Text = "�汾��" + ConfigurationManager.AppSettings["banben"].ToString();
            //ȷ�������ı���ͼƬ
            this.panelForm.BackgroundImage = Image.FromFile("mainbg.png");
            this.panelForm.BackgroundImageLayout = ImageLayout.Zoom;
        }


        #region Ƕ�봰����ʾ


        //��ʾ�����ѧԱ����       
        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {
            FrmAddStudent objForm = new FrmAddStudent();
            //��Ҫ�ж��������Ƿ������������
            ShowForm(objForm);

        }
        /// <summary>
        /// ��Panel��������ʾ�Ӵ���
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
                //����Ϊ�Ƕ�������
                objFrm.TopLevel = false;
                //ȥ������߿�
                objFrm.FormBorderStyle = FormBorderStyle.None;
                //ָ������ĸ���
                objFrm.Parent = this.panelForm;
                //����������������ȫչʾ
                objFrm.Dock = DockStyle.Fill;
                //��ʾ����
                objFrm.Show();
            }
        }

        //���ڴ�      
        private void tsmi_Card_Click(object sender, EventArgs e)
        {
            FrmAttendance objForm = new FrmAttendance();
            ShowForm(objForm);
        }

        //�ɼ����ٲ�ѯ��Ƕ����ʾ��
        private void tsmiQuery_Click(object sender, EventArgs e)
        {
            FrmScoreQuery objForm = new FrmScoreQuery();
            ShowForm(objForm);
        }

        //ѧԱ����Ƕ����ʾ��
        private void tsmiManageStudent_Click(object sender, EventArgs e)
        {
            FrmStudentManage objForm = new FrmStudentManage();
            ShowForm(objForm);
        }

        //��ʾ�ɼ���ѯ���������    
        private void tsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
            FrmScoreManage objForm = new FrmScoreManage();
            ShowForm(objForm);
        }

        //���ڲ�ѯ
        private void tsmi_AQuery_Click(object sender, EventArgs e)
        {
            FrmAttendanceQuery objForm = new FrmAttendanceQuery();
            ShowForm(objForm);
        }
        #endregion

        #region �˳�ϵͳȷ��

        //�˳�ϵͳ
        private void tmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region ����

        //�����޸�
        private void tmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objPwd = new FrmModifyPwd();
            ShowForm(objPwd);
        }

        /// <summary>
        /// ���ѧԱ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }

        /// <summary>
        /// �鿴ѧԱ��Ϣ
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

        //���ʹ���
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
        /// ��Excel�ı���뵽���ݿ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            FrmExcel frm=new FrmExcel();
            ShowForm(frm);
        }



        /// <summary>
        /// ��ʾ�����壬���������˺�
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
        /// ������ر�ǰ������ȷ���˳�ϵͳ���ſ��Թرմ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //�ڴ˶Ի����У���Ҫ��ʾȷ�Ϻ�ȡ����ť��������ʾ�ʺ�
            DialogResult dia= MessageBox.Show("ȷ���˳�����","��ʾ��Ϣ",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
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