<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Permissions;
namespace SQL1
{
    public struct A
    {
        public int _x;
        public da _da;
    }
    public enum da
    {
        男,
        女
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //很多代码都是重复的，冗余代码，数据冗余
            //添加，删除，修改，查询，希望以后不管操作任何表，都可以重复使用
            //数据库帮助类(DBheper,SQLhelper)
            UserAdd();
            Console.ReadKey();
        }

        /// <summary>
        /// 连接sql数据库
        /// </summary>
        public static void Connect()
        {
            //访问数据库
            //步骤一：定义数据库连接字符串，包含：定义服务器名称，数据库名，用户名user id，密码 pwd,不区分大小写
            //string sqlStr = "data source=.;initial catalog=jgwnameDB;user id=buyiliuleishaonian;pwd=jgw5201314";
            string sqlStr = "data source=192.168.1.122,1433;uid=buyiliuleishaonian;pwd=jgw5201314;database=jgwnameDB";
            //步骤二：创建访问数据库的对象，需要初始化。
            //即使没有大小限制，占用资源必须要释放的
            SqlConnection sqlcon = new SqlConnection(sqlStr);
            //步骤三：打开数据库连接
            sqlcon.Open();
            Console.WriteLine("连接成功");
            //步骤四：创建执行脚本的对象，支持存储过程，支持sql语句，支持表名
            //也可以执行SQLconmmand类，创建对象的commandtext属性，输入多行数据
            //最后：关闭数据库连接，释放链接资源
            sqlcon.Close();
            Console.WriteLine("关闭连接");
            Console.ReadKey();
        }

        /// <summary>
        /// 增删改，返回受影响行数
        /// </summary>
        public static void Insert()
        {
            //访问数据库
            //步骤一：定义数据库连接字符串，包含：定义服务器名称，数据库名，用户名user id，密码 pwd,不区分大小写
            //string sqlStr = "data source=.;initial catalog=jgwnameDB;user id=buyiliuleishaonian;pwd=jgw5201314";
            string sqlStr = "data source=.;uid=buyiliuleishaonian;pwd=jgw5201314;database=jgwnameDB";
            //步骤二：创建访问数据库的对象，需要初始化。
            //即使没有大小限制，占用资源必须要释放的
            SqlConnection sqlcon = new SqlConnection(sqlStr);
            //步骤三：打开数据库连接
            sqlcon.Open();
            Console.WriteLine("连接成功");
            //步骤四：创建执行脚本的对象，支持存储过程，支持sql语句，支持表名
            string sql = "insert into classinfos (classname1) values('SQL脚本')";
            Executnonquery(sql, sqlcon);
            //也可以执行SQLconmmand类，创建对象的commandtext属性，输入多行数据
            //最后：关闭数据库连接，释放链接资源
            sqlcon.Close();
            Console.WriteLine("关闭连接");
            Console.ReadKey();
        }

        /// <summary>
        /// 查询执行的增删改，执行了几行
        /// </summary>
        /// <param name="str"></param>
        public static void Executnonquery(string str, SqlConnection sqlcon)
        {
            //创建sqlcommand对象，执行类中的方法
            SqlCommand cmd = new SqlCommand(str, sqlcon);
            //返回修改了几行
            int num = cmd.ExecuteNonQuery();
            //不论程序多复杂，都是增删改查
            if (num > 0)
            {
                Console.WriteLine("修改了{0}行", num);
            }
            else
            {
                Console.WriteLine("修改为0");
            }
        }

        /// <summary>
        /// 查询用户，为防止用户胡乱输入，所以采用参数化，将用户的输入全变为字符串
        /// </summary>
        public static void UserAdd()
        {
            //查询一个数据
            //string sql = "select count(1) from userinfos where username='username' and passwrod='123456'";
            //不确定要不要写入单引号',所以采用参数化
            string sql = @"select  * from  userinfos where username=@user and password=@paw";
            //可以是用户输入的
            string user = "wenqiaocui";
            string paw = "123456";
            //参数化 sqlParameter 是参数化
            SqlParameter[] paras = new SqlParameter[]
            {
               new SqlParameter("@user",user),
               new SqlParameter("@paw",paw)
            };//初始化器
            string[] str = new string[]
            {
                ""
            };//如果是字符串，写上双引号就可以初始化，相当于赋初始值
            object s = SQLhelper.ExecuteScalar(sql, paras);
            int number = Convert.ToInt32(s);
            Console.Write(number);
        }

        /// <summary>
        /// 查询多行多列
        /// </summary>
        public static void SelectALL()
        {
            List<Classinfo> class2 = new List<Classinfo>();
            //什么方式？每执行一次读取一行，一行接着下一行的读取，返回每行的所有数据。
            string sqlSQL = "data source=192.168.1.122,1433;uid=buyiliuleishaonian;pwd=jgw5201314;database=jgwnamedb";
            using (SqlConnection sqlCon = new SqlConnection(sqlSQL))
            {
                Classinfo class1 = new Classinfo();
                try
                {
                    sqlCon.Open();
                    string sqlselect = "select  * from Classinfos";
                    //只执行一个sqlserver语句
                    SqlCommand sqlcmd = new SqlCommand(sqlselect, sqlCon);
                    //将表中的所有行读取出来，只不过每次只读取一行
                    using (SqlDataReader sqlReader = sqlcmd.ExecuteReader())
                    {
                        //直到读取不到数据为止
                        while (sqlReader.Read())
                        {
                            class1.Classid = (int)sqlReader["jgwshcoolid"];
                            class1.ClassName = sqlReader["classname1"].ToString();
                            Console.WriteLine("{0},{1}", class1.Classid, class1.ClassName);
                            class2.Add(class1);
                        }
                    }
                }
                catch (Exception ex)//异常捕获
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// 读取第一行第一列
        /// </summary>
        public static void Select()
        {
            string sqlSQL = "data source=192.168.1.122,1433;uid=buyiliuleishaonian;pwd=jgw5201314;database=jgwnamedb";
            using (SqlConnection sqlCon = new SqlConnection(sqlSQL))
            {
                try
                {
                    sqlCon.Open();
                    string sqlselect = "select  * from Classinfos";
                    //只执行一个sqlserver语句
                    SqlCommand sqlcmd = new SqlCommand(sqlselect, sqlCon);
                    //将表中的所有行读取出来，只不过每次只读取一行
                    object ob = sqlcmd.ExecuteScalar();
                }
                catch (Exception ex)//异常捕获
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// 读取指定一行的，所有数据
        /// 需要在sql脚本代码，指定哪一行，对于用户输入的限制，需要参数化
        /// </summary>
        public static void SelectAll()
        {
            List<Userinfo> userlist = new List<Userinfo>();
            //这里不能查询伪列
            string sql = @"select  *  from  test1 where  name=@user and   password=@pwd  ";
            string user = "admin";
            string pwd = "123456";
            string userid = "1";
            //一般都是用户查询自己的账号，输入字符串
            SqlParameter[] sqlpar = new SqlParameter[]
                {
                    new SqlParameter("@user",user),
                    new SqlParameter("@pwd",pwd),
                    new SqlParameter("@userid",userid)
                };
            using (SqlDataReader sqlread = SQLhelper.ExecuteReader(sql,sqlpar))
            {
                //将每一行都读取出来
                if (sqlread.Read())
                {
                    Userinfo us = new Userinfo();
                    us.UserID = (int)sqlread["id"];
                    us.UserName = sqlread["name"].ToString();
                    us.Password = sqlread["password"].ToString();
                    Console.WriteLine("{0},{1}  {2}", us.UserID, us.UserName,us.Password);
                    userlist.Add(us);
                }
            }
        }

        /// <summary>
        /// 查询多行多列
        /// </summary>
        public static void ALL()
        {
            List<Userinfo> userlist = new List<Userinfo>();
            //这里不能查询伪列
            string sql = @"select  *  from  test1  ";
            //一般都是用户查询自己的账号，输入字符串
            using (SqlDataReader sqlread = SQLhelper.ExecuteReader(sql))
            {
                //将每一行都读取出来
                while (sqlread.Read())
                {
                    Userinfo us = new Userinfo();
                    us.UserID = (int)sqlread["id"];
                    us.UserName = sqlread["name"].ToString();
                    us.Password = sqlread["password"].ToString();
                    Console.WriteLine("{0},{1}  {2}", us.UserID, us.UserName, us.Password);
                    userlist.Add(us);
                }
            }
        }


        /// <summary>
        /// 判断插入字符串，是个否可以用于查询。
        /// </summary>
        public static void Test()
        { 
            //当采用拼接字符串的时候，会可能因为某些特殊的原因
            //写成的语句，满足SQL server查询条件，导致查询成功。
            string username = "admin",password="123456";
            //$表示将变量的值插入到字符串当中
            string sql = $@"select & from  test1 where  name='{username}' and  password='{password}' ";
            int number = SQLhelper.ExecuteNonQuery(sql);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Permissions;
namespace SQL1
{
    public struct A
    {
        public int _x;
        public da _da;
    }
    public enum da
    {
        男,
        女
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //很多代码都是重复的，冗余代码，数据冗余
            //添加，删除，修改，查询，希望以后不管操作任何表，都可以重复使用
            //数据库帮助类(DBheper,SQLhelper)
            UserAdd();
            Console.ReadKey();
        }

        /// <summary>
        /// 连接sql数据库
        /// </summary>
        public static void Connect()
        {
            //访问数据库
            //步骤一：定义数据库连接字符串，包含：定义服务器名称，数据库名，用户名user id，密码 pwd,不区分大小写
            //string sqlStr = "data source=.;initial catalog=jgwnameDB;user id=buyiliuleishaonian;pwd=jgw5201314";
            string sqlStr = "data source=192.168.1.122,1433;uid=buyiliuleishaonian;pwd=jgw5201314;database=jgwnameDB";
            //步骤二：创建访问数据库的对象，需要初始化。
            //即使没有大小限制，占用资源必须要释放的
            SqlConnection sqlcon = new SqlConnection(sqlStr);
            //步骤三：打开数据库连接
            sqlcon.Open();
            Console.WriteLine("连接成功");
            //步骤四：创建执行脚本的对象，支持存储过程，支持sql语句，支持表名
            //也可以执行SQLconmmand类，创建对象的commandtext属性，输入多行数据
            //最后：关闭数据库连接，释放链接资源
            sqlcon.Close();
            Console.WriteLine("关闭连接");
            Console.ReadKey();
        }

        /// <summary>
        /// 增删改，返回受影响行数
        /// </summary>
        public static void Insert()
        {
            //访问数据库
            //步骤一：定义数据库连接字符串，包含：定义服务器名称，数据库名，用户名user id，密码 pwd,不区分大小写
            //string sqlStr = "data source=.;initial catalog=jgwnameDB;user id=buyiliuleishaonian;pwd=jgw5201314";
            string sqlStr = "data source=.;uid=buyiliuleishaonian;pwd=jgw5201314;database=jgwnameDB";
            //步骤二：创建访问数据库的对象，需要初始化。
            //即使没有大小限制，占用资源必须要释放的
            SqlConnection sqlcon = new SqlConnection(sqlStr);
            //步骤三：打开数据库连接
            sqlcon.Open();
            Console.WriteLine("连接成功");
            //步骤四：创建执行脚本的对象，支持存储过程，支持sql语句，支持表名
            string sql = "insert into classinfos (classname1) values('SQL脚本')";
            Executnonquery(sql, sqlcon);
            //也可以执行SQLconmmand类，创建对象的commandtext属性，输入多行数据
            //最后：关闭数据库连接，释放链接资源
            sqlcon.Close();
            Console.WriteLine("关闭连接");
            Console.ReadKey();
        }

        /// <summary>
        /// 查询执行的增删改，执行了几行
        /// </summary>
        /// <param name="str"></param>
        public static void Executnonquery(string str, SqlConnection sqlcon)
        {
            //创建sqlcommand对象，执行类中的方法
            SqlCommand cmd = new SqlCommand(str, sqlcon);
            //返回修改了几行
            int num = cmd.ExecuteNonQuery();
            //不论程序多复杂，都是增删改查
            if (num > 0)
            {
                Console.WriteLine("修改了{0}行", num);
            }
            else
            {
                Console.WriteLine("修改为0");
            }
        }

        /// <summary>
        /// 查询用户，为防止用户胡乱输入，所以采用参数化，将用户的输入全变为字符串
        /// </summary>
        public static void UserAdd()
        {
            //查询一个数据
            //string sql = "select count(1) from userinfos where username='username' and passwrod='123456'";
            //不确定要不要写入单引号',所以采用参数化
            string sql = @"select  * from  userinfos where username=@user and password=@paw";
            //可以是用户输入的
            string user = "wenqiaocui";
            string paw = "123456";
            //参数化 sqlParameter 是参数化
            SqlParameter[] paras = new SqlParameter[]
            {
               new SqlParameter("@user",user),
               new SqlParameter("@paw",paw)
            };//初始化器
            string[] str = new string[]
            {
                ""
            };//如果是字符串，写上双引号就可以初始化，相当于赋初始值
            object s = SQLhelper.ExecuteScalar(sql, paras);
            int number = Convert.ToInt32(s);
            Console.Write(number);
        }

        /// <summary>
        /// 查询多行多列
        /// </summary>
        public static void SelectALL()
        {
            List<Classinfo> class2 = new List<Classinfo>();
            //什么方式？每执行一次读取一行，一行接着下一行的读取，返回每行的所有数据。
            string sqlSQL = "data source=192.168.1.122,1433;uid=buyiliuleishaonian;pwd=jgw5201314;database=jgwnamedb";
            using (SqlConnection sqlCon = new SqlConnection(sqlSQL))
            {
                Classinfo class1 = new Classinfo();
                try
                {
                    sqlCon.Open();
                    string sqlselect = "select  * from Classinfos";
                    //只执行一个sqlserver语句
                    SqlCommand sqlcmd = new SqlCommand(sqlselect, sqlCon);
                    //将表中的所有行读取出来，只不过每次只读取一行
                    using (SqlDataReader sqlReader = sqlcmd.ExecuteReader())
                    {
                        //直到读取不到数据为止
                        while (sqlReader.Read())
                        {
                            class1.Classid = (int)sqlReader["jgwshcoolid"];
                            class1.ClassName = sqlReader["classname1"].ToString();
                            Console.WriteLine("{0},{1}", class1.Classid, class1.ClassName);
                            class2.Add(class1);
                        }
                    }
                }
                catch (Exception ex)//异常捕获
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// 读取第一行第一列
        /// </summary>
        public static void Select()
        {
            string sqlSQL = "data source=192.168.1.122,1433;uid=buyiliuleishaonian;pwd=jgw5201314;database=jgwnamedb";
            using (SqlConnection sqlCon = new SqlConnection(sqlSQL))
            {
                try
                {
                    sqlCon.Open();
                    string sqlselect = "select  * from Classinfos";
                    //只执行一个sqlserver语句
                    SqlCommand sqlcmd = new SqlCommand(sqlselect, sqlCon);
                    //将表中的所有行读取出来，只不过每次只读取一行
                    object ob = sqlcmd.ExecuteScalar();
                }
                catch (Exception ex)//异常捕获
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// 读取指定一行的，所有数据
        /// 需要在sql脚本代码，指定哪一行，对于用户输入的限制，需要参数化
        /// </summary>
        public static void SelectAll()
        {
            List<Userinfo> userlist = new List<Userinfo>();
            //这里不能查询伪列
            string sql = @"select  *  from  test1 where  name=@user and   password=@pwd  ";
            string user = "admin";
            string pwd = "123456";
            string userid = "1";
            //一般都是用户查询自己的账号，输入字符串
            SqlParameter[] sqlpar = new SqlParameter[]
                {
                    new SqlParameter("@user",user),
                    new SqlParameter("@pwd",pwd),
                    new SqlParameter("@userid",userid)
                };
            using (SqlDataReader sqlread = SQLhelper.ExecuteReader(sql,sqlpar))
            {
                //将每一行都读取出来
                if (sqlread.Read())
                {
                    Userinfo us = new Userinfo();
                    us.UserID = (int)sqlread["id"];
                    us.UserName = sqlread["name"].ToString();
                    us.Password = sqlread["password"].ToString();
                    Console.WriteLine("{0},{1}  {2}", us.UserID, us.UserName,us.Password);
                    userlist.Add(us);
                }
            }
        }

        /// <summary>
        /// 查询多行多列
        /// </summary>
        public static void ALL()
        {
            List<Userinfo> userlist = new List<Userinfo>();
            //这里不能查询伪列
            string sql = @"select  *  from  test1  ";
            //一般都是用户查询自己的账号，输入字符串
            using (SqlDataReader sqlread = SQLhelper.ExecuteReader(sql))
            {
                //将每一行都读取出来
                while (sqlread.Read())
                {
                    Userinfo us = new Userinfo();
                    us.UserID = (int)sqlread["id"];
                    us.UserName = sqlread["name"].ToString();
                    us.Password = sqlread["password"].ToString();
                    Console.WriteLine("{0},{1}  {2}", us.UserID, us.UserName, us.Password);
                    userlist.Add(us);
                }
            }
        }


        /// <summary>
        /// 判断插入字符串，是个否可以用于查询。
        /// </summary>
        public static void Test()
        { 
            //当采用拼接字符串的时候，会可能因为某些特殊的原因
            //写成的语句，满足SQL server查询条件，导致查询成功。
            string username = "admin",password="123456";
            //$表示将变量的值插入到字符串当中
            string sql = $@"select & from  test1 where  name='{username}' and  password='{password}' ";
            int number = SQLhelper.ExecuteNonQuery(sql);
        }
    }
}
>>>>>>> 45f0c71 (new)
