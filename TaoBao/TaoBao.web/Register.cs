<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoBao.BLL;
using TaoBao.Models;

namespace TaoBao.web
{
    /// <summary>
    /// 
    /// </summary>
    public class Register
    {
        public bool RegisterUser(UserinfoManager userinfomanager)
        {
            UserInfoModel userinfomodel = new UserInfoModel();
            Console.WriteLine("输入用户ID");
            userinfomodel.UserId = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("输入用户名");
            userinfomodel.UserName = Console.ReadLine();
            Console.WriteLine("输入用户年龄");
            userinfomodel.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入密码");
            userinfomodel.Password = Console.ReadLine();
            Console.WriteLine("输入手机号");
            userinfomodel.UserPhone = Console.ReadLine();
            return userinfomanager.AddUser(userinfomodel);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoBao.BLL;
using TaoBao.Models;

namespace TaoBao.web
{
    /// <summary>
    /// 
    /// </summary>
    public class Register
    {
        public bool RegisterUser(UserinfoManager userinfomanager)
        {
            UserInfoModel userinfomodel = new UserInfoModel();
            Console.WriteLine("输入用户ID");
            userinfomodel.UserId = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("输入用户名");
            userinfomodel.UserName = Console.ReadLine();
            Console.WriteLine("输入用户年龄");
            userinfomodel.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入密码");
            userinfomodel.Password = Console.ReadLine();
            Console.WriteLine("输入手机号");
            userinfomodel.UserPhone = Console.ReadLine();
            return userinfomanager.AddUser(userinfomodel);
        }
    }
}
>>>>>>> 45f0c71 (new)
