using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 学生学习管理系统.Common;
using 学生学习管理系统.Common.SQLHelper;
using 学生学习管理系统.Model;

namespace 学生学习管理系统.DAL
{
    /// <summary>
    /// 学生数据访问类
    /// </summary>
    public class StudentDAL
    {
        /// <summary>
        /// 在添加学生数据的时候验证学号的是否在数据中是否存在
        /// </summary>
        /// <param name="objStu"></param>
        /// <returns></returns>
        public static bool BoolStudents(string[] str)
        {
            string sql = "select *from studentsInfos where studentidno=@idno " +
                "or cardno=@cdno ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@idno",str[0]),
                new SqlParameter("@cdno",str[1])
            };
            DataTable dt = SqlHelper.GetDataTable(sql, sp);
            if (dt.Rows.Count > 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 在修改学员信息时，判断修改的身份证号，在现有的学员信息里面不存在
        /// </summary>
        /// <param name="studentidno">修改后的身份证号</param>
        /// <param name="cardno">学号</param>
        /// <returns></returns>
        public static bool BoolStudents(string studentidno, string cardno)
        {
            string sql = "select Studentidno,CardNo from  StudentsInfos" +
                " where Studentidno=@studentIdno  and  Cardno<>@cardNo";
            SqlParameter[] sq = new SqlParameter[]
            {
                new SqlParameter("studentIdno",studentidno),
                new SqlParameter("cardNo",cardno)
            };
            DataTable dt = SqlHelper.GetDataTable(sql,sq);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 将学生对象加入到数据库中，
        /// </summary>
        /// <param name="objStu"></param>
        /// <returns></returns>
        public static int SetStudent(StudentModel objStu)
        {
            int number = 0;
            string sql = "insert into studentsinfos(studentname,gender,birthday,studentidno,cardno,stuimage,age,phonenumber,studentaddress,classid)" +
                "values(@name,@gender,@birthday,@studentidno,@cardno,@stuimage,@age,@phone,@stuAddress,@class);select @@identity ";
            SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("name",objStu.StudentName),
                    new SqlParameter("gender",objStu.Gender),
                    new SqlParameter("birthday",objStu.Bithday.ToString("yyyy-MM-dd")),
                    new SqlParameter("studentidno",objStu.StudentIdNo),
                    new SqlParameter("cardno",objStu.CardNO),
                    new SqlParameter("stuimage",objStu.StuImage),
                    new SqlParameter("age",objStu.Age),
                    new SqlParameter("phone",objStu.PhoneNumber),
                    new SqlParameter("stuAddress",objStu.StudentAddress),
                    new SqlParameter("class",objStu.ClassID)
                };
            number = Convert.ToInt32(SqlHelper.GetExecuteeScalar(sql, sp));
            return number;
        }

        /// <summary>
        /// 用班级来查询学员信息
        /// </summary>
        /// <param name="className">班级</param>
        /// <returns>学员信息</returns>
        public static List<StudentModel> GetStudent(string className)
        {
            string sql = "select  StudentID,  StudentName ,  Gender ,  Birthday ,  StudentIdNo ,  " +
                "  PhoneNumber , Classname  from studentsinfos  " +
                " inner join classinfos  on  ClassInfos.Classid = StudentsInfos. Classid " + " where Classname = @classname ";
            SqlParameter[] sq = new SqlParameter[]
             {
                 new SqlParameter("classname",className),
             };
            DataTable dt = SqlHelper.GetDataTable(sql, sq);
            List<StudentModel> stulist = new List<StudentModel>();
            foreach (DataRow item in dt.Rows)
            {
                stulist.Add(new StudentModel()
                {
                    StudentID = Convert.ToInt32(item["studentid"]),
                    StudentName = item["studentname"].ToString(),
                    Gender = item["gender"].ToString(),
                    Bithday = Convert.ToDateTime(item["birthday"]),
                    StudentIdNo = item["studentidno"].ToString(),
                    PhoneNumber = item["phonenumber"].ToString(),
                    ClassName = item["classname"].ToString()
                });
            }

            return stulist;
        }

        /// <summary>
        /// 用指定的学号来查询学员信息
        /// </summary>
        /// <param name="cardno">学号</param>
        /// <returns>学员信息</returns>
        public static StudentModel SelectStudentID(string studentid)
        {
            string sql = "select StudentID,StudentName,Gender,Birthday,StudentidNo,PhoneNumber,ClassName,Stuimage,studentAddress,CardNo" +
                " from studentsinfos  inner join  classinfos   on   classinfos.classid=studentsinfos.classid" +
                "  where   StudentId=@Studentid ";
            SqlParameter[] sq = new SqlParameter[]
            {
                new SqlParameter("StudentId",studentid)
            };

            DataRow dr = SqlHelper.GetDataRow(sql, sq);
            if (dr != null)
            {
                return new StudentModel()
                {
                    StudentID = Convert.ToInt32(dr["studentid"]),
                    StudentName = dr["studentname"].ToString(),
                    Gender = dr["gender"].ToString(),
                    Bithday = Convert.ToDateTime(dr["birthday"].ToString()),
                    StudentIdNo = dr["studentidno"].ToString(),
                    PhoneNumber = dr["phonenumber"].ToString(),
                    ClassName = dr["classname"].ToString(),
                    StuImage = dr["stuimage"].ToString() == null ? "" : dr["stuimage"].ToString(),
                    StudentAddress = dr["studentaddress"].ToString(),
                    CardNO = dr["cardno"].ToString()
                };
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 根据字符串学号信息删除学员
        /// </summary>
        /// <param name="studentid"></param>
        /// <returns></returns>
        public static bool DeleteStudent(string studentid)
        {
            string sql = "delete from studentsinfos  where Studentid=@StudentId";
            SqlParameter[] sq = new SqlParameter[]
            {
                new SqlParameter("StudentId",studentid)
            };
            //在删除时，可能删除的数据与其他表象关联所以会报错
            int number = SqlHelper.GetExecteNonQuery(sql, sq);
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 通过学生对象的来删除学员
        /// </summary>
        /// <param name="objStu"></param>
        /// <returns></returns>
        public static bool DeleteStudent(StudentModel objStu)
        {
            string sql = "delete from studentinfos where studentid=@Studentid";
            SqlParameter[] sq = new SqlParameter[]
            {
                new SqlParameter("Studentid",objStu.StudentID)
            };
            //在删除时，可能删除的数据与其他表象关联所以会报错
            int number = SqlHelper.GetExecteNonQuery(sql, sq);
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 修改学员信息
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public static bool UpdtaeStudent(StudentModel objStudent)
        {
            #region sql语句中的某些敏感词参数化Sqlparameter方法
            string sql = "update studentsinfos " +
                " set  StudentName=@Studentname ,Gender=@gender,Birthday=@birthday,Studentidno=@studentidno," +
                "CardNO=@cardno,PhoneNumber=@phonenumber,StudentAddress=@studentaddress,Classid=@classid," +
                "StuImage=@stuimage,Age=@age" +
                " where studentid=@studentId";
            SqlParameter[] sq = new SqlParameter[]
            {
                new SqlParameter("Studentname",objStudent.StudentName),
                new SqlParameter("gender",objStudent.Gender),
                new SqlParameter("birthday",objStudent.Bithday.ToString("yyyy-MM-dd")),
                new SqlParameter("studentidno",objStudent.StudentIdNo),
                new SqlParameter("cardno",objStudent.CardNO),
                new SqlParameter("phonenumber",objStudent.PhoneNumber),
                new SqlParameter("studentaddress",objStudent.StudentAddress),
                new SqlParameter("classid", objStudent.ClassID),
                new SqlParameter("stuimage",objStudent.StuImage),
                new SqlParameter("age",objStudent.Age),
                new SqlParameter("studentId",objStudent.StudentID)
            };
            #endregion

            #region  sql语句中的某些敏感词参数化string.Format方法
            //还可以将string 中的@string 参数化  
            //string.format
            StringBuilder sb = new StringBuilder();
            sb.Append("update studentsinfos " +
                " set  StudentName=@Studentname ,Gender=@gender,Birthday=@birthday,Studentidno=@studentidno," +
                "CardNO=@cardno,PhoneNumber=@phonenumber,StudentAddress=@studentaddress,Classid=@classid," +
                "StuImage=@stuimage,Age=@age" +
                " where studentid=@studentId");
            string sql1 = string.Format(sb.ToString(), objStudent.StudentName, objStudent.Gender,
               objStudent.Bithday.ToString("yyyy-MM-dd"), objStudent.StudentIdNo, objStudent.CardNO, objStudent.PhoneNumber,
               objStudent.StudentAddress, objStudent.ClassID, objStudent.StuImage, objStudent.Age, objStudent.StudentID);
            #endregion

            int num = SqlHelper.GetExecteNonQuery(sql, sq);
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
