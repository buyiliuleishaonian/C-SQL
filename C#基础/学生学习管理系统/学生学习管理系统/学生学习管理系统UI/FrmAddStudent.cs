using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 学生学习管理系统.Model;
using 学生学习管理系统.BLL;
using 学生学习管理系统.Common;
using 学生学习管理系统UI;
using System.Runtime.Remoting.Messaging;

namespace StudentManager
{
    public partial class FrmAddStudent : Form
    {
        //创建在这个窗体下班级的全局变量
        private ClassIDBLL classIDBLL = new ClassIDBLL();
        //创建在这个窗体下学生的信息的全局变量
        private StudnetBLL st = new StudnetBLL();
        //创建list集合将所有的学生信息添加进去
        List<StudentModel> liststu = new List<StudentModel>();

        public FrmAddStudent()
        {
            ClassIDBLL classIDBLL = new ClassIDBLL();
            InitializeComponent();
            this.cboClassName.DataSource = classIDBLL.GetClassID();
            //其两者都是对应集合中的属性，看你自己选择在下拉框中选择谁
            //两者都是一一对应的关系
            this.cboClassName.DisplayMember = "ClassName";//显示下拉框中的文本
            this.cboClassName.ValueMember = "ClassID";//显示下拉框中文本对应的属性
            this.cboClassName.SelectedIndex = -1;

            this.dataGridView1.AutoGenerateColumns = false;
        }
        //添加新学员
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 数据验证
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

            //输入的卡号和身份证号不能和数据库重复
            string[] str = new string[] { this.txtStudentIdNo.Text, this.txtCardNo.Text };
            if (StudnetBLL.BoolInStudent(str))
            {
                MessageBox.Show("学生表里面已经存在了身份证或者卡号");
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

            #region  添加学生
            StudentModel stuModel = new StudentModel()
            {
                StudentName = this.txtStudentName.Text,
                Gender = this.rdoMale.Checked ? "男" : "女",
                Bithday = Convert.ToDateTime(this.dtpBirthday.Text),
                StudentIdNo = this.txtStudentIdNo.Text,
                CardNO = this.txtCardNo.Text,
                StuImage = this.pbStu.Image != null ? new SerializeObjectToString().SerializeObject(this.pbStu.Image) : "",
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                PhoneNumber = this.txtPhoneNumber.Text,
                StudentAddress = this.txtAddress.Text,
                ClassID = Convert.ToInt32(this.cboClassName.SelectedValue)
            };
            int number = StudnetBLL.GetStu(stuModel);
            if (number > 1)
            {
                //同步显示添加的学员
                stuModel.ClassName = this.cboClassName.Text;
                stuModel.StudentID = number;
                this.liststu.Add(stuModel);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = this.liststu;
                #region 添加学员成功之后需要判断是否继续添加学员
                //询问是否继续添加,首先显示信息，之后生成按钮，表示继续还是结束
                try
                {
                    DialogResult result = MessageBox.Show("新学员添加成功", "是否继续添加", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //因为所有的文本框都存放在groupbox容器中
                        foreach (Control item in this.groupBox1.Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = "";
                            }
                            else if (item is RadioButton)
                            {
                                ((RadioButton)item).Checked = false;
                            }
                        }
                        //日期控件不用初始化
                        this.cboClassName.SelectedIndex = -1;
                        this.pbStu.Image = null;
                        this.txtStudentName.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("添加学员失败的原因" + ex.Message);
                }
                #endregion
            }
            else
            {
                MessageBox.Show("添加失败");
                return;
            }
            #endregion
        }

        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //选择新照片
        /// <summary>
        /// 选择图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            //创建打开文件夹对象
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"F:\wallhaven壁纸下载地";//打开文件夹的初始目录
            open.Title = "选择图片";//打开对话框的名字
            open.Filter = "所有文件|*.*|图片.jpg|";//可以选择文件的扩展名
            DialogResult result = open.ShowDialog();//通过打开文件夹的返回值
            if (result == DialogResult.OK)//当文件夹取消时，不给图片空间路径
            {
                //则将选择图片的路径给到图片控件
                pbStu.Image = Image.FromFile(open.FileName);
            }
        }

        /// <summary>
        /// 清除照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            pbStu.Image = null;
        }

        /// <summary>
        /// 添加行号，每次添加学员之后，都需呀重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dataGridView1,e);
        }
    }
}