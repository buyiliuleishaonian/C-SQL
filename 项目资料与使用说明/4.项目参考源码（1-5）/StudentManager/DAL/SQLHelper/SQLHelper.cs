﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;//引入读取配置文件类所在的命名空间

namespace DAL
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
    public class SQLHelper
    {
        private  static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        /// <summary>
        /// 执行增、删、改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                //写入系统日志

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 获取单一结果查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                //写入系统日志

                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 返回一个结果集的查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //写入系统日志

                conn.Close();
                throw ex;
            }
        }
    }
}
