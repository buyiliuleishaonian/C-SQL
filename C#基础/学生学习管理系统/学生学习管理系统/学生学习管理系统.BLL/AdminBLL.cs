using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生学习管理系统.DAL;
using 学生学习管理系统.Model;
namespace 学生学习管理系统.BLL
{
    public class AdminBLL
    {
        /// <summary>
        /// 登入管理员账户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static  AdmisModel GetUser(AdmisModel  model)
        {
            return AdminDAL.GetAdminLogin(model);
        }

        /// <summary>
        /// 修改管理员密码
        /// </summary>
        public static int GetPwd(AdmisModel model)
        {
           return  AdminDAL.SetLogPwd(model);
        }
    }
}
