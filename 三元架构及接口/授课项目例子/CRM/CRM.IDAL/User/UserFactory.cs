<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace CRM.IDAL.User
{
    public class UserFactory
    {
        public static string ProjectName = ConfigurationManager.AppSettings["DAL"];
        public static IUserDao CreateUserService()
        {
            //oracle  sqlserver  兼容性
            //反射，动态加载DLL
            //放回一个接口，并且明确调用那个CRM.SQLsrerverDAL或者CMR.OracleDAL数据库
            //projectName为什么没有给明确的DAL名字，因为在显示中的App.config中创建了键值对，
            //确定了使用那个数据库
            return (IUserDao)Assembly.Load(ProjectName).CreateInstance(ProjectName + ".UserDao");
        }


        
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace CRM.IDAL.User
{
    public class UserFactory
    {
        public static string ProjectName = ConfigurationManager.AppSettings["DAL"];
        public static IUserDao CreateUserService()
        {
            //oracle  sqlserver  兼容性
            //反射，动态加载DLL
            //放回一个接口，并且明确调用那个CRM.SQLsrerverDAL或者CMR.OracleDAL数据库
            //projectName为什么没有给明确的DAL名字，因为在显示中的App.config中创建了键值对，
            //确定了使用那个数据库
            return (IUserDao)Assembly.Load(ProjectName).CreateInstance(ProjectName + ".UserDao");
        }


        
    }
}
>>>>>>> 45f0c71 (new)
