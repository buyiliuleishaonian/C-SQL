using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生学习管理系统.DAL;

namespace 学生学习管理系统.BLL
{
    /// <summary>
    /// 成绩查询的数据逻辑
    /// </summary>
    public  class ScoreListBll
    {
        public   DataSet   GetScoure()
        {
            return ScoreListDAL.ReadStuSco();
        }
    }
}
