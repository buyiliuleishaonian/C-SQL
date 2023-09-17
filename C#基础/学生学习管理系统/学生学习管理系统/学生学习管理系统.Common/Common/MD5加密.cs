using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 学生学习管理系统.Common
{
    /// <summary>
    /// MD5加密
    /// </summary>
     public class MD5加密
    {
        public static string Md5(string str)
        {
            //先将字符串转换成字节
            byte[] buffer =Encoding.UTF8.GetBytes(str);
            //创建md5对象
            MD5 md5 = MD5.Create();
            //将字节数组进行加密
            buffer = md5.ComputeHash(buffer);
            //再将字节数组转换成字符串
            string psw = null;
            for (int i = 0; i <buffer. Length; i++)
            {
                psw += buffer[i].ToString("x");
            }
            return psw;
        }
    }
}
