using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ѧ��ѧϰ����DAL;
using ѧ������Model;
using ѧ������ϵͳCommon;
using ѧ������Model.ExeEnd;
using ѧ������UI.Excel;

namespace ѧ������UI
{
     
    public partial class FrmStudentManage : Form
    {
        private ClassDAL classDal = new ClassDAL();
        /// <summary>
        /// ��ʾ�༶��Ϣ
        /// </summary>
        private List<ClassinfosModel> listClass=new List<ClassinfosModel>();  

        private StudentDAL studentDal = new StudentDAL();

        /// <summary>
        /// ������DataGridView�ṩѧԱ����
        /// </summary>
        private List<StudentsinfosModel> stulist=new List<StudentsinfosModel>();

        /// <summary>
        /// ������ʾ�����˵���ϸ��Ϣ
        /// </summary>
        public StudentsinfosModel stu = new StudentsinfosModel();

        private AddObjectModel objectModel = new AddObjectModel();

        
        public FrmStudentManage()
        {
            InitializeComponent();
            //�ڴ��崴��ʱ���ͽ��༶��Ϣ�洢����������
            listClass=classDal.GetClass();
            this.cboClass.DataSource = listClass;
            this.cboClass.ValueMember = "classid";//����
            this.cboClass.DisplayMember = "className";//������Ӧ��ֵ
            this.cboClass.SelectedIndex=-1;
            //���Զ�������
            this.dgvStudentList.AutoGenerateColumns=false;
        }
        //���հ༶��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //�Ƿ�ѡ���˰༶���в�ѯ
            if (this.cboClass.Text.Trim().Length==0)
            {
                MessageBox.Show("��ѡ��༶��ѯ","��ʾ��Ϣ");
                return;
            }
            stulist=studentDal.SelectStu((int)this.cboClass.SelectedValue);
            if (stulist!=null)
            {
                this.dgvStudentList.DataSource=null;
                this.dgvStudentList.DataSource = this.stulist;
                new DataGridViewStyle().DgvStyle2(this.dgvStudentList);
            }
            else
            {
                MessageBox.Show("��ѯʧ��","��ʾ��Ϣ");
                return;
            }
        }
        //����ѧ�Ų�ѯ
        private void btnQueryById_Click(object sender, EventArgs e)
        {
            //�ж��Ƿ�������ѧ��
            if (this.txtStudentId.Text.Trim().Length==0) return;
            if (!DataValidate.IsInteger(this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("������������","��ʾ��Ϣ");
                return;
            }
            stu=studentDal.SelectStuID(this.txtStudentId.Text);
            FrmStudentInfo studentInfo = new FrmStudentInfo(stu);
            studentInfo.Show();
        }
        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtStudentId.Text.Trim().Length!=0 && e.KeyValue==13)
            {
                this.btnQueryById.Focus();
                return;
            }
        }
        //˫��ѡ�е�ѧԱ������ʾ��ϸ��Ϣ
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //�ж��Ƿ���ѧԱ��Ϣ�����Բ�ѯ
            if (this.dgvStudentList.RowCount ==0  )
            {
                MessageBox.Show("û��ѧԱ��Ϣ","��ʾ��Ϣ");
                return;
            }
            stu=null;
            stu=studentDal.SelectStuID(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
            FrmStudentInfo studentInfo = new FrmStudentInfo(stu);
            studentInfo.Show();
        }
        //�޸�ѧԱ����
        private void btnEidt_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("û��ѧԱ��Ϣ", "��ʾ��Ϣ");
                return;
            }
            stu=null;
            stu=studentDal.SelectStuID(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
            FrmEditStudent studentInfo = new FrmEditStudent(stu);
            studentInfo.Show();
        }
        //ɾ��ѧԱ����
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("û��ѧԱ��Ϣ", "��ʾ��Ϣ");
                return;
            }
            int nums= studentDal.DeleteStu(Convert.ToInt32(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString()));
            if (nums!=0)
            {
                MessageBox.Show("ɾ���ɹ�","��ʾ��Ϣ");
                //ִ��һ�ΰ༶��ѯ���޸���ʾ��DataGridView����ʾ������
                btnQuery_Click(null, null);
            }
        }     
        //��������
        private void btnNameDESC_Click(object sender, EventArgs e)
        {
            //��Ҫ�ж�DataGridView�е��Ƿ��������
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("û��ѧԱ��Ϣ","��ʾ��Ϣ");
                return;
            }
            this.stulist.Sort(new NameDESC());
            this.dgvStudentList.Refresh();
        }
        //ѧ�Ž���
        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount==0)
            {
                MessageBox.Show("û��ѧԱ��Ϣ", "��ʾ��Ϣ");
                return;
            }
            this.stulist.Sort(new StuNODESC());
            this.dgvStudentList.Refresh();
        }
        //����к�
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList,e);
        }
        //��ӡ��ǰѧԱ��Ϣ
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount!=0)
            {
               objectModel.Objstu=studentDal.SelectStuID(this.dgvStudentList.CurrentRow.Cells["studentid"].Value.ToString());
                PrintStudentInfos prstu=new PrintStudentInfos();
                prstu.PrintExcel(objectModel, @"\StudentInfos.xlsx");
            }
            else
            {
                return;
            }
        }
     
        //�ر�
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// �ʼ��޸�ѧԱ��Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiModifyStu_Click(object sender, EventArgs e)
        {
            btnEidt_Click(null, null);
        }
        /// <summary>
        /// �Ҽ�ɾ��ѧԱ��Ϣ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmidDeleteStu_Click(object sender, EventArgs e)
        {
            btnDel_Click(null, null);
        }
    }
    //ͨ��ѧ�ź���������
    class NameDESC : IComparer<StudentsinfosModel>
    {
        public int Compare(StudentsinfosModel x,StudentsinfosModel y)
        {
            return y.Studentname.CompareTo(x.Studentname);  
        }
    }
    class StuNODESC:IComparer<StudentsinfosModel> 
    {
        public int Compare(StudentsinfosModel x, StudentsinfosModel y)
        {
            return y.Studentid.CompareTo(x.Studentid);
        }
    }
}