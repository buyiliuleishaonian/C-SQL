using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生管理Model;
using 学生管理系统Common;

namespace 学生学习管理DAL
{
    /// <summary>
    ///考勤打卡数据库
    /// </summary>
    public class AttendanceDal
    {
        /// <summary>
        /// 查询实际人数
        /// </summary>
        /// <returns></returns>
        public int RealStuAll()
        {
            string sql = "select count(*) from studentsinfos";
            int nums = Convert.ToInt32(SQLHelper.GetExecuteScalar(sql));
            return nums;
        }

        /// <summary>
        ///  将当天已经打卡的人数查询出来
        /// </summary>
        /// <returns></returns>
        public int CardStu()
        {
            string sql = "select count(distinct cardno) from attendanceinfos" +
                " where Dttime between  '{0}' and '{1}'";
            //得到数据库当天的时间
            DateTime dt = Convert.ToDateTime(SQLHelper.GetDataTime().ToShortDateString());
            sql=string.Format(sql, dt, dt.AddDays(1.0));
            int nums = Convert.ToInt32(SQLHelper.GetExecuteScalar(sql));
            return nums;
        }

        /// <summary>
        /// 考勤卡号打卡
        /// </summary>
        /// <param name="cardno"></param>
        /// <returns></returns>
        public int InsertStu(string cardno)
        {
            string sql = "insert into attendanceinfos  (cardno)" +
                " values('{0}')";
            sql=string.Format(sql, cardno);
            int nums = SQLHelper.GetExecuteNonQuery(sql);
            return nums;
        }


        /// <summary>
        ///  利用学员姓名和时间查询学员打卡
        /// </summary>
        /// <param name="stuName"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public StudentsinfosModel SelectStuNameAndDate(string stuName, DateTime startTime,DateTime endTime)
        {
            string sql = "select studentid,studentname,gender,classname,dttime" +
                " from studentsinfos " +
                " inner  join classinfos on studentsinfos.classid=classinfos.classid " +
                " inner join attendanceinfos on studentsinfos.cardno=attendanceinfos.cardno " +
                " where  studentname='{0}' " +
                " and  dttime between  '{1}' and '{2}'  ";
            sql=string.Format(sql,stuName,startTime,endTime) ;
            SqlDataReader sqlread=SQLHelper.GetExecuteReader(sql);
            StudentsinfosModel stu = new StudentsinfosModel();
            if (sqlread.Read())
            {
                stu.Studentid=Convert.ToInt32(sqlread["studentid"]);
                stu.Studentname=sqlread["studentname"].ToString();
                 stu.Gender=sqlread["gender"].ToString();
                stu.ClassName=sqlread["classname"].ToString();
                stu.DTtime=Convert.ToDateTime(sqlread["dttime"]);
            }
            sqlread.Close();
            return stu;
        }

        /// <summary>
        ///  查询某天已经打卡的人数查询出来
        /// </summary>
        /// <returns></returns>
        public int DateStu(DateTime dt)
        {
            string sql = "select count(distinct cardno) from attendanceinfos" +
                " where Dttime between  '{0}' and '{1}'";
            //得到数据库当天的时间
            DateTime dt1 = dt.AddDays(1.0);
            sql=string.Format(sql, dt, dt1);
            int nums = Convert.ToInt32(SQLHelper.GetExecuteScalar(sql));
            return nums;
        }
    }
}
