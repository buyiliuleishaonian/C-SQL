<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 元组类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (double, int, float) value1 = (1.0,2,3f);
            Console.WriteLine(value1.Item1);
            Console.WriteLine(value1.Item2);
            Console.WriteLine(value1.Item3);

            (double va, int vb, float vc) value2 = (1.0,2,2f);
            Console.WriteLine( value2.va );
            Console.WriteLine(value2.vb);
            Console.WriteLine(value2.vc);

            //隐式类型var 靠计算机来推断是什么类型
            var value3 = (vb:1.0,vc:0.2,vd: 3f);
            Console.WriteLine(value3.vb);
            Console.WriteLine(value3.vc);
            Console.WriteLine(value3.vd);


            var (v1, v2) = (1, 2.0);
            Console.WriteLine(v1);
            Console.WriteLine(v2);

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

namespace 元组类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (double, int, float) value1 = (1.0,2,3f);
            Console.WriteLine(value1.Item1);
            Console.WriteLine(value1.Item2);
            Console.WriteLine(value1.Item3);

            (double va, int vb, float vc) value2 = (1.0,2,2f);
            Console.WriteLine( value2.va );
            Console.WriteLine(value2.vb);
            Console.WriteLine(value2.vc);

            //隐式类型var 靠计算机来推断是什么类型
            var value3 = (vb:1.0,vc:0.2,vd: 3f);
            Console.WriteLine(value3.vb);
            Console.WriteLine(value3.vc);
            Console.WriteLine(value3.vd);


            var (v1, v2) = (1, 2.0);
            Console.WriteLine(v1);
            Console.WriteLine(v2);

            Console.ReadKey();
        }
    }
}
>>>>>>> 45f0c71 (new)
