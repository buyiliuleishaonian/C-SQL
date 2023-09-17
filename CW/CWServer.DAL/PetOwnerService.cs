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
    public class PetOwnerService : InterfaceCW
    {
        public void Bread(PetCW pet)
        {

        }

        public void Buy(PetCW pet)
        {

        }

        public void Buy()
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
        public void Sell(PetCW pet)
        {

        }
        /// <summary>
        /// 将宠物主人的宠物，选择一个卖给宠物商店
        /// </summary>
        public void Sell(PetOwner pet)
        {
            int number = 0;
            List<DataRow> list = new List<DataRow>();
            string sql = "select  name,typename from cwinfos where owner_id=@owner";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("owner",pet.Id)
            };
            DataTable datatable = SQLhelper.GetDataTable(sql, sqlParameters);
            foreach (DataRow row in datatable.Rows)
            {
                Console.WriteLine("{0}\t{1}\t{2}", ++number, row[0].ToString(), row[1].ToString());
                list.Add(row);
            }
            Console.WriteLine("---------请选择要出售的宠物序号---------------");
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("宠物名字叫{0}\t宠物类型{1}", list[num]["name"].ToString(), list[num]["typename"].ToString());
                    Console.WriteLine("请确认是否卖出，卖出输入Y，N不卖出");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("输入错误，请重新输入");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// 将宠物主人的id和名字读取出来
        /// </summary>
        public void GetPetOwenr()
        {
            string sql = "select * from  cwpersoninfos";
            DataTable datatable = SQLhelper.GetDataTable(sql);
            foreach (DataRow row in datatable.Rows)
            {
                Console.WriteLine("{0}\t{1}", (int)row[0], row[1].ToString());
            }
        }

        /// <summary>
        /// 登入用户信息
        /// </summary>
        /// <param name="petowner"></param>
        public  PetOwner Login(PetOwner petowner)
        {
            string sql = "select * from  cwpersoninfos    where   name=@name and  password=@password ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("name",petowner.Name),
                new SqlParameter("password",petowner.Password)
            };
            DataRow datarow = SQLhelper.GetDataRow(sql, sp);
                if (datarow != null)
                {
                    Console.WriteLine("-------------登录成功--------------");
                    Console.WriteLine("-----------您的基本信息：-----------");
                    Console.WriteLine("名字:\t{0}", datarow[1].ToString());
                    Console.WriteLine("元宝数：\t{0}", (int)datarow[3]);
                    Console.WriteLine("登入成功，您可以选择购买和卖出宠物，如果你想要购买宠物请输入1，如果你想要卖出宠物请输入2");
                    Console.WriteLine("1、购买宠物");
                    Console.WriteLine("2、卖出宠物");
                }
                else
                {
                    Console.WriteLine("登入失败");
                    
                }
            petowner.Id = (int)datarow["id"];
            return petowner;
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
    public class PetOwnerService : InterfaceCW
    {
        public void Bread(PetCW pet)
        {

        }

        public void Buy(PetCW pet)
        {

        }

        public void Buy()
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
        public void Sell(PetCW pet)
        {

        }
        /// <summary>
        /// 将宠物主人的宠物，选择一个卖给宠物商店
        /// </summary>
        public void Sell(PetOwner pet)
        {
            int number = 0;
            List<DataRow> list = new List<DataRow>();
            string sql = "select  name,typename from cwinfos where owner_id=@owner";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("owner",pet.Id)
            };
            DataTable datatable = SQLhelper.GetDataTable(sql, sqlParameters);
            foreach (DataRow row in datatable.Rows)
            {
                Console.WriteLine("{0}\t{1}\t{2}", ++number, row[0].ToString(), row[1].ToString());
                list.Add(row);
            }
            Console.WriteLine("---------请选择要出售的宠物序号---------------");
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("宠物名字叫{0}\t宠物类型{1}", list[num]["name"].ToString(), list[num]["typename"].ToString());
                    Console.WriteLine("请确认是否卖出，卖出输入Y，N不卖出");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("输入错误，请重新输入");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// 将宠物主人的id和名字读取出来
        /// </summary>
        public void GetPetOwenr()
        {
            string sql = "select * from  cwpersoninfos";
            DataTable datatable = SQLhelper.GetDataTable(sql);
            foreach (DataRow row in datatable.Rows)
            {
                Console.WriteLine("{0}\t{1}", (int)row[0], row[1].ToString());
            }
        }

        /// <summary>
        /// 登入用户信息
        /// </summary>
        /// <param name="petowner"></param>
        public  PetOwner Login(PetOwner petowner)
        {
            string sql = "select * from  cwpersoninfos    where   name=@name and  password=@password ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("name",petowner.Name),
                new SqlParameter("password",petowner.Password)
            };
            DataRow datarow = SQLhelper.GetDataRow(sql, sp);
                if (datarow != null)
                {
                    Console.WriteLine("-------------登录成功--------------");
                    Console.WriteLine("-----------您的基本信息：-----------");
                    Console.WriteLine("名字:\t{0}", datarow[1].ToString());
                    Console.WriteLine("元宝数：\t{0}", (int)datarow[3]);
                    Console.WriteLine("登入成功，您可以选择购买和卖出宠物，如果你想要购买宠物请输入1，如果你想要卖出宠物请输入2");
                    Console.WriteLine("1、购买宠物");
                    Console.WriteLine("2、卖出宠物");
                }
                else
                {
                    Console.WriteLine("登入失败");
                    
                }
            petowner.Id = (int)datarow["id"];
            return petowner;
        }
    }
}
>>>>>>> 45f0c71 (new)
