using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生管理Model;
using 学生管理Model.ExeEnd;
using 学生管理系统Common;

namespace 学生管理UI.Excel
{
    /// <summary>
    /// 打印有模板的Excel
    /// </summary>
    public class PrintStudentInfos
    {
        /// <summary>
        /// 通过datagridview打印学员详细信息
        /// </summary>
        /// <param name="stu"></param>
        /// <param name="path"></param>
        public void PrintExcel(AddObjectModel stu, string path)
        {
            Microsoft.Office.Interop.Excel.Application excelApp=new Microsoft.Office.Interop.Excel.Application();
            //连接对应的Excel的文件
            excelApp.Workbooks.Add(Environment.CurrentDirectory+ path);
            //得到Excel对应的Sheet表
            Microsoft.Office.Interop.Excel.Worksheet sheet = excelApp.Worksheets[1];

            //将学员的信息写入到Excel的模板表中
            //先判断学员是否有图片
            if (stu.Objstu.Stuimage.Trim().Length!=0)
            {
                Image image = (Image)new SerializeObjectToString().DeserializeObject(stu.Objstu.Stuimage);
                string stuImage = Environment.CurrentDirectory+ @"\student.jpg";
                if (File.Exists(stuImage))
                {
                    File.Delete(stuImage);
                }
                else
                {
                    //将图片存为路径
                    image.Save(stuImage);
                    sheet.Shapes.AddPicture(stuImage, Microsoft.Office.Core.MsoTriState.msoFalse,
                       Microsoft.Office.Core.MsoTriState.msoTrue, 0, 60, 90, 100);
                    File.Delete(stuImage);
                }
                //写入其他数据
                sheet.Cells[4, 4] = stu.Objstu.Studentid;
                sheet.Cells[4, 6]=stu.Objstu.Studentname;
                sheet.Cells[4, 8]=stu.Objstu.Gender;
                sheet.Cells[6, 4] = stu.Objstu.ClassName;
                sheet.Cells[6, 8] = stu.Objstu.Phonenumber;
                sheet.Cells[8, 4] = stu.Objstu.Studentaddress;
                //【6】打印预览
                excelApp.Visible = true;//可见
                excelApp.Sheets.PrintPreview(true);//预览
                                                   //【7】退出，释放对象，引用清空，也就是Mirosoft.Office.Interop.Excel.Application的对象无法自己释放资源
                excelApp.Quit();//退出Microsoft.offic.interop.Excel.Application
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);//清空
                excelApp = null;
            }
            else
            {
                    sheet.Shapes.AddPicture(@"F:\备份\C#项目\项目一学生管理系统\学生管理系统\学生管理系统UI\学生管理UI\bin\Debug\图片1.png", Microsoft.Office.Core.MsoTriState.msoFalse,
                       Microsoft.Office.Core.MsoTriState.msoTrue, 0, 60, 90, 100);
                    //写入其他数据
                    sheet.Cells[4, 4] = stu.Objstu.Studentid;
                    sheet.Cells[4, 6]=stu.Objstu.Studentname;
                    sheet.Cells[4, 8]=stu.Objstu.Gender;
                    sheet.Cells[6, 4] = stu.Objstu.ClassName;
                    sheet.Cells[6, 8] = stu.Objstu.Phonenumber;
                    sheet.Cells[8, 4] = stu.Objstu.Studentaddress;
                    //【6】打印预览
                    excelApp.Visible = true;//可见

                    excelApp.Sheets.PrintPreview(true);//预览
                    //【7】退出，释放对象，引用清空，也就是Mirosoft.Office.Interop.Excel.Application的对象无法自己释放资源
                    excelApp.Quit();//退出Microsoft.offic.interop.Excel.Application
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);//清空
                    excelApp = null;
            }
        }
    }
}
