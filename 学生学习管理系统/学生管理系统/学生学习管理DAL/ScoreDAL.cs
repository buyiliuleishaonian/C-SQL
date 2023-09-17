using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生管理Model;
using 学生管理Model.ExeEnd;
using 学生管理系统Common;

namespace 学生学习管理DAL
{
    /// <summary>
    /// 成绩数据层
    /// </summary>
    public class ScoreDAL
    {
        /// <summary>
        /// 用班级查询学员成绩
        /// </summary>
        /// <param name="classid"></param>
        /// <returns></returns>
        public DataSet SelectStuScore()
        {
            string sql = "select studentsinfos.studentid, studentname,classname, " +
                " Csharp,sqlserver成绩" +
                " from  studentsinfos " +
                " inner join  classinfos" +
                " on studentsinfos.classid=classinfos.classid " +
                " inner join scorelistinfos " +
                " on studentsinfos.studentid=scorelistinfos.studentid";
            List<StudentsinfosModel> stulist = new List<StudentsinfosModel>();
            DataSet ds = SQLHelper.GetDataSet(sql);
            return ds;
        }

        /// <summary>
        /// 用班级查询学员成绩，或者全校成绩
        /// </summary>
        /// <param name="classid"></param>
        /// <returns></returns>
        public List<AddObjectModel> SelectStuScore(int classid)
        {
            string sql = "select studentsinfos.studentid,studentname," +
                " classname,Csharp,SQLserver成绩  from studentsinfos" +
                " inner join classinfos on classinfos.classid=studentsinfos.classid" +
                " inner join scorelistinfos on studentsinfos.studentid=scorelistinfos.studentid ";
            if (classid>0)
            {
                sql+="where studentsinfos.classid={0}";
                sql=string.Format(sql, classid);
            }
            DataSet ds = SQLHelper.GetDataSet(sql);
            List<AddObjectModel> list = new List<AddObjectModel>();
            foreach(DataRow dr in ds.Tables[0].Rows )
            {
                list.Add(new AddObjectModel()
                {
                    Objstu=new StudentsinfosModel()
                    {
                        Studentid=Convert.ToInt32(dr["studentid"]),
                        Studentname=dr["studentname"].ToString()
                    },
                   Objclass=new ClassinfosModel() 
                   {
                       Classname=dr["classname"].ToString()
                   },
                   Objsco=new ScorelistinfosModel() 
                   {
                       Csharp=Convert.ToInt32( dr["csharp"]),
                       Sqlserver成绩=Convert.ToInt32(dr["sqlserver成绩"])
                   },
                }) ;
            }
            return list;
        }

        /// <summary>
        /// 按班级查询考试人数，平均分，和缺考人数 或者全校
        /// </summary>
        /// <param name="classid"></param>
        /// <returns></returns>
        public Dictionary<string, string> SelectPeopleSco(int classid)
        {
            string sql = "select stucount=count(*), csharpAvg=avg(Csharp),sqlServerAvg=avg(SQLserver成绩) from studentsinfos" +
                " inner join classinfos on classinfos.classid=studentsinfos.classid " +
                " inner join  scorelistinfos on  scorelistinfos.studentid=studentsinfos.studentid ";
            //判断是否有班级
            if (classid>0)
            {
                sql+="where studentsinfos.classid={0}";
                sql = string.Format(sql, classid);
            }
            //sqlserver中两个查询用 ; 分来
            sql+="; select stuentcount=count(*) from studentsinfos " +
                " inner join scorelistinfos on studentsinfos.studentid=scorelistinfos.studentid";
            if (classid>0)
            {
                sql+="  and  classid={0}";
                sql = string.Format(sql, classid);
            }
            SqlDataReader sqlread=SQLHelper.GetExecuteReader(sql);
            Dictionary<string,string> dc=new Dictionary<string,string>();
            if (sqlread.Read())
            {
                dc.Add("stucount", sqlread["stucount"].ToString());
                dc.Add("csharpAvg", sqlread["csharpavg"].ToString());
                dc.Add("sqlServerAvg", sqlread["sqlserveravg"].ToString());
            }
            //读取第二次查询的结果
            if (sqlread.NextResult())
            {
                if (sqlread.Read())
                {
                    dc.Add("stuentcount", sqlread["stuentcount"].ToString());
                }
            }
            sqlread.Close();
            return dc;
        }

        /// <summary>
        /// 缺考人员姓名
        /// </summary>
        /// <param name="classid"></param>
        /// <returns></returns>
        public List<string> SelectName(int classid) 
        {
            string sql = "select studentname from studentsinfos" +
                " where studentid not  in (select studentid from scorelistinfos) ";
            if (classid>0)
            {
                sql+=" and studentsinfos.classid={0}";
                sql = string.Format(sql, classid);
            }
            SqlDataReader sqlDataReader=SQLHelper.GetExecuteReader(sql);
            List<string> dc = new List<string>();
            while (sqlDataReader.Read()) 
            {
                dc.Add(sqlDataReader["studentname"].ToString());
            }
            sqlDataReader.Close();
            return dc;
        }
    }
}
