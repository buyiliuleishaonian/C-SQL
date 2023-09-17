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
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 尝试SQL中的临时表，数据集，
            //UserinfoManager userinfoManager = new UserinfoManager();
            //userinfoManager.GetUserInfos();
            //Console.ReadKey();
            #endregion

            #region  尝试三元结构是否正确
            //Register re = new Register();
            //UserinfoManager us=new UserinfoManager();
            //bool b= re.RegisterUser(us);
            // if (b)
            // {
            //     Console.WriteLine("添加成功");
            // }
            // else 
            // {
            //     Console.WriteLine("添加失败");
            // }
            // Console.ReadKey();
            #endregion

            ProductInfo productInfo = new ProductInfo();
            ProductModel productModel = new ProductModel(1,1,"phone13",5000m);
            productInfo.AddShoppingCart( productModel,productInfo.ShoppingCart());
            Console.ReadKey();
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
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 尝试SQL中的临时表，数据集，
            //UserinfoManager userinfoManager = new UserinfoManager();
            //userinfoManager.GetUserInfos();
            //Console.ReadKey();
            #endregion

            #region  尝试三元结构是否正确
            //Register re = new Register();
            //UserinfoManager us=new UserinfoManager();
            //bool b= re.RegisterUser(us);
            // if (b)
            // {
            //     Console.WriteLine("添加成功");
            // }
            // else 
            // {
            //     Console.WriteLine("添加失败");
            // }
            // Console.ReadKey();
            #endregion

            ProductInfo productInfo = new ProductInfo();
            ProductModel productModel = new ProductModel(1,1,"phone13",5000m);
            productInfo.AddShoppingCart( productModel,productInfo.ShoppingCart());
            Console.ReadKey();
        }
    }
}
>>>>>>> 45f0c71 (new)
