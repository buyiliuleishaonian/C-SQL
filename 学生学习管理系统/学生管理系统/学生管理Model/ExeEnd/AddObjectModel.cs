using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生管理Model.ExeEnd
{
    /// <summary>
    /// 添加扩展类，将所有表的当作属性创建在其中
    /// </summary>
    public class AddObjectModel
    {
        public AdminsModel ObjAdmin{ get; set; }
        public AttendanceinfosModel Objatt { get; set; }
        public ScorelistinfosModel Objsco { get; set; }
        public StudentsinfosModel Objstu { get; set;}

        public ClassinfosModel Objclass { get; set; }
    }
}
