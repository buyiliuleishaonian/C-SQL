using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生管理Model;
using 学生管理系统Common;

namespace 学生学习管理DAL
{
    /// <summary>
    /// 班级查询数据层
    /// </summary>
    public class ClassDAL
    {
        /// <summary>
        /// 放回所有的班级
        /// </summary>
        /// <returns></returns>
        public List<ClassinfosModel> GetClass()
        {
            string sql = "select classname,classid from classinfos";
            List<ClassinfosModel> list = new    List<ClassinfosModel>();
            DataTable dt=new DataTable();
            dt=SQLHelper.GetDataTable(sql);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new ClassinfosModel()
                {
                    Classname=item["classname"].ToString(),
                    Classid=Convert.ToInt32( item["classid"])
                });
            }
            return list;
        }
    }
}
