<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 猜拳游戏
{
    internal class Program
    {
        static Random rannum = new Random();
        static void Main(string[] args)
        {
            while (true)
            {
                //1、石头，2、剪刀，3、布
                Console.WriteLine("请选择出什么,1、拳头，2、剪刀，3、石头");
                string num = Console.ReadLine();
                int nums = rannum.Next(1, 4);
                Console.WriteLine("玩家出{0}", Comper(Convert.ToInt32(num)));
                Console.WriteLine("电脑出{0}",Comper(nums));
                Console.WriteLine(Test(Convert.ToInt32(num), nums));
                Console.ReadKey();
            }
        }
        /// <summary>
        /// 电脑随机生成的和玩家生成的
        /// </summary>
        /// <returns></returns>
        public static string Comper(int num)
        {
            string name = null;
            //生成一个随机数
            switch (num)
            {
                case 1:
                    name="拳头";
                    break;
                case 2:
                    name= "剪刀";
                    break;
                case 3: 
                    name= "布";
                    break;
            }
            return name;
        }
        public static  string Test(params int[] x)
        {
            string s = null;
            switch (x[0] - x[1])
            {
                case -1:
                case 2: s = "玩家赢";
                    break;
                case 0: s = "平局";
                    break;
                default:
                    s = "电脑赢";
                    break;
            }
            return s;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 猜拳游戏
{
    internal class Program
    {
        static Random rannum = new Random();
        static void Main(string[] args)
        {
            while (true)
            {
                //1、石头，2、剪刀，3、布
                Console.WriteLine("请选择出什么,1、拳头，2、剪刀，3、石头");
                string num = Console.ReadLine();
                int nums = rannum.Next(1, 4);
                Console.WriteLine("玩家出{0}", Comper(Convert.ToInt32(num)));
                Console.WriteLine("电脑出{0}",Comper(nums));
                Console.WriteLine(Test(Convert.ToInt32(num), nums));
                Console.ReadKey();
            }
        }
        /// <summary>
        /// 电脑随机生成的和玩家生成的
        /// </summary>
        /// <returns></returns>
        public static string Comper(int num)
        {
            string name = null;
            //生成一个随机数
            switch (num)
            {
                case 1:
                    name="拳头";
                    break;
                case 2:
                    name= "剪刀";
                    break;
                case 3: 
                    name= "布";
                    break;
            }
            return name;
        }
        public static  string Test(params int[] x)
        {
            string s = null;
            switch (x[0] - x[1])
            {
                case -1:
                case 2: s = "玩家赢";
                    break;
                case 0: s = "平局";
                    break;
                default:
                    s = "电脑赢";
                    break;
            }
            return s;
        }
    }
}
>>>>>>> 45f0c71 (new)
