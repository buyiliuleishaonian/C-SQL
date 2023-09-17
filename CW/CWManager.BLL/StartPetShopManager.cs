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
    public  class StartPetShopManager
    {
        /// <summary>
        /// 读取出来宠物，宠物主人，宠物商店。
        /// </summary>
        public void GetPetALL()
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("序号\t宠物名称");
            PerService perService = new PerService();
            perService.GetPetInfos();
            PetOwnerService petOwnerService = new PetOwnerService();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("所有宠物主人从sqlserver中醒来");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("序号\t主人姓名");
            petOwnerService.GetPetOwenr();
            PetStoreService petsto=new PetStoreService();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("所有宠物商店从sqlserver中醒来");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("序号\t宠物商店名称");
            petsto.GetPetStoreALL();
            Console.WriteLine("*******************************************************");
            Console.WriteLine();
            Console.WriteLine();
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
    public  class StartPetShopManager
    {
        /// <summary>
        /// 读取出来宠物，宠物主人，宠物商店。
        /// </summary>
        public void GetPetALL()
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("序号\t宠物名称");
            PerService perService = new PerService();
            perService.GetPetInfos();
            PetOwnerService petOwnerService = new PetOwnerService();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("所有宠物主人从sqlserver中醒来");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("序号\t主人姓名");
            petOwnerService.GetPetOwenr();
            PetStoreService petsto=new PetStoreService();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("所有宠物商店从sqlserver中醒来");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("序号\t宠物商店名称");
            petsto.GetPetStoreALL();
            Console.WriteLine("*******************************************************");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
>>>>>>> 45f0c71 (new)
