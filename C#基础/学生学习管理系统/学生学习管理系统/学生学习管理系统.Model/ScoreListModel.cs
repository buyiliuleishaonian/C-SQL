using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生学习管理系统.Model
{
    /// <summary>
    /// 成绩表
    /// </summary>
    public class ScoreListModel
    {
        private int id;
        private int studentld;
        private int sqlserver;
        private int cscore;
        private DateTime updatetime;

        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// 学生编号，与学生信息中学生编号构成主外键约束
        /// </summary>
        public int Studentld { get => studentld; set => studentld = value; }
        /// <summary>
        /// 成绩录入时间
        /// </summary>
        public DateTime Updatetime { get => updatetime; set => updatetime = value; }
        /// <summary>
        /// sql成绩
        /// </summary>
        public int Sqlserver { get => sqlserver; set => sqlserver = value; }
        /// <summary>
        /// c#成绩
        /// </summary>
        public int Cscore { get => cscore; set => cscore = value; }
    }
}
