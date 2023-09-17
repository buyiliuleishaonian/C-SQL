<<<<<<< HEAD
﻿using CWModel.Model;
using CWServer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWManager.BLL
{
    public  class LoginStoreManager
    {
        public void Lgion()
        {
            while (true)
            {
                Console.WriteLine("请输入名字");
                string name = Console.ReadLine();
                Console.WriteLine("请输入主人的密码");
                string password = Console.ReadLine();
                PetStoreService petStore = new PetStoreService();
                PetStoreCW petStoreCW = new PetStoreCW(name, password);
                bool b= petStore.Login1(petStoreCW);
                if (b)
                {
                    break;
                }
            }
        }
    }
}
=======
﻿using CWModel.Model;
using CWServer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWManager.BLL
{
    public  class LoginStoreManager
    {
        public void Lgion()
        {
            while (true)
            {
                Console.WriteLine("请输入名字");
                string name = Console.ReadLine();
                Console.WriteLine("请输入主人的密码");
                string password = Console.ReadLine();
                PetStoreService petStore = new PetStoreService();
                PetStoreCW petStoreCW = new PetStoreCW(name, password);
                bool b= petStore.Login1(petStoreCW);
                if (b)
                {
                    break;
                }
            }
        }
    }
}
>>>>>>> 45f0c71 (new)
