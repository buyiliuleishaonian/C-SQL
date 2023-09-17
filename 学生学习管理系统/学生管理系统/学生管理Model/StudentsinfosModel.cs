using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生管理Model
{
    public class StudentsinfosModel
    {
        /// <summary>
        /// 学生id
        /// </summary>
        public int Studentid { get; set; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string Studentname { get; set; }
        /// <summary>
        /// 学生性别
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 学生生日
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 学生身份证号
        /// </summary>
        public string Studentidno { get; set; }
        /// <summary>
        /// 学生卡号
        /// </summary>
        public string Cardno { get; set; }
        /// <summary>
        /// 学生年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 学生电话号码
        /// </summary>
        public string Phonenumber { get; set; }
        /// <summary>
        /// 学生住址
        /// </summary>
        public string Studentaddress { get; set; }
        /// <summary>
        /// 学生班级
        /// </summary>
        public int Classid { get; set; }
        /// <summary>
        /// 学生照片
        /// </summary>
        public string Stuimage { get; set; }

        //扩展属性
        /// <summary>
        /// 班级名字
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// C#成绩
        /// </summary>
        public int Csharp { get; set; }
        /// <summary>
        /// Sql成绩
        /// </summary>
        public int SQLserver { get; set; }

        public DateTime DTtime { get; set; }
    }
}

