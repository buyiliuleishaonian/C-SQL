<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CW.Common
{
    public class MD5加解密
    {
        public string  GetMd5(string str)
        {
            //首先通过md5的方法创建一个md5的对象，达到实例化
            //MD5是抽象类，无法创建对象，
            MD5 md5 = MD5.Create();
            //首先将需要加密的字符串，给变成字节
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            //之后通过md5加密字符串
            buffer = md5.ComputeHash(buffer);
            //之后将其改为16进制
            string s = null; 
            for (int i = 0; i < buffer.Length; i++) 
            {
                s += buffer[i].ToString("x");
            }
            return s;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CW.Common
{
    public class MD5加解密
    {
        public string  GetMd5(string str)
        {
            //首先通过md5的方法创建一个md5的对象，达到实例化
            //MD5是抽象类，无法创建对象，
            MD5 md5 = MD5.Create();
            //首先将需要加密的字符串，给变成字节
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            //之后通过md5加密字符串
            buffer = md5.ComputeHash(buffer);
            //之后将其改为16进制
            string s = null; 
            for (int i = 0; i < buffer.Length; i++) 
            {
                s += buffer[i].ToString("x");
            }
            return s;
        }
    }
}
>>>>>>> 45f0c71 (new)
