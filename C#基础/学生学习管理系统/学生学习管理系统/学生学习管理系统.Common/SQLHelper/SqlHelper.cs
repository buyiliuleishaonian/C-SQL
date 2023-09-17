using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace 学生学习管理系统.Common.SQLHelper
{
    /// <summary>
    /// 访问sqlserver的通用类
    /// </summary>
    public class SqlHelper
    {
        //两者连接方式，一般当有多个数据库时用第二个
        //连接时，必须对应数据库的名称，服务器以及用户名和密码，是静态私有的
        private static string sqlstr = "server=.;uid=jgw;password=123456;database=学生学习系统管理DB";
        //还可以再ui层的中APP.config,创建一个<connectionString><数据库连接地址></connectionString>
        //再调用system.configuration框架，最后调用其方法
        private static string sqlStr = ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString;


        /// <summary>
        /// 判断连接是否成功
        /// </summary>
        public void GetConnection()
        {
            //连接sqlserver对应的数据库
            SqlConnection con = new SqlConnection(sqlstr);
            //打开数据库
            con.Open();
            //调用其命名
            SqlCommand cmd = con.CreateCommand();
            MessageBox.Show("连接成功");
            con.Close();
            MessageBox.Show("关闭连接");
        }


        /// <summary>
        /// 对于sql的增删改，是否成功进行显示
        /// </summary>
        /// <param name="str"></param>
        /// <param name="paras"></param>
        public static int GetExecteNonQuery(string str,params SqlParameter[]  param)
        {
            int number = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(sqlstr))
                {
                    //打开数据库
                    con.Open();
                    //创建sql命名对象
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.Parameters.AddRange(param);
                    //放回影响的行数将其返回
                    number = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("所删除的数据库已经被其他实体类调用啦");
                }
                else
                {
                    MessageBox.Show("删除学员对象发生数据异常+\r\n"+ex.Message);
                }
            }
           
            return number;
        }

        /// <summary>
        /// 对于查询没有要求，就返回查询得到的表的第一行
        /// 有要求，就按满足要求的表的第一行读取出去
        /// </summary>
        /// <param name="str"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object GetExecuteeScalar(string str,params SqlParameter[] param)
        {
            object ob = null;
            try
            {
                using (SqlConnection con = new SqlConnection(sqlstr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.Parameters.AddRange(param);
                    //如果读取表的信息，没有限制，就只读取其中的第一行的所有数据
                    ob = cmd.ExecuteScalar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ob;
        }

        /// <summary>
        /// 读取按着要求得到的表，产生一个虚拟表
        /// </summary>
        /// <param name="str"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static SqlDataReader GetSqlReader(string str,params SqlParameter[] param)
        {
            SqlDataReader r = null;
            try
            {
                using (SqlConnection con = new SqlConnection(sqlstr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.Parameters.AddRange(param);
                    //产生一个虚拟表，需要将sqlconnection和sqldatareaderd的对象关联
                    r = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
         return r;
        }

        /// <summary>
        /// 将读取的数据集或者表，存放在内存中
        /// </summary>
        /// <param name="str"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string str, params SqlParameter[] param)
        {
            DataSet ds = null;
            try
            {
                using (SqlConnection con = new SqlConnection(sqlstr))
                {

                    //on.Open();//可以不用打开，就填充一次数据集或者多个表的结果
                    //当打开数据库，可以多次填充数据集或者多个表的结果，但是
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.Parameters.AddRange(param);
                    //断开式连接
                    SqlDataAdapter sqldataadapter = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    //将查询的数据集全部填充到ds中，也就是填充到内存中
                    sqldataadapter.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        /// <summary>
        /// 读取一个表的数据，存放到虚拟表中
        /// </summary>
        /// <param name="str"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string str, params SqlParameter[] param)
        {
            DataTable da = null;
            try
            {
                using (SqlConnection con=new SqlConnection(sqlstr))
                {
                    //con.Open();
                    SqlCommand cmd = new SqlCommand(str,con);
                    cmd.Parameters.AddRange(param);
                    SqlDataAdapter sqldata=new SqlDataAdapter(cmd);
                    da=new DataTable();
                    sqldata.Fill(da);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return da;
        }

        /// <summary>
        /// 得到指定的一行
        /// </summary>
        /// <param name="str"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataRow GetDataRow(string str, params SqlParameter[] param)
        {
            DataTable dt = null;
            try
            {
                using (SqlConnection con = new SqlConnection(sqlstr))
                {
                    SqlCommand cmd = new SqlCommand(str,con);
                    cmd.Parameters.AddRange(param);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    dt=new DataTable();
                    sqlDataAdapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dt.Rows.Count>0)
            {
                //一般可以限制得到某行
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 查询数据库时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetDateTime()
        {
            return Convert.ToDateTime(GetExecuteeScalar("select getdate"));
        }
    } 
}
