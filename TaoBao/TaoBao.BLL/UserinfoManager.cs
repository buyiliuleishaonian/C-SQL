<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoBao.DAL;
using TaoBao.Models;

namespace TaoBao.BLL
{
    /// <summary>
    /// 用户业务逻辑
    /// </summary>
    public class UserinfoManager
    {
        private static UserinfoServer userinfoserver = new UserinfoServer();
        public bool AddUser(UserInfoModel usermodel)
        {
           
            return userinfoserver.Insert(usermodel); 
        }


        /// <summary>
        /// 输出一整张表的数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetUserInfosALL()
        {
            return  userinfoserver.GetUserInfoALL();
        }


        public DataTable GetUserInfos()
        {
            return userinfoserver.GetUserInfo();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoBao.DAL;
using TaoBao.Models;

namespace TaoBao.BLL
{
    /// <summary>
    /// 用户业务逻辑
    /// </summary>
    public class UserinfoManager
    {
        private static UserinfoServer userinfoserver = new UserinfoServer();
        public bool AddUser(UserInfoModel usermodel)
        {
           
            return userinfoserver.Insert(usermodel); 
        }


        /// <summary>
        /// 输出一整张表的数据
        /// </summary>
        /// <returns></returns>
        public DataSet GetUserInfosALL()
        {
            return  userinfoserver.GetUserInfoALL();
        }


        public DataTable GetUserInfos()
        {
            return userinfoserver.GetUserInfo();
        }
    }
}
>>>>>>> 45f0c71 (new)
