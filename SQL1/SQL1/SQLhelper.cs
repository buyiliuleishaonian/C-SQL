<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL1
{
    public static class SQLhelper
    {

        //将数据库的定义数据字符串，写在App.config里面
        //通过引用using.system.configuration配置文件来调用
        //获取配置文件字符串
        //using原理类似 try catch
        //在执行之后，写控制台日志，文档日志，业务日志
        private static string sqlStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        /// <summary>
        /// 增对不同要求，输入不同的脚本程序，
        /// 执行增删改
        /// </summary>
        /// <param name="str">sql脚本代码</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string str,params SqlParameter[] paras)
        {
            int number = 0;
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(sqlStr))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand(str, sqlCon);
                    sqlCmd.Parameters.AddRange(paras);
                    number = sqlCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return number;
        }

        /// <summary>
        /// 将数据库里面任何一个表，第一行第一列显示出来
        /// 或者满足条件的任何一行都可以读取出来
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string str, params SqlParameter[] paras)//默认赋值为空，调用的时候可以不赋值也可以赋值
        {
            //params,只能写在一位数组之前，推荐使用
            //默认为空，在添加参数的时候，就需要判断paras是否为空
            object s = null;
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(sqlStr))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                    sqlcmd.Parameters.AddRange(paras);
                    s = sqlcmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return s;
        }

        /// <summary>
        /// 查询放回SQLdatareader
        /// </summary>
        /// <param name="str"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string str, params SqlParameter[] paras)
        {
            SqlDataReader sqlr = null;
            SqlConnection sqlcon = new SqlConnection(sqlStr);
            try
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                sqlcmd.Parameters.AddRange(paras);
                //将sqlconnection对象和sqldatareader对象关联起来，要不然
                //sqlconnection对象那个关闭数据连接
                //sqldatareader就无法连接到数据库
                //关联之后当sqldatareader对象关闭的，关闭sqlconnection对象连接的数据库
                sqlr = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sqlr;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL1
{
    public static class SQLhelper
    {

        //将数据库的定义数据字符串，写在App.config里面
        //通过引用using.system.configuration配置文件来调用
        //获取配置文件字符串
        //using原理类似 try catch
        //在执行之后，写控制台日志，文档日志，业务日志
        private static string sqlStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        /// <summary>
        /// 增对不同要求，输入不同的脚本程序，
        /// 执行增删改
        /// </summary>
        /// <param name="str">sql脚本代码</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string str,params SqlParameter[] paras)
        {
            int number = 0;
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(sqlStr))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand(str, sqlCon);
                    sqlCmd.Parameters.AddRange(paras);
                    number = sqlCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return number;
        }

        /// <summary>
        /// 将数据库里面任何一个表，第一行第一列显示出来
        /// 或者满足条件的任何一行都可以读取出来
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string str, params SqlParameter[] paras)//默认赋值为空，调用的时候可以不赋值也可以赋值
        {
            //params,只能写在一位数组之前，推荐使用
            //默认为空，在添加参数的时候，就需要判断paras是否为空
            object s = null;
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(sqlStr))
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                    sqlcmd.Parameters.AddRange(paras);
                    s = sqlcmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return s;
        }

        /// <summary>
        /// 查询放回SQLdatareader
        /// </summary>
        /// <param name="str"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string str, params SqlParameter[] paras)
        {
            SqlDataReader sqlr = null;
            SqlConnection sqlcon = new SqlConnection(sqlStr);
            try
            {
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                sqlcmd.Parameters.AddRange(paras);
                //将sqlconnection对象和sqldatareader对象关联起来，要不然
                //sqlconnection对象那个关闭数据连接
                //sqldatareader就无法连接到数据库
                //关联之后当sqldatareader对象关闭的，关闭sqlconnection对象连接的数据库
                sqlr = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sqlr;
        }
    }
}
>>>>>>> 45f0c71 (new)
