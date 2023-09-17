<<<<<<< HEAD
﻿using CRM.BLL;
using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
namespace CRM.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //IOC 依赖注入，控制反转
           // 低耦合
            UserManager userManager = new UserManager();
            userManager.Add(new UserModel());
            //RoseFactory rf = new RoseFactory();
            //rf.CreateRole(2).Login();
        }
    }
}
=======
﻿using CRM.BLL;
using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
namespace CRM.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //IOC 依赖注入，控制反转
           // 低耦合
            UserManager userManager = new UserManager();
            userManager.Add(new UserModel());
            //RoseFactory rf = new RoseFactory();
            //rf.CreateRole(2).Login();
        }
    }
}
>>>>>>> 45f0c71 (new)
