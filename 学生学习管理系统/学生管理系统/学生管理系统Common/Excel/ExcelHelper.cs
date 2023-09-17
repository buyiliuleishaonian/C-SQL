using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生管理系统Common.Excel
{
    /// <summary>
    /// 连接Excel表格
    /// </summary>
    public class ExcelHelper
    {
        //首先和SQL一样创建连接的服务器，和需要连接的Excle的文件，并且确定Excel中的表
        private static string connectExcel = "Provider=Microsoft.ACE.OLEDB.12.0;Data source={0};Extended Properties=\"Excel 12.0;HDR=YES;\"";

        /// <summary>
        /// 对于Excel表格增删改查
        /// </summary>
        /// <param name="path"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int GetExecuteNonQuery(string path,string sql)
        {
            try
            {
                //创建连接Excel的对象
                OleDbConnection con = new OleDbConnection(string.Format(connectExcel, path));
                OleDbCommand cmd = new OleDbCommand(sql, con);
                int nums = cmd.ExecuteNonQuery();
                return nums;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 读取Excel表中满足要求的第一行第一列
        /// </summary>
        /// <param name="path"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static object GetExecuteScalar(string path,string sql)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(string.Format(connectExcel, path));
                OleDbCommand cmd = new OleDbCommand(sql, con);
                object obj = cmd.ExecuteScalar();
                return obj;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);    
            }
        }

        /// <summary>
        /// 查询Excel中的多张表
        /// </summary>
        /// <param name="path"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataSet GetDataSet(string path,string sql)
        {
            DataSet ds=new DataSet();
            try
            {
                OleDbConnection con = new OleDbConnection(string.Format(connectExcel, path));
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataAdapter oledt = new OleDbDataAdapter(cmd);
                oledt.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }
        }
    }
}
