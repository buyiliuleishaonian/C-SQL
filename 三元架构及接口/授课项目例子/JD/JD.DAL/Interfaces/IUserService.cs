<<<<<<< HEAD
﻿using JD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace JD.DAL.Users
{
    /// <summary>
    /// 比如项目经理:没有，也不允许实现方法（功能） 接口是抽象的(规范)
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// 添加功能
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Add(UserModel model);
        bool Delete(int userId);

    }
}
=======
﻿using JD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace JD.DAL.Users
{
    /// <summary>
    /// 比如项目经理:没有，也不允许实现方法（功能） 接口是抽象的(规范)
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// 添加功能
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Add(UserModel model);
        bool Delete(int userId);

    }
}
>>>>>>> 45f0c71 (new)
