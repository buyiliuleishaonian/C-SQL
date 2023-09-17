using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生学习管理系统.DAL;
using 学生学习管理系统.Model;

namespace 学生学习管理系统.BLL
{
    public  class StudnetBLL
    {
        /// <summary>
        /// 验证输入学生的身份证和卡号是否有重复的
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public static bool BoolInStudent(string[] str)
        {
            return StudentDAL.BoolStudents(str);
        }
        public static bool BoolInStudent(string studentidno,string cardno)
        {
            return StudentDAL.BoolStudents(studentidno,cardno);
        }

        /// <summary>
        /// 将新添加的学生数据添加到数据库中
        /// </summary>
        /// <param name="objStu"></param>
        /// <returns></returns>
        public static int GetStu(StudentModel objStu)
        {
            return StudentDAL.SetStudent(objStu);
        }

        /// <summary>
        /// 用班级来查询数据信息
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public  List<StudentModel> SelectStudent(string className)
        {
            return StudentDAL.GetStudent(className);
        }
        
        /// <summary>
        /// 用学号来查询学员信息
        /// </summary>
        /// <param name="cardno"></param>
        /// <returns></returns>
        public StudentModel  SelectCardNo(string  studentid)
        {
            return  StudentDAL.SelectStudentID(studentid);
        }

        /// <summary>
        /// 按学号删除学员信息
        /// </summary>
        /// <param name="studentid"></param>
        /// <returns></returns>
        public bool DeleteStuinfo(string studentid)
        {
            return StudentDAL.DeleteStudent(studentid);
        }

        /// <summary>
        /// 按着学员的学号进行修改
        /// </summary>
        /// <param name="objstudent"></param>
        /// <returns></returns>
        public bool  UpdateStuinfo(StudentModel objstudent)
        {
            return StudentDAL.UpdtaeStudent(objstudent);
        }

    }
}
