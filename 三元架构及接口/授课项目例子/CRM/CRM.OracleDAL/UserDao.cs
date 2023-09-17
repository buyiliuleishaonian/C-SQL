<<<<<<< HEAD
﻿using CRM.IDAL.User;
using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.OracleDAL
{
    public class UserDao : IUserDao
    {
        public bool Add(UserModel model)
        {
            Console.WriteLine("Oracle添加数据成功！");
            return true;
        }

        public bool Delete(UserModel model)
        {
            throw new NotImplementedException();
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

namespace CRM.OracleDAL
{
    public class UserDao : IUserDao
    {
        public bool Add(UserModel model)
        {
            Console.WriteLine("Oracle添加数据成功！");
            return true;
        }

        public bool Delete(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
>>>>>>> 45f0c71 (new)
