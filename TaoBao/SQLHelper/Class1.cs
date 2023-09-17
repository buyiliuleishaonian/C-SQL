<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLHelper
{
    public class Class1
    {
        private static string sql = "server=.;uid=buyiliuleishaonian;password=jgw5201314;database=tbdb";

        /// <summary>
        /// 显示增删改，影响的行数
        /// </summary>
        /// <param name="str">脚本程序</param>
        /// <param name="paras">用户输入参数化</param>
        /// <returns></returns>
        public static  int  ExecuteNonQuery(string str ,params SqlParameter[] paras)
        {
            int number =0;
            using (SqlConnection sqlcon = new SqlConnection(sql))
            {
                try
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                    sqlcmd.Parameters.AddRange(paras);
                    number = sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return number;
        }


        /// <summary>
        /// 一般用于查询一个表的第一行第一列
        /// 也可以在脚本程序里面限制
        /// </summary>
        /// <param name="str">脚本程序</param>
        /// <param name="paras">将用户输入的参数化</param>
        /// <returns></returns>
        public static string ExecuteScalar(string str,params SqlParameter[] paras)
        {
            object s = null;
            using (SqlConnection sqlcon=new SqlConnection(sql))
            {
                try
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                    sqlcmd.Parameters.AddRange(paras);
                    s = sqlcmd.ExecuteScalar();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return s.ToString();
        }

        /// <summary>
        /// 根据脚本输出每一行的数据
        /// </summary>
        /// <param name="str">脚本</param>
        /// <param name="paras">用户输入的where要求</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string str,params SqlParameter[] paras)
        {
            SqlDataReader sqlr = null;
            try
            {
                SqlConnection sqlcon = new SqlConnection(sql);
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                sqlcmd.Parameters.AddRange(paras);
                sqlr = sqlcmd.ExecuteReader();
            }
            catch(Exception ex)
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLHelper
{
    public class Class1
    {
        private static string sql = "server=.;uid=buyiliuleishaonian;password=jgw5201314;database=tbdb";

        /// <summary>
        /// 显示增删改，影响的行数
        /// </summary>
        /// <param name="str">脚本程序</param>
        /// <param name="paras">用户输入参数化</param>
        /// <returns></returns>
        public static  int  ExecuteNonQuery(string str ,params SqlParameter[] paras)
        {
            int number =0;
            using (SqlConnection sqlcon = new SqlConnection(sql))
            {
                try
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                    sqlcmd.Parameters.AddRange(paras);
                    number = sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return number;
        }


        /// <summary>
        /// 一般用于查询一个表的第一行第一列
        /// 也可以在脚本程序里面限制
        /// </summary>
        /// <param name="str">脚本程序</param>
        /// <param name="paras">将用户输入的参数化</param>
        /// <returns></returns>
        public static string ExecuteScalar(string str,params SqlParameter[] paras)
        {
            object s = null;
            using (SqlConnection sqlcon=new SqlConnection(sql))
            {
                try
                {
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                    sqlcmd.Parameters.AddRange(paras);
                    s = sqlcmd.ExecuteScalar();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return s.ToString();
        }

        /// <summary>
        /// 根据脚本输出每一行的数据
        /// </summary>
        /// <param name="str">脚本</param>
        /// <param name="paras">用户输入的where要求</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string str,params SqlParameter[] paras)
        {
            SqlDataReader sqlr = null;
            try
            {
                SqlConnection sqlcon = new SqlConnection(sql);
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                sqlcmd.Parameters.AddRange(paras);
                sqlr = sqlcmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sqlr;
        }
    }
}
>>>>>>> 45f0c71 (new)
