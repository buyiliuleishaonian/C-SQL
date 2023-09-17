using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生学习管理系统.Model
{
    /// <summary>
    /// 考勤表
    /// </summary>
    public class AttendanceModel
    {
        private int id;
        private string cardNo;
        private DateTime dTime;
        /// <summary>
        /// 考勤列表
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// 学生卡号
        /// </summary>
        public string CardNo { get => cardNo; set => cardNo = value; }
        /// <summary>
        /// 打开时间
        /// </summary>
        public DateTime DTime { get => dTime; set => dTime = value; }
    }
}
