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
    /// 管理员类的数据层
    /// </summary>
    public class AdminDAL
    {
        /// <summary>
        /// 通过管理员的账号和密码，来查询对应管理员所有信息
        /// </summary>
        /// <param name="uid">管理员账号</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public AdminsModel GetAdmin(string uid,string pwd)
        {
            string sql = "select username,password,adminname from admins " +
                " where password='{0}' and username={1}";
            sql=string.Format(sql, pwd, uid);
            DataRow dr = SQLHelper.GetDataRow(sql);
            AdminsModel adminsModel = new AdminsModel();
            if (dr != null)
            {
                adminsModel.Username = Convert.ToInt32(dr["username"]);
                adminsModel.Password = dr["password"].ToString();
                adminsModel.Adminname = dr["adminname"].ToString();
            }
            else
            {
                adminsModel = null;
            }
            return adminsModel;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="oldpwd"></param>
        /// <param name="newpwd"></param>
        /// <returns></returns>
        public int UpdateAdmin(string oldpwd,string newpwd,int userName)
        {
            string sql = "update admins" +
                " set  password='{0}'" +
                " where password='{1}' and username='{2}'";
            sql=string.Format(sql, newpwd,oldpwd,userName);
            int num = SQLHelper.GetExecuteNonQuery(sql);
            return num;
        }
    }
}
