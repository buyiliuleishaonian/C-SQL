using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生学习管理系统.Model
{
    /// <summary>
    /// 学生信息
    /// </summary>
    public class StudentModel
    {
        
        private int studentID;
        private string studentName;
        private string gender;
        private DateTime bithday;
        private string studentIdNo;
        private string cardNO;
        private  string stuImage;
        private int age;
        private string studentAddress;
        private int classID;
        private string phoneNumber;

        /// <summary>
        /// 学生id
        /// </summary>
        public int StudentID { get => studentID; set => studentID = value; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get => studentName; set => studentName = value; }
        /// <summary>
        /// 学生性别
        /// </summary>
        public string Gender { get => gender; set => gender = value; }
        /// <summary>
        /// 学生生日
        /// </summary>
        public DateTime Bithday { get => bithday; set => bithday = value; }
        /// <summary>
        /// 学生身份证
        /// </summary>
        public string StudentIdNo { get => studentIdNo; set => studentIdNo = value; }
        /// <summary>
        /// 学生卡号
        /// </summary>
        public string CardNO { get => cardNO; set => cardNO = value; }
        /// <summary>
        /// 学生照片
        /// </summary>
        public string StuImage { get => stuImage; set => stuImage = value; }
        /// <summary>
        /// 学生年龄
        /// </summary>
        public int Age { get => age; set => age = value; }
        /// <summary>
        /// 学生住址
        /// </summary>
        public string StudentAddress { get => studentAddress; set => studentAddress = value; }
        /// <summary>
        /// 学生班级
        /// </summary>
        public int ClassID { get => classID; set => classID = value; }
        /// <summary>
        /// 学生电话
        /// </summary>
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }


        //扩展属性，就是实体类中可以存在，数据库中没有的属性
        /// <summary>
        /// 
        /// </summary>
        public string ClassName { get; set; }
        
        //C#成绩
        public int Csharp { get; set; }

        //sql成绩
        public int SQLserver { get; set; }
    }
}
