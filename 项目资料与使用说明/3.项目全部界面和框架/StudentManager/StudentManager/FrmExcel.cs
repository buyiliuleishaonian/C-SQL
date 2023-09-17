using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生学习管理系统UI
{
    public partial class FrmExcel : Form
    {
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
            
        }

        /// <summary>
        /// 保存数据之后直接关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
        }

     
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
        }
    }
}
