<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                string s = Console.ReadLine();
                int num = Convert.ToInt32(s);
                if (num== 22)
                {
                    throw new ValueInvalidExcetion();
                }//明确抛出一个异常
                Console.WriteLine(num);
            }
            catch (ValueInvalidExcetion e)
            {
                Console.WriteLine("值无效");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine("dadadadddddddddddddd");
            }
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

namespace Try异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                string s = Console.ReadLine();
                int num = Convert.ToInt32(s);
                if (num== 22)
                {
                    throw new ValueInvalidExcetion();
                }//明确抛出一个异常
                Console.WriteLine(num);
            }
            catch (ValueInvalidExcetion e)
            {
                Console.WriteLine("值无效");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine("dadadadddddddddddddd");
            }
            Console.ReadKey();
        }
    }
}
>>>>>>> 45f0c71 (new)
