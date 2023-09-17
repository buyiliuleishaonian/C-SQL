using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生学习管理系统.Model
{
    /// <summary>
    /// 管理员表
    /// </summary>
    public class AdmisModel
    {
        private  int logInId;
        private string logirpwd;
        private string adminName;
        /// <summary>
        /// 登入账号
        /// </summary>
        public int LogInId { get => logInId; set => logInId = value; }
        /// <summary>
        /// 登入密码
        /// </summary>
        public string Logirpwd { get => logirpwd; set => logirpwd = value; }
        /// <summary>
        /// 登入的用户名
        /// </summary>
        public string AdminName { get => adminName; set => adminName = value; }
    }
}
