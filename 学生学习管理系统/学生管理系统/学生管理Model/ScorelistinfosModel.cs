using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生管理Model
{
    public class ScorelistinfosModel
    {
        /// <summary>
        /// 列号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 学生编号
        /// </summary>
        public int Studentid { get; set; }
        /// <summary>
        /// c#成绩
        /// </summary>
        public int Csharp { get; set; }
        /// <summary>
        /// sqlserver成绩
        /// </summary>
        public int Sqlserver成绩 { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime Updatetime { get; set; }
    }
}

