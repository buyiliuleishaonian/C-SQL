using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 学生学习管理DAL;
using 学生管理Model;
using 学生管理系统Common;

namespace 学生管理UI
{
    public partial class FrmExcel : Form
    {
        private ExcelDAL exdal = new ExcelDAL();

        private List<StudentsinfosModel> stulist = new List<StudentsinfosModel>();

        private StudentDAL stuDal= new StudentDAL();
        public FrmExcel()
        {
            InitializeComponent();
            //不自动生成列
            this.dataGridView1.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 从外部得到Excel表的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory=@"F:\桌面";
            ofd.Title="选择Excel文件";
            ofd.Filter="Excel文件|*.xlsx";
            ofd.Multiselect=false;
            DialogResult result = ofd.ShowDialog();
            if (result==DialogResult.OK)
            {
                this.stulist= exdal.GetExcel(ofd.FileName);
                this.dataGridView1.DataSource=null;
                this.dataGridView1.DataSource=this.stulist;
                new DataGridViewStyle().DgvStyle2(this.dataGridView1);
                return;
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 保存数据之后直接关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount!=0)
            {
                if (this.stuDal.InsertExcelStu(this.stulist))
                {
                    MessageBox.Show("添加成功", "成功");
                    return;
                }
            }
            else
            {
                return; 
            }
        }


        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dataGridView1, e);
        }
    }
}
