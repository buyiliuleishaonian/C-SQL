using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace 学生管理系统Common.ComMon
{
    [Serializable]
    /// <summary>
    /// 自己所学的序列化方式
    /// </summary>
    public class Serializable2
    {
        /// <summary>
        /// 将Object转化为二进制字符串
        /// </summary>
        /// <returns></returns>
        public string SerObj(object obj)
        {
            string s = null;
           BinaryFormatter buffer=new BinaryFormatter();
            using (MemoryStream stream=new  MemoryStream())
            {
                buffer.Serialize(stream, obj);
                byte[] da=new byte[stream.Length];
                da=stream.ToArray();
                s=Convert.ToBase64String(da);
                //当全部转化为二进制的字符串之后，将MemoryStream的对象清空
                stream.Flush();
            }
            return s;
        }
    }
}
