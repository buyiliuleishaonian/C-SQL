using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生管理Model;
using 学生管理Model.ExeEnd;
using 学生管理系统Common;
using 学生管理系统Common.Excel;

namespace 学生学习管理DAL
{
    /// <summary>
    /// Excel的数据逻辑层
    /// </summary>
    public class ExcelDAL
    {
        public List<StudentsinfosModel> GetExcel(string path)
        {
            string sql = "select  * from [sheet1$]";//Excel文件中sheet表名必须带上$
            List<StudentsinfosModel> list = new List<StudentsinfosModel>();
            DataSet ds = ExcelHelper.GetDataSet(path,sql);
            foreach (DataRow dr in ds.Tables[0].Rows) 
            {
                list.Add(new StudentsinfosModel()
                {
                    Studentname=dr["姓名"].ToString(),
                    Gender=dr["性别"].ToString(),
                    Birthday=Convert.ToDateTime( dr["出生日期"]),
                    Cardno=dr["考勤卡号"].ToString(),
                    Studentidno=dr["身份证号"].ToString(),
                    Phonenumber=dr["电话号码"].ToString(),
                    Studentaddress=dr["家庭住址"].ToString(),
                    Classid=Convert.ToInt32( dr["班级编号"]),
                    Age=DateTime.Now.Year-Convert.ToDateTime(dr["出生日期"]).Year
                });
            }
            return list;
        }
    }
}
