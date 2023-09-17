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

namespace ѧ������UI
{
    public partial class FrmEditStudent : Form
    {
        private ClassDAL ClassDAL = new ClassDAL();
        List<ClassinfosModel> listclas = new List<ClassinfosModel>();
        private StudentDAL studal = new StudentDAL();
        public FrmEditStudent()
        {
            InitializeComponent();
            this.listclas= ClassDAL.GetClass();
            this.cboClassName.DataSource =this. listclas;
            this.cboClassName.ValueMember = "classid";
            this.cboClassName.DisplayMember="classname";
            this.cboClassName.SelectedIndex = -1;
        }
        /// <summary>
        /// ��ѧ������ϸ������봰��
        /// </summary>
        /// <param name="stu"></param>
        public FrmEditStudent(StudentsinfosModel stu) : this()
        {
            //ͨ�����캯�������е�����ȫ����������
            this.txtStudentName.Text=stu.Studentname;
            if (stu.Gender=="��")
            { this.rdoMale.Checked=true; }
            else
            { this.rdoFemale.Checked=true; }
            this.txtStudentId.Text= stu.Studentid.ToString();
            this.dtpBirthday.Text=stu.Birthday.ToShortDateString();
            this.txtStudentIdNo.Text=stu.Studentidno;
            this.txtCardNo.Text=stu.Cardno;
            this.cboClassName.Text=stu.ClassName;
            this.txtPhoneNumber.Text=stu.Phonenumber;
            this.txtAddress.Text=stu.Studentaddress;
            this.pbStu.Image=stu.Stuimage=="" ? Image.FromFile("ͼƬ1.png") : (Image)new SerializeObjectToString().DeserializeObject(stu.Stuimage);

            this.txtStudentId.Enabled=false;
        }
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

        //�ύ�޸�
        private void btnModify_Click(object sender, EventArgs e)
        {
            //���޸�֮ǰ����Ҫ�ж��Ƿ�Ϊ��
            #region ���ѧԱ֮ǰ���ж�
            //�����ѧԱ֮ǰ����Ҫȷ�������������֤���ֻ��ţ�
            //����ȷ�����֤�ź����֤��������ͬ�ġ�
            //�ж�����
            if (this.txtStudentName.Text.Trim().Length==0)
            {
                MessageBox.Show("û����������","��ʾ��Ϣ");
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
            if (this.txtStudentIdNo.Text.Trim().Length==0)
            {
                MessageBox.Show("���֤Ϊ��", "��ʾ��Ϣ");
                return;
            }

            //����Ҫ�ж����֤��Ϣ��������
            if (!DataValidate.IsInteger(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("���֤����������", "��ʾ��Ϣ");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //�ж����֤�ϵĳ������ں�ѡ��������Ƿ�һ��
            string time = Convert.ToDateTime(this.dtpBirthday.Text).ToString("yyyyMMdd");
            if (!this.txtStudentIdNo.Text.Contains(time))
            {
                MessageBox.Show("���֤��ѡ��ĳ������ڣ���ƥ��", "��ʾ��Ϣ");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //�ж����֤�Ƿ񳤶�����Ҫ��
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("���֤���Ȳ���", "��ʾ��Ϣ");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            //�ж�����Ƿ�����18~35��
            int age = DateTime.Now.Year-Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age<18 ||age>35)
            {
                MessageBox.Show("���䳬��Ҫ��", "��ʾ��Ϣ");
                return;
            }

            //��ͥסַ����Ϊ��
            if (this.txtAddress.Text.Trim().Length==0)
            {
                MessageBox.Show("��ͥ��ַΪ��", "��ʾ��Ϣ");
                return;
            }

            //���ڿ��ţ�����Ϊ�գ�����Ϊ������
            if (this.txtCardNo.Text.Trim().Length==0)
            {
                MessageBox.Show("���ڿ���Ϊ��", "��ʾ��Ϣ");
                return;
            }

            //�绰���벻��Ϊ��
            if (this.txtPhoneNumber.Text.Trim().Length==0)
            {
                MessageBox.Show("�绰���벻��Ϊ��","��ʾ��Ϣ");
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
            #endregion
            //�޸�֮��Ŀ��ڿ��ź����֤���Ƿ����
            if (studal.SelectStuORCard(this.txtCardNo.Text,this.txtStudentIdNo.Text)!=null)
            {
                MessageBox.Show("�޸ĵĿ��Ż������֤�ţ��Ѿ����������ݿ���");
                return;
            }
            int nums= studal.UpdateStu(Convert.ToInt32( this.txtStudentId.Text));
            if (nums!=0)
            {
                MessageBox.Show("�޸ĳɹ�", "�ɹ�");
                return;
            }
            else
            {
                MessageBox.Show("�޸�ʧ��", "ʧ��");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ѡ����Ƭ
        private void btnChoseImage_Click(object sender, EventArgs e)
        {

        }
    }
}