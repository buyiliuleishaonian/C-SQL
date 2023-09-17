using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ѧ��ѧϰ����DAL;
using ѧ������Model;
using ѧ������Model.ExeEnd;
using ѧ������ϵͳCommon;

namespace ѧ������UI
{
    public partial class FrmScoreManage : Form
    {
        private ClassDAL classDal = new ClassDAL();
        /// <summary>
        /// ��ʾ�༶��Ϣ
        /// </summary>
        private List<ClassinfosModel> listClass = new List<ClassinfosModel>();

        private ScoreDAL scoreDAL = new ScoreDAL();

        private List<AddObjectModel> AddObjectModel = new List<AddObjectModel>();
        public FrmScoreManage()
        {
            InitializeComponent();
            //�ڴ��崴��ʱ���ͽ��༶��Ϣ�洢����������
            listClass=classDal.GetClass();
            this.cboClass.DataSource = listClass;
            this.cboClass.ValueMember = "classid";//����
            this.cboClass.DisplayMember = "className";//������Ӧ��ֵ
            this.cboClass.SelectedIndex=-1;
            this.dgvScoreList.AutoGenerateColumns = false;
            //������Ҫ�Ƚ�TextBox��Select���ɾ��
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
        }
        //���ݰ༶��ѯ      
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboClass.Text.Trim().Length==0)
            {
                MessageBox.Show("��ѡ��༶�����в�ѯ","��ʾ��Ϣ");
                return;
            }
            Score(Convert.ToInt32( this.cboClass.SelectedValue));
        }

        private void Score(int classid)
        {
            //���հ༶��ѯѧԱ��Ϣ
             this.AddObjectModel=scoreDAL.SelectStuScore(classid);
            this.dgvScoreList.DataSource=this.AddObjectModel;
            //��ѯ���
            
            Dictionary<string, string> dic = scoreDAL.SelectPeopleSco( classid);
            this.lblAttendCount.Text = dic["stucount"];
            this.lblCount.Text = dic["stuentcount"];
            this.lblCSharpAvg.Text = dic["csharpAvg"];
            this.lblDBAvg.Text = dic["sqlServerAvg"];

            //3����ʾȱ����Ա�б�
            List<string> list = scoreDAL.SelectName(classid);
            this.lblList.Items.Clear();
            if (list.Count == 0)
            {
                this.lblList.Text = "û��ȱ��";
            }
            else
            {
                //list�޷���listbox������items�ӣ���Ҫ����ת��Ϊ����
                this.lblList.Items.AddRange(list.ToArray());
            }
        }
        //ͳ��ȫУ���Գɼ�
        private void btnStat_Click(object sender, EventArgs e)
        {
            Score(Convert.ToInt32(0));
        }
        //�ر�
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// �жϵ�Ԫ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvScoreList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
                //��Ҫ�жϸ�������ʲô���󣬲����жϸ������ڵڼ���
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
                    e.Value = (e.Value as ScorelistinfosModel).Sqlserver�ɼ�;
                }
            
        }
        /// <summary>
        /// �к�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvScoreList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvScoreList,e);
        }
    }
}