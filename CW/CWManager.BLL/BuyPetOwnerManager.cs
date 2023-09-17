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
    public  class BuyPetOwnerManager
    {

        /// <summary>
        /// 购买宠物商店库存的宠物
        /// </summary>
        public void Buypet()
        {
            //清屏
            Console.Clear();
            Console.WriteLine("登入成功，您可以选择购买和卖出宠物，如果你想要购买宠物请输入1，如果你想要卖出宠物请输入2");
            Console.WriteLine("1、购买宠物");
            Console.WriteLine("2、卖出宠物");
            Console.WriteLine("1");
            Console.WriteLine("----------------------请输入选择购买范围，只能输入选择的序号------------------------");
            Console.WriteLine("1、购买库存宠物");
            Console.WriteLine("2、购买新培育宠物");
            int number = Convert .ToInt32 (Console.ReadLine());
            if (number==1)
            {
                Console.WriteLine("---------------库存宠物--------------------");
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
    public  class BuyPetOwnerManager
    {

        /// <summary>
        /// 购买宠物商店库存的宠物
        /// </summary>
        public void Buypet()
        {
            //清屏
            Console.Clear();
            Console.WriteLine("登入成功，您可以选择购买和卖出宠物，如果你想要购买宠物请输入1，如果你想要卖出宠物请输入2");
            Console.WriteLine("1、购买宠物");
            Console.WriteLine("2、卖出宠物");
            Console.WriteLine("1");
            Console.WriteLine("----------------------请输入选择购买范围，只能输入选择的序号------------------------");
            Console.WriteLine("1、购买库存宠物");
            Console.WriteLine("2、购买新培育宠物");
            int number = Convert .ToInt32 (Console.ReadLine());
            if (number==1)
            {
                Console.WriteLine("---------------库存宠物--------------------");
>>>>>>> 45f0c71 (new)
                Console.WriteLine("序号\t宠物名称\t宠物类型\t元宝数");
                PerService per = new PerService();
                per.GetNoPetOwnerInfos(number);
                
<<<<<<< HEAD
            }
            else if(number==2)
            {
                Console.WriteLine("---------------新培育宠物--------------------");
                Console.WriteLine("序号\t\t宠物名称\t\t宠物类型");
                PerService per = new PerService();
                per.GetNoPetOwnerInfos(number);
            }
        }

        /// <summary>
        /// 将宠物卖给宠物商店
        /// </summary>
        public void SellPetStore(PetOwner pet)
        {            
            //创建调用输出宠物主人的宠物表
            PetOwnerService p = new PetOwnerService();
            PetOwnerService petowner=new PetOwnerService();
            petowner.Sell(pet);
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "Y")
                {
                    Console.WriteLine("----------下面是现有宠物商店，请选择你要卖的给买家序号");
                    PetStoreService petstore = new PetStoreService();
                    petstore.GetPetStoreALL();
                    string s = Console.ReadLine();
                    break;
                }
                else if (str == "N")
                {

                    Console.WriteLine("交易结束");
                    break;
                }
                else
                {
                    Console.WriteLine("输入不正确请重新输入");
                }
            }
        }
    }
}
=======
            }
            else if(number==2)
            {
                Console.WriteLine("---------------新培育宠物--------------------");
                Console.WriteLine("序号\t\t宠物名称\t\t宠物类型");
                PerService per = new PerService();
                per.GetNoPetOwnerInfos(number);
            }
        }

        /// <summary>
        /// 将宠物卖给宠物商店
        /// </summary>
        public void SellPetStore(PetOwner pet)
        {            
            //创建调用输出宠物主人的宠物表
            PetOwnerService p = new PetOwnerService();
            PetOwnerService petowner=new PetOwnerService();
            petowner.Sell(pet);
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "Y")
                {
                    Console.WriteLine("----------下面是现有宠物商店，请选择你要卖的给买家序号");
                    PetStoreService petstore = new PetStoreService();
                    petstore.GetPetStoreALL();
                    string s = Console.ReadLine();
                    break;
                }
                else if (str == "N")
                {

                    Console.WriteLine("交易结束");
                    break;
                }
                else
                {
                    Console.WriteLine("输入不正确请重新输入");
                }
            }
        }
    }
}
>>>>>>> 45f0c71 (new)
