using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 学生管理Model;
using 学生管理系统Common;

namespace 学生学习管理DAL
{
    /// <summary>
    /// 学生类的数据层
    /// </summary>
    public class StudentDAL
    {
        /// <summary>
        /// 添加学员
        /// </summary>
        /// <returns></returns>
        public int AddStudent(StudentsinfosModel objstu)
        {
            string sql = "insert into studentsinfos(studentname,gender,birthday,studentidno," +
                " cardno,age,phonenumber,studentaddress,classid,stuimage) " +
                " values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}')" +
                "  select @@identity";
            sql=string.Format(sql, objstu.Studentname, objstu.Gender, objstu.Birthday.ToString("yyyyMMdd"), objstu.Studentidno, objstu.Cardno
                , objstu.Age, objstu.Phonenumber, objstu.Studentaddress, objstu.Classid, objstu.Stuimage);
            int nums = SQLHelper.GetExecuteNonQuery(sql);
            return nums;
        }

        /// <summary>
        /// 判断数据库中是否存在学号和卡号
        /// </summary>
        /// <param name="studentidno"></param>
        /// <param name="card"></param>
        /// <returns></returns>
        public DataRow GetStuIDNOorCard(string studentidno, string card)
        {
            string sql = "select count(*) from studentsinfos" +
                " where studentname='{0}' or cardno='{1}'";
            sql=string.Format(sql, studentidno, card);
            DataRow dr = SQLHelper.GetDataRow(sql);
            return dr;
        }

        /// <summary>
        /// 通过班级查询学员信息
        /// </summary>
        /// <param name="classID">班级的id</param>
        /// <returns></returns>
        public List<StudentsinfosModel> SelectStu(int classID)
        {
            string sql = "select studentid,studentname,gender,birthday,classname" +
                " from studentsinfos " +
                " inner join  classinfos" +
                " on classinfos.classid=studentsinfos.classid" +
                " where   studentsinfos.classid={0}";
            sql=string.Format(sql, classID);
            DataTable dt = SQLHelper.GetDataTable(sql);
            List<StudentsinfosModel> stulist = new List<StudentsinfosModel>();
            foreach (DataRow dr in dt.Rows)
            {
                stulist.Add(new StudentsinfosModel()
                {
                    Studentid=Convert.ToInt32(dr["studentid"]),
                    Studentname=dr["studentname"].ToString(),
                    Gender=dr["gender"].ToString(),
                    Birthday=Convert.ToDateTime(dr["birthday"]),
                    ClassName=dr["classname"].ToString()
                });
            }
            return stulist;
        }


        /// <summary>
        /// 通过学号查询详细信息
        /// </summary>
        /// <param name="stuID">学号</param>
        /// <returns></returns>
        public StudentsinfosModel SelectStuID(string stuID)
        {
            StudentsinfosModel dr = new StudentsinfosModel();
            string sql = "select studentid, studentname,gender,birthday,studentidno," +
                "cardno,age,phonenumber,studentaddress,classname,stuimage " +
                " from  studentsinfos " +
                " inner join  classinfos" +
                " on studentsinfos.classid=studentsinfos.classid " +
                " where studentid='{0}'";
            sql=string.Format(sql, stuID);
            SqlDataReader sqlread = SQLHelper.GetExecuteReader(sql);
            if (sqlread.Read())
            {
                dr.Studentid=Convert.ToInt32(sqlread["studentid"]);
                dr.Studentname=sqlread["studentname"].ToString();
                dr.Gender=sqlread["gender"].ToString();
                dr.Birthday=Convert.ToDateTime(sqlread["birthday"]);
                dr.Studentidno=sqlread["studentidno"].ToString();
                dr.Cardno=sqlread["cardno"].ToString();
                dr.Age=Convert.ToInt32(sqlread["age"]);
                dr.Phonenumber=sqlread["phonenumber"].ToString();
                dr.Studentaddress=sqlread["studentaddress"].ToString();
                dr.ClassName=sqlread["classname"].ToString();
                dr.Stuimage=sqlread["stuimage"].ToString()==null ? "" : sqlread["stuimage"].ToString();
            }
            sqlread.Close();
            return dr;
        }

        /// <summary>
        /// 修改学员信息
        /// </summary>
        /// <param name="stuid"></param>
        /// <returns></returns>
        public int UpdateStu(int stuid)
        {
            string sql = "update to studentsinfos" +
                " set studentname='{0}',gender='{1}',birthday='{2}',studentidno='{3}'," +
                " cardno='{4}',age={5},phonenumber='{6}',studentaddress='{7}',classid={8},stuimage='{9}' " +
                " where studentid={10}";
            sql=string.Format(sql, stuid);
            int nums = SQLHelper.GetExecuteNonQuery(sql);
            return nums;
        }

        /// <summary>
        /// 查询修改之后的学号是否在数据库本来就存在
        /// </summary>
        /// <returns></returns>
        public DataRow SelectStuORCard(string card, string studentidno)
        {
            //只要有考勤卡号或者身份证号有一个重复，就修改失败
            string sql = "select count(*) from " +
                "studentsinfos " +
                " where cardno='{0}' or studentidno='{1}'";
            sql=string.Format(sql, card, studentidno);
            DataRow dr = SQLHelper.GetDataRow(sql);
            return dr;
        }

        /// <summary>
        /// 根据学号删除学员信息
        /// </summary>
        /// <param name="stuid"></param>
        /// <returns></returns>
        public int DeleteStu(int stuid)
        {
            string sql = "delete from studentsinfos" +
                " where studentid={0}";
            sql=string.Format(sql, stuid);
            int nums = SQLHelper.GetExecuteNonQuery(sql);
            return nums;
        }

        /// <summary>
        /// 用卡号查询学员信息
        /// </summary>
        /// <param name="cardno"></param>
        /// <returns></returns>
        public StudentsinfosModel SelectCard(string cardno)
        {
            StudentsinfosModel dr = new StudentsinfosModel();
            string sql = "select studentid, studentname,gender,birthday,studentidno," +
                "cardno,age,phonenumber,studentaddress,classname,stuimage " +
                " from  studentsinfos " +
                " inner join  classinfos" +
                " on studentsinfos.classid=studentsinfos.classid " +
                " where cardno='{0}'";
            sql=string.Format(sql, cardno);
            SqlDataReader sqlread = SQLHelper.GetExecuteReader(sql);
            if (sqlread.Read())
            {
                dr.Studentid=Convert.ToInt32(sqlread["studentid"]);
                dr.Studentname=sqlread["studentname"].ToString();
                dr.Gender=sqlread["gender"].ToString();
                dr.Birthday=Convert.ToDateTime(sqlread["birthday"]);
                dr.Studentidno=sqlread["studentidno"].ToString();
                dr.Cardno=sqlread["cardno"].ToString();
                dr.Age=Convert.ToInt32(sqlread["age"]);
                dr.Phonenumber=sqlread["phonenumber"].ToString();
                dr.Studentaddress=sqlread["studentaddress"].ToString();
                dr.ClassName=sqlread["classname"].ToString();
                dr.Stuimage=sqlread["stuimage"].ToString()==null ? "" : sqlread["stuimage"].ToString();
            }
            sqlread.Close();
            return dr;
        }

        public bool InsertExcelStu(List<StudentsinfosModel> stulist)
        {
            string sql = "insert into studentsinfos(studentname,gender,birthday,cardno,studentidno,phonenumber,studentaddress,classid,age)" +
                " values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},{8})";

            List<string> sqllist = new List<string>();
            
            foreach(var item in stulist)
            {
                string s=string.Format(sql,item.Studentname,item.Gender,item.Birthday,item.Cardno,item.Studentidno,item.Phonenumber,item.Studentaddress,item.Classid,item.Age);
                sqllist.Add(s);
            }
            return  SQLHelper.GetTransaction(sqllist);
        }
    }
}
