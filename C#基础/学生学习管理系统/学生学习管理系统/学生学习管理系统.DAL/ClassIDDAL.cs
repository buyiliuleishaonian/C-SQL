using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生学习管理系统.Common.SQLHelper;
using 学生学习管理系统.Model;
namespace 学生学习管理系统.DAL
{
    /// <summary>
    /// 班级类
    /// </summary>
    public class ClassIDDAL
    {
        /// <summary>
        /// 查询出所有的班级，将其放在List集合里面
        /// </summary>
        /// <returns></returns>
        public   List<ClassIDModel> GetClassID()
        {
            //创建sql语句
            string sql = "select classid,classname from classinfos";
            //调用sqlhelper方法
            DataTable da = SqlHelper.GetDataTable(sql);
            List<ClassIDModel> list= new List<ClassIDModel>();
            foreach (DataRow dr in da.Rows) 
            {
                list.Add(new ClassIDModel()
                {
                    ClassID = Convert.ToInt32(dr["classid"]),
                    ClassName = dr["classname"].ToString()
                }) ;
            }
            return list;
        }


        /// <summary>
        /// 用table来获得班级信息
        /// </summary>
        /// <param name="classid"></param>
        /// <returns></returns>
        public DataTable ReadClass()
        {
            string sql = "select Classid,ClassName from Classinfos ";
            DataTable dt= SqlHelper.GetDataTable(sql);
            if (dt == null)
            {
                return null;
            }
            else
            {
                return dt;
            }
        }
    }
}
