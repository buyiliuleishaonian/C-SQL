using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生管理Model
{
    public class AttendanceinfosModel
    {
        /// <summary>
        /// 列号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string Cardno { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Dttime { get; set; }
    }
}

