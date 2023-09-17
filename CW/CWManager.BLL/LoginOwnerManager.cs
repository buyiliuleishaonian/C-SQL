<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWModel.Model;
using CWServer.DAL;
namespace CWManager.BLL
{
    public class LoginOwnerManager
    {
        /// <summary>
        /// 用户登入
        /// </summary>
        /// <returns></returns>
         public PetOwner  Login()
        {
            PetOwner petowner = new PetOwner();
            while (true)
            {
                PetOwnerService petOwnerService = new PetOwnerService();
                Console.WriteLine("请输入名字");
                petowner.Name = Console.ReadLine();
                Console.WriteLine("请输入主人的密码");
                petowner.Password = Console.ReadLine();                
                petowner = petOwnerService.Login(petowner);
                if (petowner.Id!=0)
                {
                    break;
                }
            }
            return petowner;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWModel.Model;
using CWServer.DAL;
namespace CWManager.BLL
{
    public class LoginOwnerManager
    {
        /// <summary>
        /// 用户登入
        /// </summary>
        /// <returns></returns>
         public PetOwner  Login()
        {
            PetOwner petowner = new PetOwner();
            while (true)
            {
                PetOwnerService petOwnerService = new PetOwnerService();
                Console.WriteLine("请输入名字");
                petowner.Name = Console.ReadLine();
                Console.WriteLine("请输入主人的密码");
                petowner.Password = Console.ReadLine();                
                petowner = petOwnerService.Login(petowner);
                if (petowner.Id!=0)
                {
                    break;
                }
            }
            return petowner;
        }
    }
}
>>>>>>> 45f0c71 (new)
