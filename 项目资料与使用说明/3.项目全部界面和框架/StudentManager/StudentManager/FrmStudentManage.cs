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

namespace StudentManager
{
     
    public partial class FrmStudentManage : Form
    {
        private ClassDAL classDal = new ClassDAL();

        private List<ClassinfosModel> listClass=new List<ClassinfosModel>();  

        private StudentDAL studentDal = new StudentDAL();

        private List<StudentsinfosModel> stulist=new List<StudentsinfosModel>();

        public StudentsinfosModel stu = new StudentsinfosModel();
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
         
        }
        //˫��ѡ�е�ѧԱ������ʾ��ϸ��Ϣ
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        //�޸�ѧԱ����
        private void btnEidt_Click(object sender, EventArgs e)
        {
          
        }
        //ɾ��ѧԱ����
        private void btnDel_Click(object sender, EventArgs e)
        {
           
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
            
        }
     
        //�ر�
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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