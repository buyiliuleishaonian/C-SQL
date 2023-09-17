<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CWManager.BLL;
using CWModel.Model;

namespace CW.web
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //启动系统
            int number = StartXiTong();               
            try
            {
                if (number == 1)
                {
                    int num = 1;
                    Console.Clear();
                    PetOwner petowner = LoginOwner(number);
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        BuyPet();
                    }
                    else if (n == 2)
                    {
                        SellPet(petowner);
                    }
                }
                else if (number == 2)
                {
                    Console.Clear();
                    LoginPetShopManager(number);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message) ;
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 启动启动界面
        /// </summary>
        public static int StartXiTong()
        {
            Console.WriteLine("Windows醒来，所有宠物从SQLserver中醒来");
            StartPetShopManager startPetShopManager = new StartPetShopManager();
            startPetShopManager.GetPetALL();
            Console.WriteLine("请选择输入登录模式，输入1为宠物主人登录，输入2为宠物商店登录");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        /// <summary>
        /// 登入宠物主人的信息
        /// </summary>
        /// <param name="number"></param>
        public static PetOwner  LoginOwner(int number)
        {
            Console.WriteLine("请选择输入登录模式，输入1为宠物主人登录，输入2为宠物商店登录");
            Console.WriteLine(number);
            LoginOwnerManager loginOwnerManager = new LoginOwnerManager();
            return loginOwnerManager.Login();            
        }
        /// <summary>
        /// 登入宠物商店信息
        /// </summary>
        /// <param name="number"></param>
        public static void LoginPetShopManager(int number )
        {
            Console.WriteLine("请选择输入登录模式，输入1为宠物主人登录，输入2为宠物商店登录");
            Console.WriteLine(number);
            LoginStoreManager loginStoreManager = new LoginStoreManager();
            loginStoreManager.Lgion();
        }

        /// <summary>
        /// 购买库存宠物
        /// </summary>
        /// <param name="number"></param>
        public static void BuyPet()
        {
           BuyPetOwnerManager buyPetOwnerManager = new BuyPetOwnerManager();
            buyPetOwnerManager.Buypet();
        }
        /// <summary>
        /// 宠物主人，将选择某个出售宠物
        /// </summary>
        /// <param name="petstore"></param>
        public static void SellPet(PetOwner petstore)
        {
            BuyPetOwnerManager pet = new BuyPetOwnerManager();
            pet.SellPetStore(petstore);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CWManager.BLL;
using CWModel.Model;

namespace CW.web
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //启动系统
            int number = StartXiTong();               
            try
            {
                if (number == 1)
                {
                    int num = 1;
                    Console.Clear();
                    PetOwner petowner = LoginOwner(number);
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 1)
                    {
                        BuyPet();
                    }
                    else if (n == 2)
                    {
                        SellPet(petowner);
                    }
                }
                else if (number == 2)
                {
                    Console.Clear();
                    LoginPetShopManager(number);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message) ;
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 启动启动界面
        /// </summary>
        public static int StartXiTong()
        {
            Console.WriteLine("Windows醒来，所有宠物从SQLserver中醒来");
            StartPetShopManager startPetShopManager = new StartPetShopManager();
            startPetShopManager.GetPetALL();
            Console.WriteLine("请选择输入登录模式，输入1为宠物主人登录，输入2为宠物商店登录");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        /// <summary>
        /// 登入宠物主人的信息
        /// </summary>
        /// <param name="number"></param>
        public static PetOwner  LoginOwner(int number)
        {
            Console.WriteLine("请选择输入登录模式，输入1为宠物主人登录，输入2为宠物商店登录");
            Console.WriteLine(number);
            LoginOwnerManager loginOwnerManager = new LoginOwnerManager();
            return loginOwnerManager.Login();            
        }
        /// <summary>
        /// 登入宠物商店信息
        /// </summary>
        /// <param name="number"></param>
        public static void LoginPetShopManager(int number )
        {
            Console.WriteLine("请选择输入登录模式，输入1为宠物主人登录，输入2为宠物商店登录");
            Console.WriteLine(number);
            LoginStoreManager loginStoreManager = new LoginStoreManager();
            loginStoreManager.Lgion();
        }

        /// <summary>
        /// 购买库存宠物
        /// </summary>
        /// <param name="number"></param>
        public static void BuyPet()
        {
           BuyPetOwnerManager buyPetOwnerManager = new BuyPetOwnerManager();
            buyPetOwnerManager.Buypet();
        }
        /// <summary>
        /// 宠物主人，将选择某个出售宠物
        /// </summary>
        /// <param name="petstore"></param>
        public static void SellPet(PetOwner petstore)
        {
            BuyPetOwnerManager pet = new BuyPetOwnerManager();
            pet.SellPetStore(petstore);
        }
    }
}
>>>>>>> 45f0c71 (new)
