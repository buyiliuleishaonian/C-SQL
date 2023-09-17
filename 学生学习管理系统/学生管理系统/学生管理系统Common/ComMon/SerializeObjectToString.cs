using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//引入三个命名空间
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace 学生管理系统Common
{
    [Serializable]
    public class SerializeObjectToString
    {
        //将Object类型对象(注：必须是可序列化的对象)转换为二进制序列字符串
        /// <summary>
        /// 将object对象的属性转化成二进制字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string SerializeObject(object obj)
        {
            IFormatter formatter = new BinaryFormatter();
            string result = string.Empty;
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, obj);
                byte[] byt = new byte[stream.Length];
                byt = stream.ToArray();
                //result = Encoding.UTF8.GetString(byt, 0, byt.Length);
                result = Convert.ToBase64String(byt);
                stream.Flush();
            }
            return result;
        
        }
        /// <summary>
        /// 将二进制转化为object类型对象
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        //将二进制序列字符串转换为Object类型对象
        public object DeserializeObject(string str)
        {
            IFormatter formatter = new BinaryFormatter();
            //byte[] byt = Encoding.UTF8.GetBytes(str);
            byte[] byt = Convert.FromBase64String(str);
            object obj = null;
            using (Stream stream = new MemoryStream(byt, 0, byt.Length))
            {
                obj = formatter.Deserialize(stream);
            }
            return obj;
        }
    }
}
