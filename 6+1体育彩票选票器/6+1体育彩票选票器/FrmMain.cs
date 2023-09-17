using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_1体育彩票选票器
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //当没有生成随机数时，无法调用某些按钮
            this.btnSelect.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnclear.Enabled = false;
            this.btnPrint.Enabled = false;
        }

        //创建选号器对象
        Selecttor sto1=new Selecttor();

        /// <summary>
        /// 关闭此窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 窗体最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMin_Click(object sender, EventArgs e)
        {
            //最小
            this.WindowState = FormWindowState.Minimized;
        }

        int number = 0;
        /// <summary>
        /// 窗体最大化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMax_Click(object sender, EventArgs e)
        {
            //最大化之后无法复原
            if (number == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                number++;
            }
            else if (number==1)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }


        //因为将窗体的边框，关闭之后无法移动窗体
        #region  拖动窗体的实现

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        #endregion


        /// <summary>
        /// 用来生成随即号码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRandom_Tick(object sender, EventArgs e)
        {
            ///这只是生成一组随机数
            string[] nums=sto1.RanNums();
            labNum1.Text = nums[0];
            labNum2.Text = nums[1];
            labNum3.Text = nums[2];
            labNum4.Text = nums[3];
            labNum5.Text = nums[4];
            labNum6.Text = nums[5];
            labNum7.Text = nums[6];
        }

        /// <summary>
        /// 生成随机彩票号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRandom_Click(object sender, EventArgs e)
        {
            this.timerRandom.Enabled = true ;
            this.btnRandom.Enabled = false;
            this.btnSelect.Enabled = true;
        }

        /// <summary>
        /// 确认选号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {

            GetLineNums();
        }

        /// <summary>
        /// 每次随机确认一行彩票号
        /// </summary>
        public   void GetLineNums()
        {
            this.timerRandom.Stop();//停止定时器
            string[] str = new string[7];
            str[0] =this.labNum1.Text;
            str[1] =this.labNum2.Text;
            str[2] =this.labNum3.Text;
            str[3] =this.labNum4.Text;
            str[4] =this.labNum5.Text;
            str[5] =this.labNum6.Text;
            str[6] =this.labNum7.Text;
            //之后将其这string[]存入到selecttor类中的selectNumbers的属性
            //因为是集合List<string[]>，无法将显示string[]
            //所以需要将其改为string类型
            sto1.SelectNumbers.Add(str);
            lbNumberList.Items.Clear();//清空
            lbNumberList.Items.AddRange(sto1.GetArray().ToArray());

          btnPrint.Enabled=  btnRandom.Enabled = btnSelect.Enabled = btnDelete.Enabled = btnclear.Enabled = true;
        }

        /// <summary>
        /// 手写号码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            GetShouxie();
            
        }
        public  void GetShouxie()
        {
            string[] nums = {
            this.txtNum1.Text,
            this.txtNum2.Text,
            this.txtNum3.Text,
            this.txtNum4.Text,
            this.txtNum5.Text,
            this.txtNum6.Text,
            this.txtNum7.Text
            };
            sto1.SelectNumbers.Add(nums);
            lbNumberList.Items.AddRange(sto1.GetArray().ToArray());
            btnRandom.Enabled = btnSelect.Enabled = btnDelete.Enabled = btnclear.Enabled = true; 
        }

        /// <summary>
        /// 随机生成，我指定组数的彩票号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                sto1.GetNums(Convert.ToInt32(txtArray.Text)-1);
                lbNumberList.Items.AddRange(sto1.GetArray().ToArray());
                btnclear.Enabled = btnDelete.Enabled = btnclear.Enabled = btnPrint.Enabled=true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source);
            }
        }

        /// <summary>
        /// 删除指定行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //先判断是否选中行和是否存在选号
            if (this.lbNumberList.Items.Count == 0 || this.lbNumberList.SelectedIndices == null)
            {
                return;
            }
            else
            {
                this.lbNumberList.Items.RemoveAt(this.lbNumberList.SelectedIndex);
            }
        }
        /// <summary>
        /// 清空所有选号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclear_Click(object sender, EventArgs e)
        {
            //清除所有选号
            this.lbNumberList.Items.Clear();
            btnclear.Enabled = btnDelete.Enabled = btnclear.Enabled = btnSelect.Enabled=false;
            labNum1.Text = labNum2.Text = labNum3.Text = labNum4.Text= labNum5.Text = labNum6.Text = labNum7.Text = 0.ToString();
        }

        /// <summary>
        /// 打印彩票
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string str = null ;
            for (int i = 0; i <lbNumberList.Items.Count; i++)
            {
                str += lbNumberList.Items[i].ToString()+"\r\n";
            }
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            using (FileStream file=new FileStream(@"F:\桌面\1.word",FileMode.OpenOrCreate,FileAccess.Write))
            {
                file.Write(buffer,0,buffer.Length);
                MessageBox.Show("打印成功");
            }
        }


    }
}
