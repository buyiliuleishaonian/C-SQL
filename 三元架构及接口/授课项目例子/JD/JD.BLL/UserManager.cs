<<<<<<< HEAD
﻿using JD.DAL.Users;
using JD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.BLL
{
    public class UserManager
    {
        private readonly IUserService userService = new UserService();
        public bool Add(UserModel model)
        {
            return userService.Add(model);
        }
    }
}
=======
﻿using JD.DAL.Users;
using JD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.BLL
{
    public class UserManager
    {
        private readonly IUserService userService = new UserService();
        public bool Add(UserModel model)
        {
            return userService.Add(model);
        }
    }
}
>>>>>>> 45f0c71 (new)
