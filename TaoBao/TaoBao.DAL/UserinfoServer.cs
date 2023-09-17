<<<<<<< HEAD
﻿using SQLHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoBao.Models;

namespace TaoBao.DAL
{
    /// <summary>
    /// 数据访问层，访问数据库
    /// </summary>
     public  class UserinfoServer
    {
        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="usermodel"></param>
        /// <returns></returns>
        public bool Insert(UserInfoModel usermodel)
        {
            string sql = "insert into usersfos (userid,username,age,phone,password) values(@userid,@username,@age,@phone,@password)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@userid",usermodel.UserId),
                new SqlParameter("@username",usermodel.UserName),
                new SqlParameter("@age",usermodel.Age),
                new SqlParameter("@phone",usermodel.UserPhone),
                new SqlParameter("@password",usermodel.Password),
            };
             int number= SQLhelper.ExecuteNonQuery(sql,sp);
            return number > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserInfoModel Login(UserInfoModel model)
        {
            UserInfoModel userinfo = new UserInfoModel();
            string sql = @"select * from usersfos where userid=@userid and  username=@username";
            SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter("userid",model.UserId),
                    new SqlParameter("username",model.UserName)
                };
            DataRow dtrow = SQLhelper.GetDataRow(sql,paras);
            if(dtrow!=null)
            {
                userinfo.Age = (int)dtrow["age"];
                userinfo.UserName = dtrow["username"].ToString();
            }
            return userinfo;
        }

        /// <summary>
        /// 读取多个表，占用内存，内存中计算
        /// </summary>
        /// <returns></returns>
        public DataSet GetUserInfoALL()
        {
            string sql = "select *from  usersfos " +
                "select *from userwinform";
            DataSet ds = SQLhelper.GetDataSet(sql);
            return ds;
        }


        /// <summary>
        /// 读取单个表
        /// </summary>
        /// <returns></returns>
        public DataTable GetUserInfo()
        {
            string sql = "select * from  usersfos";
            DataTable dataTable = SQLhelper.DataTable(sql);
            return dataTable;
        }
    }
}
=======
﻿using SQLHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoBao.Models;

namespace TaoBao.DAL
{
    /// <summary>
    /// 数据访问层，访问数据库
    /// </summary>
     public  class UserinfoServer
    {
        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="usermodel"></param>
        /// <returns></returns>
        public bool Insert(UserInfoModel usermodel)
        {
            string sql = "insert into usersfos (userid,username,age,phone,password) values(@userid,@username,@age,@phone,@password)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@userid",usermodel.UserId),
                new SqlParameter("@username",usermodel.UserName),
                new SqlParameter("@age",usermodel.Age),
                new SqlParameter("@phone",usermodel.UserPhone),
                new SqlParameter("@password",usermodel.Password),
            };
             int number= SQLhelper.ExecuteNonQuery(sql,sp);
            return number > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserInfoModel Login(UserInfoModel model)
        {
            UserInfoModel userinfo = new UserInfoModel();
            string sql = @"select * from usersfos where userid=@userid and  username=@username";
            SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter("userid",model.UserId),
                    new SqlParameter("username",model.UserName)
                };
            DataRow dtrow = SQLhelper.GetDataRow(sql,paras);
            if(dtrow!=null)
            {
                userinfo.Age = (int)dtrow["age"];
                userinfo.UserName = dtrow["username"].ToString();
            }
            return userinfo;
        }

        /// <summary>
        /// 读取多个表，占用内存，内存中计算
        /// </summary>
        /// <returns></returns>
        public DataSet GetUserInfoALL()
        {
            string sql = "select *from  usersfos " +
                "select *from userwinform";
            DataSet ds = SQLhelper.GetDataSet(sql);
            return ds;
        }


        /// <summary>
        /// 读取单个表
        /// </summary>
        /// <returns></returns>
        public DataTable GetUserInfo()
        {
            string sql = "select * from  usersfos";
            DataTable dataTable = SQLhelper.DataTable(sql);
            return dataTable;
        }
    }
}
>>>>>>> 45f0c71 (new)
