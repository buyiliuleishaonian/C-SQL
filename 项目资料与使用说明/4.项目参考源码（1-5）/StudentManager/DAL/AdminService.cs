using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 管理员数据访问类
    /// </summary>
    public class AdminService
    {
        /// <summary>
        /// 根据用户名或密码登录
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public Admin AdminLogin(Admin objAdmin)
        {
            string sql = "select AdminName from Admins where LoginId={0} and LoginPwd='{1}'";
            sql = string.Format(sql, objAdmin.LoginId, objAdmin.LoginPwd);
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                if (objReader.Read())
                {
                    objAdmin.AdminName = objReader["AdminName"].ToString();
                }
                else
                {
                    objAdmin = null;
                }
                objReader.Close();
                return objAdmin;
            }
            catch (Exception ex)
            {
                throw new Exception("数据访问发生异常：" + ex.Message);
            }           
        }
    }
}
