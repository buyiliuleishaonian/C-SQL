using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生学习管理系统.Common.SQLHelper;
using 学生学习管理系统.Model;

namespace 学生学习管理系统.DAL
{
    /// <summary>
    /// 管理员访问表类
    /// </summary>
    public class AdminDAL
    {
        //1、方法，首先要确定再模块内部使用还是外部使用，访问修饰符
        //2、方法返回值，意味调用者，返回的具体数值，需要判断，返回值
        //访问修饰符>返回值（对象Model中对应的类)>参数(对象)

        /// <summary>
        /// 根据账号和密码，查询管理员数据库
        /// </summary>
        /// <param name="objAdmin">包含账号和密码的管理员</param>
        /// <returns>返回管理员名字</returns>
        public  static AdmisModel GetAdminLogin(AdmisModel objAdmin)
        {
            //1、sql语句
            string sql = "select adminname from admins where username=@id and password=@pwd ";
            //将查询语句的限制参数化
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("id",objAdmin.LogInId),
                new SqlParameter("pwd",objAdmin.Logirpwd)
            };
            //还有一种发方法是
            string sql1 = "select adminname from admins where username={0} and password='{1}'";//因为密码是字符串必须使用单引号
            sql1 = string.Format(sql1,objAdmin.LogInId,objAdmin.Logirpwd);//也是将其限制的参数化

            //2、调用通用数据访问类
            DataRow dataRow = SqlHelper.GetDataRow(sql,sp);

            //3、返回结果
            if (dataRow != null)
            {
                objAdmin.AdminName = dataRow["adminname"].ToString();
                return objAdmin;
            }
            else
            {
                return null;
            }
            //if (sqlread.Read())
            //{
            //    objAdmin.AdminName = sqlread["adminname"].ToString();
            //}
            //else
            //{
            //    objAdmin = null;
            //}
            //return  objAdmin;
        }


        /// <summary>
        /// 修改管理员密码
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public static int SetLogPwd(AdmisModel objAdmin)
        {
            //sql语句
            string sql = "update Admins set password=@pwd  where adminname=@name ";
            SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("pwd",objAdmin.Logirpwd),
                    new SqlParameter("name",objAdmin.AdminName)
                };
            //调用sqlhelper方法
            int number = SqlHelper.GetExecteNonQuery(sql,sp);
            //这里不需要验证旧密码是否正确，因为已经在输入旧密码的地方，program.adminModel
            //就已经确认旧密码输入是否正确
            return number;
        }
    }
}
