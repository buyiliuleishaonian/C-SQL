<<<<<<< HEAD
﻿using CRM.IDAL.User;
using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL
{
    public class UserManager
    {
        /// <summary>
        /// 业务逻辑层调用接口，
        /// </summary>
        private readonly IUserDao iUserDao = UserFactory.CreateUserService();//创建一个接口对象，接口当中存在删除和添加两种方法
        public bool Add(UserModel model)
        {
            return iUserDao.Add(model);
        }
    }
}
=======
﻿using CRM.IDAL.User;
using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL
{
    public class UserManager
    {
        /// <summary>
        /// 业务逻辑层调用接口，
        /// </summary>
        private readonly IUserDao iUserDao = UserFactory.CreateUserService();//创建一个接口对象，接口当中存在删除和添加两种方法
        public bool Add(UserModel model)
        {
            return iUserDao.Add(model);
        }
    }
}
>>>>>>> 45f0c71 (new)
