<<<<<<< HEAD
﻿using CWModel.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CW.Common;
using System.Data;

namespace CWServer.DAL
{
    public class PerService : InterfaceCW
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

        public void Sell(PetCW pet)
        {
            
        }


        /// <summary>
        /// 将宠物表示中id和名字显示
        /// </summary>
        public void GetPetInfos()
        {
            string sql = "select * from cwinfos";
            DataTable dataTable= SQLhelper.GetDataTable(sql);
            //通过循环将datatable中的每一行都读取出来
            foreach (DataRow row in dataTable.Rows) 
            {
                Console.WriteLine("{0}\t{1}", row[0], row[1]);
            }
        }

        /// <summary>
        /// 将宠物商店的宠物全部筛选出来
        /// 并将选定的宠物名和宠物类型，读取出来
        /// </summary>
        public void GetNoPetOwnerInfos(int num)
        {
            //在sql中想要查询列为空，需要用关键字is
            if (num == 1)
            {
                Dictionary<int, DataRow> dic = new Dictionary<int, DataRow>();
                int number = 0;
                string sql = "select  name,typename from  cwinfos where  owner_id is null";
                DataTable datatable = SQLhelper.GetDataTable(sql);
                ///将满足条件数据构建成一个临时数据表，然后一行行输出
                foreach (DataRow row in datatable.Rows)
                {
                    ++number;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}",number , row[0].ToString(), row[1].ToString(), 5);
                    dic.Add(number,row);
                }
                Console.WriteLine("-------------请选择要购买哪一个宠物，输入其序号----------------");
                while (true)
                {
                    try
                    {
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("宠物名叫{0}\t宠物类别{1}", dic[n]["name"].ToString(), dic[n]["typename"].ToString());
                        Console.WriteLine("请确认是否买入，输入Y是买入，输入N是不买");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("输入错误，请重新输入");
                        Console.WriteLine(ex.Message);
                    }                    
                }
            }
            else if(num==2)
            {
                Dictionary<int, DataRow> dic = new Dictionary<int, DataRow>();
                int number = 0;
                string sql = "select id, name,typename from cwinfos where owner_id=2";
                DataTable datatable = SQLhelper.GetDataTable(sql);
                ///将满足条件数据构建成一个临时数据表，然后一行行输出
                foreach (DataRow row in datatable.Rows)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", ++number, row[1].ToString(), row[2].ToString());
                    dic.Add(number, row);
                }
                Console.WriteLine("-------------请选择要购买哪一个宠物，输入其序号----------------");
                while (true)
                {
                    try
                    {
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("宠物名叫{0}\t宠物类别{1}", dic[n]["name"].ToString(), dic[n]["typename"].ToString());
                        Console.WriteLine("请确认是否买入，输入Y是买入，输入N是不买");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("输入错误，请重新输入");
                    }
                }
            }
        }
    }
}
=======
﻿using CWModel.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CW.Common;
using System.Data;

namespace CWServer.DAL
{
    public class PerService : InterfaceCW
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

        public void Sell(PetCW pet)
        {
            
        }


        /// <summary>
        /// 将宠物表示中id和名字显示
        /// </summary>
        public void GetPetInfos()
        {
            string sql = "select * from cwinfos";
            DataTable dataTable= SQLhelper.GetDataTable(sql);
            //通过循环将datatable中的每一行都读取出来
            foreach (DataRow row in dataTable.Rows) 
            {
                Console.WriteLine("{0}\t{1}", row[0], row[1]);
            }
        }

        /// <summary>
        /// 将宠物商店的宠物全部筛选出来
        /// 并将选定的宠物名和宠物类型，读取出来
        /// </summary>
        public void GetNoPetOwnerInfos(int num)
        {
            //在sql中想要查询列为空，需要用关键字is
            if (num == 1)
            {
                Dictionary<int, DataRow> dic = new Dictionary<int, DataRow>();
                int number = 0;
                string sql = "select  name,typename from  cwinfos where  owner_id is null";
                DataTable datatable = SQLhelper.GetDataTable(sql);
                ///将满足条件数据构建成一个临时数据表，然后一行行输出
                foreach (DataRow row in datatable.Rows)
                {
                    ++number;
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}",number , row[0].ToString(), row[1].ToString(), 5);
                    dic.Add(number,row);
                }
                Console.WriteLine("-------------请选择要购买哪一个宠物，输入其序号----------------");
                while (true)
                {
                    try
                    {
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("宠物名叫{0}\t宠物类别{1}", dic[n]["name"].ToString(), dic[n]["typename"].ToString());
                        Console.WriteLine("请确认是否买入，输入Y是买入，输入N是不买");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("输入错误，请重新输入");
                        Console.WriteLine(ex.Message);
                    }                    
                }
            }
            else if(num==2)
            {
                Dictionary<int, DataRow> dic = new Dictionary<int, DataRow>();
                int number = 0;
                string sql = "select id, name,typename from cwinfos where owner_id=2";
                DataTable datatable = SQLhelper.GetDataTable(sql);
                ///将满足条件数据构建成一个临时数据表，然后一行行输出
                foreach (DataRow row in datatable.Rows)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", ++number, row[1].ToString(), row[2].ToString());
                    dic.Add(number, row);
                }
                Console.WriteLine("-------------请选择要购买哪一个宠物，输入其序号----------------");
                while (true)
                {
                    try
                    {
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("宠物名叫{0}\t宠物类别{1}", dic[n]["name"].ToString(), dic[n]["typename"].ToString());
                        Console.WriteLine("请确认是否买入，输入Y是买入，输入N是不买");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("输入错误，请重新输入");
                    }
                }
            }
        }
    }
}
>>>>>>> 45f0c71 (new)
