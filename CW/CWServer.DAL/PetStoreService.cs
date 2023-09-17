<<<<<<< HEAD
﻿using CW.Common;
using CWModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWServer.DAL
{
    public class PetStoreService : InterfaceCW
    {
        public void Bread(PetCW pet)
        {

        }

        public void Buy(PetCW pet)
        {
        }
   

        public void GetAccount(int storeid)
        {

        }

        public void GetPetBread(int storeid)
        {

        }

        public void GetPetByStoreId(int storeid)
        {
            
        }

        public void Login(PetStoreCW perstrorcw)
        {

        }

        /// <summary>
        /// 将对应名字和密码的，宠物商店信息输出
        /// </summary>
        /// <param name="perstrorcw"></param>
        /// <returns></returns>
        public bool Login1(PetStoreCW perstrorcw)
        {
            string sql = "select * from  sdinfos    where   name=@name and  password=@password ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("name",perstrorcw.Name),
                new SqlParameter("password",perstrorcw.PassWord)
            };
            DataRow datarow = SQLhelper.GetDataRow(sql, sp);
            if (datarow != null)
            {
                Console.WriteLine("-------------登录成功--------------");
                Console.WriteLine("-----------您的基本信息：-----------");
                Console.WriteLine("商店名字:\t{0}", datarow[1].ToString());
                Console.WriteLine("宠物数量：\t{0}", (int)datarow[3]);
                Console.WriteLine("登入成功，您可以选择购买和卖出宠物，如果你想要购买宠物请输入1，如果你想要卖出宠物请输入2");
                Console.WriteLine("1、购买宠物");
                Console.WriteLine("2、卖出宠物");
                return true;
            }
            else
            {
                Console.WriteLine("登入失败");
                return false;
            }
        }

        public void Sell(PetCW pet)
        {

        }

        /// <summary>
        /// 将宠物商店的id和名字读出出来
        /// </summary>
        public void GetPetStoreALL()
        {
            string sql = "select *from sdinfos";
            DataTable datatable = SQLhelper.GetDataTable(sql);
            foreach (DataRow row in datatable.Rows)
            {
                Console.WriteLine("{0}\t{1}", (int)row[0], row[1].ToString());
            }
        }
    }
}
=======
﻿using CW.Common;
using CWModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWServer.DAL
{
    public class PetStoreService : InterfaceCW
    {
        public void Bread(PetCW pet)
        {

        }

        public void Buy(PetCW pet)
        {
        }
   

        public void GetAccount(int storeid)
        {

        }

        public void GetPetBread(int storeid)
        {

        }

        public void GetPetByStoreId(int storeid)
        {
            
        }

        public void Login(PetStoreCW perstrorcw)
        {

        }

        /// <summary>
        /// 将对应名字和密码的，宠物商店信息输出
        /// </summary>
        /// <param name="perstrorcw"></param>
        /// <returns></returns>
        public bool Login1(PetStoreCW perstrorcw)
        {
            string sql = "select * from  sdinfos    where   name=@name and  password=@password ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("name",perstrorcw.Name),
                new SqlParameter("password",perstrorcw.PassWord)
            };
            DataRow datarow = SQLhelper.GetDataRow(sql, sp);
            if (datarow != null)
            {
                Console.WriteLine("-------------登录成功--------------");
                Console.WriteLine("-----------您的基本信息：-----------");
                Console.WriteLine("商店名字:\t{0}", datarow[1].ToString());
                Console.WriteLine("宠物数量：\t{0}", (int)datarow[3]);
                Console.WriteLine("登入成功，您可以选择购买和卖出宠物，如果你想要购买宠物请输入1，如果你想要卖出宠物请输入2");
                Console.WriteLine("1、购买宠物");
                Console.WriteLine("2、卖出宠物");
                return true;
            }
            else
            {
                Console.WriteLine("登入失败");
                return false;
            }
        }

        public void Sell(PetCW pet)
        {

        }

        /// <summary>
        /// 将宠物商店的id和名字读出出来
        /// </summary>
        public void GetPetStoreALL()
        {
            string sql = "select *from sdinfos";
            DataTable datatable = SQLhelper.GetDataTable(sql);
            foreach (DataRow row in datatable.Rows)
            {
                Console.WriteLine("{0}\t{1}", (int)row[0], row[1].ToString());
            }
        }
    }
}
>>>>>>> 45f0c71 (new)
