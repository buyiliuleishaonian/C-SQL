using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using 学生学习管理系统.Model;
using 学生学习管理系统.BLL;
using 学生学习管理系统.Common;

namespace StudentManager
{
    public partial class FrmEditStudent : Form
    {
        public ClassIDBLL classbll = new ClassIDBLL();

        public StudnetBLL st=new StudnetBLL();

        public FrmEditStudent()
        {
            //需要初始化班级
            InitializeComponent();
            this.cboClassName.DataSource = classbll.GetClassID();
            this.cboClassName.ValueMember = "ClassID";
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.SelectedIndex = -1;
        }

        /// <summary>
        /// 将详细的学员信息导入到窗体
        /// </summary>
        /// <param name="objstudent"></param>
        public FrmEditStudent(StudentModel objstudent) : this()
        {
            this.txtStudentId.Text = objstudent.StudentID.ToString();
            this.txtStudentName.Text = objstudent.StudentName;
            if (objstudent.Gender == "男")
            {
                this.rdoMale.Checked = true;
            }
            else
            {
                this.rdoFemale.Checked = true;
            }
            this.dtpBirthday.Text = objstudent.Bithday.ToShortDateString();
            this.txtStudentIdNo.Text = objstudent.StudentIdNo;
            this.txtCardNo.Text = objstudent.CardNO;
            this.txtAddress.Text = objstudent.StudentAddress;
            this.txtPhoneNumber.Text = objstudent.PhoneNumber;
            this.pbStu.Image = objstudent.StuImage.Trim().Length != 0 ?
                (Image)new SerializeObjectToString().DeserializeObject(objstudent.StuImage) :
                null;
            this.cboClassName.Text = objstudent.ClassName;
        }

        //提交修改
        private void btnModify_Click(object sender, EventArgs e)
        {
            //在修改确认前，需要验证所有的数据没有问题
            #region 数据验证，考勤卡号和身份证号需要特殊判断
            if (this.txtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("学生姓名不能为空");
                this.txtStudentName.Focus();
                return;
            }
            if (this.txtStudentIdNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("身份证不能为空");
                this.txtStudentIdNo.Focus();
                return;
            }
            if (this.txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("手机号码不能为空");
                this.txtPhoneNumber.Focus();
                return;
            }
            if (this.txtCardNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("卡号不能为空");
                this.txtCardNo.Focus();
                return;
            }
            if (this.txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("家庭住址不能为空");
                this.txtAddress.Focus();
                return;
            }
            if (this.cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("班级不能为空");
                this.cboClassName.Focus();
                return;
            }
            if (this.pbStu.Image == null)
            {
                MessageBox.Show("学生图像不能为空");
                this.btnChoseImage.Focus();
            }
            if (this.txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("手机号码不能为空");
                this.txtPhoneNumber.Focus();
                return;
            }
            if (!this.rdoMale.Checked && !this.rdoFemale.Checked)
            {
                MessageBox.Show("请选择性别");
                this.rdoFemale.Focus();
                return;
            }
            //年龄限定18~35，用电脑运行程序的时间，减去所选择的时间
            //或者利用数据库的时间，减去选择的时间
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if (age > 35 || age < 18)
            {
                MessageBox.Show("年龄不符合要求");
                return;
            }
            //身份证格式的验证，用正则表达式来，判断身份证格式
            if (!DataValidate.IsIdentityCard(this.txtStudentIdNo.Text))
            {
                MessageBox.Show("身份证格式不对");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }
            //验证身份证和出生日期是否对的上，将选择的日期改为字符串的格式，
            //通过字符串包含的方法来确定是否对的上
            string drithday = Convert.ToDateTime(this.dtpBirthday.Text).ToString("yyyyMMdd");
            if (!this.txtStudentIdNo.Text.ToString().Contains(drithday))
            {
                MessageBox.Show("身份证和生日不符");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }

            if (StudnetBLL.BoolInStudent(this.txtStudentIdNo.Text,this.txtCardNo.Text))
            {
                MessageBox.Show("别的学员已存在此身份证","请重新修改身份证");
                this.txtStudentIdNo.SelectAll();
                this.txtStudentIdNo.Focus();
                return;
            }
           

            //验证卡号必须是正整数
            if (!DataValidate.IsInteger(this.txtCardNo.Text))
            {
                MessageBox.Show("卡号必须是正整数");
                this.txtCardNo.SelectAll();
                this.txtCardNo.Focus();
                return;
            }
            #endregion

            #region  添加数据
            StudentModel stuModel = new StudentModel()
            {
                StudentID = Convert.ToInt32(this.txtStudentId.Text),
                StudentName = this.txtStudentName.Text,
                Gender = this.rdoMale.Checked == true ? "男" : "女",
                Bithday = Convert.ToDateTime(this.dtpBirthday.Text),
                StudentIdNo = this.txtStudentIdNo.Text,
                CardNO = this.txtCardNo.Text,
                StudentAddress = this.txtAddress.Text,
                PhoneNumber = this.txtPhoneNumber.Text,
                StuImage = this.pbStu.Image != null ?
                new SerializeObjectToString().SerializeObject(this.pbStu.Image) : null,
                ClassID = Convert.ToInt32( this.cboClassName.SelectedValue),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year
            };
            #endregion
            if (st.UpdateStuinfo(stuModel))
            {
                MessageBox.Show("修改成功");
                this.DialogResult= DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("修改失败");
            }
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //选择照片
        /// <summary>
        /// 选择照片
        /// </summary>
        /// <param name="sender"></param>dada
        /// <param name="e"></param>
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择图片";
            openFileDialog.InitialDirectory = @"F:\wallhaven壁纸下载地";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "所有文件|*.*";
            DialogResult diaresult = openFileDialog.ShowDialog(); 
            if(diaresult==DialogResult.OK)
            {
                this.pbStu.Image=Image.FromFile( openFileDialog.FileName);
            }
        }
    }
}