using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理UI.Excel
{
    /// <summary>
    /// 将SQL中的数据通过DataGridView打印到没有模板的Excel文件中去
    /// </summary>
    public class DataExport
    {
        public bool PrintExcel(DataGridView dgv)
        {
            //创建Excel的工作簿
            Microsoft.Office.Interop.Excel.Application appExcel = new Microsoft.Office.Interop.Excel.Application();
            //创建Excel中的第一个表
            Microsoft.Office.Interop.Excel.Worksheet excelSheet = appExcel.Workbooks.Add().Worksheets[1];
            excelSheet.Cells[2, 2]="学员信息";
            excelSheet.Cells[2, 2].RowHeight=25;
            Microsoft.Office.Interop.Excel.Range range = excelSheet.get_Range("B2", "H2");
            range.Merge(0);//合并表头单元格
            range.Borders.Value = 1;//设置表格边框
            range.Font.Size = 15;
            //获得行列数
            int colcumCount = dgv.ColumnCount;//列
            int rowcount = dgv.RowCount;//行

            //显示列标题
            //将数据放入表格
            for (int i = 0; i<colcumCount; i++)
            {
                excelSheet.Cells[3, i+2]=dgv.Columns[i].HeaderText;
                excelSheet.Cells[3, i + 2].Borders.Value = 1;//设置单元格边线
                excelSheet.Cells[3, i + 2].RowHeight = 23;//设置单元格高度
            }
            //显示数据，从第四行，第二列开始
            //必须当完成一行之后，再去到下一行
            //就是for循环嵌套
            for (int i = 0; i <rowcount-1; i++)
            {
                for (int n = 0; n <colcumCount; n++)
                {
                    //得到每一行的所有列数据
                    excelSheet.Cells[i + 4, n + 2] = dgv.Rows[i].Cells[n].Value;
                    excelSheet.Cells[i+4, n+2].Borders.Value = 1;
                    excelSheet.Cells[i + 4, n + 2].RowHeight = 23;
                }
            }
            //设置列宽和数据一致
            excelSheet.Columns.AutoFit();
            //打印预览
            appExcel.Visible = true;//显示可见
            appExcel.Sheets.PrintPreview();//预览
            //释放对象
            appExcel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(appExcel);
            appExcel = null;
            return true;
        }
    }
}
