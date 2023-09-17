using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ѧ������Model;
using ѧ��ѧϰ����DAL;
using ѧ������ϵͳCommon;

namespace StudentManager
{
    public partial class FrmAddStudent : Form
    {
        //��Ҫ�����а༶��Ϣ��ȡ��������ؼ���
        private ClassDAL classDal = new ClassDAL();

        private StudentDAL studentDal = new StudentDAL();   

        private List<ClassinfosModel> listClass = new List<ClassinfosModel>();

        private List<StudentsinfosModel> stulist = new List<StudentsinfosModel>();
        public FrmAddStudent()
        {
            InitializeComponent();
            //�ڴ��崴��ʱ���ͽ��༶��Ϣ�洢����������
            listClass=classDal.GetClass();
            this.cboClassName.DataSource = listClass;
            this.cboClassName.ValueMember = "classid";//����
            this.cboClassName.DisplayMember = "className";//������Ӧ��ֵ
            this.cboClassName.SelectedIndex=-1;
            //�����Զ�������
            this.dataGridView1.AutoGenerateColumns = false;
        }
        //�����ѧԱ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region ���ѧԱ֮ǰ���ж�
            //�����ѧԱ֮ǰ����Ҫȷ�������������֤���ֻ��ţ�
            //����ȷ�����֤�ź����֤��������ͬ�ġ�
            //�ж�����
            if (ISEmpty(this.txtStudentName.Text, this.lblStudentName.Text))
            {
                return;
            }

            //�ж��Ա�
            if (this.rdoMale.Checked==false && this.rdoFemale.Checked==false)
            {
                MessageBox.Show("û��ѡ���Ա�", "��ʾ��Ϣ");
                return;
            }

            //�жϰ༶�Ƿ�Ϊ��
            if (this.cboClassName.SelectedIndex==-1)
            {
                MessageBox.Show("û��ѡ��༶", "��ʾ��Ϣ");
                this.cboClassName.Focus();
                return;
            }

            //��Ҫ�ж����֤���ǿ�
            if (ISEmpty(this.txtStudentIdNo.Text, this.lblStudentIDNO.Text))
            {
                return;
            }

            //����Ҫ�ж����֤��Ϣ��������
            if (!DataValidate.IsInteger(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("���֤����������","��ʾ��Ϣ");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //�ж����֤�ϵĳ������ں�ѡ��������Ƿ�һ��
            string time =Convert.ToDateTime( this.dtpBirthday.Text).ToString("yyyyMMdd");
            if (!this.txtStudentIdNo.Text.Contains(time))
            {
                MessageBox.Show("���֤��ѡ��ĳ������ڣ���ƥ��","��ʾ��Ϣ");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //�ж����֤�Ƿ񳤶�����Ҫ��
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("���֤���Ȳ���","��ʾ��Ϣ");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //�ж�����Ƿ�����18~35��
            int age=DateTime.Now.Year-Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age<18 ||age>35)
            {
                MessageBox.Show("���䳬��Ҫ��","��ʾ��Ϣ");
                return;
            }

            //��ͥסַ����Ϊ��
            if(ISEmpty(this.txtAddress.Text, this.lblHome.Text) )
            {
                return;
            }

            //���ڿ��ţ�����Ϊ�գ�����Ϊ������
            if (ISEmpty(this.txtCardNo.Text, this.lblCard.Text))
            {
                return;
            }

            //�绰���벻��Ϊ��
            if (ISEmpty(this.txtPhoneNumber.Text, this.lblPhome.Text))
            {
                return;
            }
            //���ܵ绰Ϊ��������
            if (!DataValidate.IsInteger(this.txtPhoneNumber.Text.Trim()))
            {
                MessageBox.Show("���Ų���������", "��ʾ��Ϣ");
                this.txtPhoneNumber.SelectAll();
                this.txtPhoneNumber.Focus();
                return;
            }

            //�ж����֤����Ϳ����Ƿ�����
            if (studentDal.GetStuIDNOorCard(this.txtStudentIdNo.Text,this.txtCardNo.Text)==null)
            {
                MessageBox.Show("���ݿ����Ѿ��������֤���߿���","��ʾ��Ϣ");
                this.txtCardNo.Text=null;
                this.txtStudentIdNo.Text=null;
                return;
            }
            #endregion

            //���ѧԱ
            #region  ���ѧԱ
            StudentsinfosModel stu = new StudentsinfosModel()
            {
                Studentname=this.txtStudentName.Text,
                Gender=this.rdoMale.Checked==true ? "��" : "Ů",
                Birthday=Convert.ToDateTime(this.dtpBirthday.Text),
                ClassName=this.cboClassName.Text,
                Studentidno=this.txtStudentIdNo.Text,
                Cardno=this.txtCardNo.Text,
                Phonenumber=this.txtPhoneNumber.Text,
                Stuimage=this.pbStu.Image==null ? "" : new SerializeObjectToString().SerializeObject(this.pbStu.Image),
                Studentaddress=this.txtAddress.Text,
                Classid=Convert.ToInt32( this.cboClassName.SelectedValue)
           };
            int nums = studentDal.AddStudent(stu);
            if (nums!=0)
            {
                MessageBox.Show("��ӳɹ�", "��ʾ��Ϣ");
                stu.Studentid=nums;
                stulist.Add(stu);
                this.dataGridView1.DataSource=null;
                this.dataGridView1.DataSource =this.stulist ;
                new DataGridViewStyle().DgvStyle2(this.dataGridView1);
            }
            else
            {
                MessageBox.Show("���ʧ��", "��ʾ��Ϣ");
            }
            #endregion

        }

        /// <summary>
        /// �ж�һ��TextBox.Text���Ƿ�Ϊ��
        /// </summary>
        public bool ISEmpty(string text, string name)
        {
            if (text.Trim().Length==0)
            {
                MessageBox.Show($"{name}Ϊ��", "��ʾ��Ϣ");
                return true;
            }
            else
            {
                return false;
            }
        }

        //�رմ���
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ѡ������Ƭ

        /// <summary>
        /// ѡ����Ƭ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title="ѡ����Ƭ";
            openFileDialog.Filter="�����ļ�|*.*|��Ƭ|*.jgp";
            openFileDialog.InitialDirectory=@"F:\����";
            openFileDialog.Multiselect=false;
            DialogResult ds = openFileDialog.ShowDialog();
            if (ds==DialogResult.OK)
            {
                this.pbStu.Image=Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// ��ѡ�����Ƭ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.pbStu.Image= null;
        }

 
        /// <summary>
        /// �Զ�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dataGridView1,e);
        }
    }
}