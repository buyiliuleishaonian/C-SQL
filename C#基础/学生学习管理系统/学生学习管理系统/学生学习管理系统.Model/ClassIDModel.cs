using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生学习管理系统.Model
{
    /// <summary>
    /// 班级表
    /// </summary>
    public class ClassIDModel
    {
        private int classID;
        private string className;
        /// <summary>
        /// 班级编号
        /// </summary>
        public int ClassID { get => classID; set => classID = value; }
        /// <summary>
        /// 班级名称
        /// </summary>
        public string ClassName { get => className; set => className = value; }
    }
}
