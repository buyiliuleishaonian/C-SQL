<<<<<<< HEAD
﻿using JD.BLL;
using JD.Common;
using JD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //E10ADC3949BA59ABBE56E057F20F883E
            //注册 123456加密E10ADC3949BA59ABBE56E057F20F883E
            //登录 123456加密E10ADC3949BA59ABBE56E057F20F883E
            //暴力破解(理论)
             string str = DataEncrypt.MD5Encrypt("sdfh123123d");//密码  MD5加密，MD5加密


            //string desEStr = DataEncrypt.DESEncrypt("2000/01/12,zhangsan,19");//加密
            //string desDStr = DataEncrypt.DESDecrypt(desEStr);//解密
            //2000/01/12,zhangsan,19
            //UserManager userManager = new UserManager();
            //if (userManager.Add(new UserModel()))
            //{
            //    Console.WriteLine("添加成功!");
            //}
        }
    }
}
=======
﻿using JD.BLL;
using JD.Common;
using JD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //E10ADC3949BA59ABBE56E057F20F883E
            //注册 123456加密E10ADC3949BA59ABBE56E057F20F883E
            //登录 123456加密E10ADC3949BA59ABBE56E057F20F883E
            //暴力破解(理论)
             string str = DataEncrypt.MD5Encrypt("sdfh123123d");//密码  MD5加密，MD5加密


            //string desEStr = DataEncrypt.DESEncrypt("2000/01/12,zhangsan,19");//加密
            //string desDStr = DataEncrypt.DESDecrypt(desEStr);//解密
            //2000/01/12,zhangsan,19
            //UserManager userManager = new UserManager();
            //if (userManager.Add(new UserModel()))
            //{
            //    Console.WriteLine("添加成功!");
            //}
        }
    }
}
>>>>>>> 45f0c71 (new)
