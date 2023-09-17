using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生学习管理系统.Common.SQLHelper;
using 学生学习管理系统.Model;

namespace 学生学习管理系统.DAL
{
    /// <summary>
    /// 学生成绩表访问类
    /// </summary>
    public class ScoreListDAL
    {

        /// <summary>
        /// 读取所有学员的成绩
        /// </summary>
        /// <returns></returns>
        public static DataSet ReadStuSco()
        {
            string sql = "select studentsinfos.Studentid,studentname,classname,gender,Csharp,SQLserver成绩 from studentsinfos" +
                " inner join ScoreListInfos  " +
                "on studentsinfos.studentid=ScoreListInfos.studentid" +
            " inner join classinfos " +
            "on classinfos.classid=studentsinfos.classid";
            DataSet ds=SqlHelper.GetDataSet(sql);
            return ds;
        }

        //根据班级查询考试成绩（或全校成绩）
        public List<StudentModel> GetClassScore(string className)
        {
            string sql= "select Studentsinfos.studentid ,StudentName,Gender,Csharp,Sqlserver成绩,Classname" +
                " from studentsinfos " +
                " inner join classinfos" +
                " studentsinfos.studentid=Classinfos " +
                " inner join scorelistubfos" +
                " on studentsinfos.studentid=scorelistinfos.students" +
                " where Classname=@classname ";
            SqlParameter[] sq = new SqlParameter[]
            {
                new SqlParameter("classname",className)
            };
            DataTable dt=SqlHelper.GetDataTable(sql,sq);
            List<StudentModel> liststu=new List<StudentModel>();
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    liststu.Add(new StudentModel
                    {
                        StudentID = Convert.ToInt32(item["studentid"]),
                        StudentName = item["studentname"].ToString(),
                        Gender = item["gender"].ToString(),
                        ClassName = item["calssname"].ToString(),
                        Csharp = Convert.ToInt32(item["Csharp"]),
                        SQLserver = Convert.ToInt32(item["Sqlserver成绩"])
                    });

                }
            }
            else
            {
                return null;
            }
        }

        //根据班级统计考试成绩相关的信息(或全校考试成绩统计)


        //根据班级查询缺考人员列表(或全校缺考人数)


    }
}
