<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWModel;
using CW.Common;
using CWModel.Model;

namespace CWServer.DAL
{
      public  interface InterfaceCW
    {
        /// <summary>
        /// 买
        /// </summary>
        /// <param name="pet">提供一个宠物列表的数据</param>
        void Buy(PetCW pet);

        /// <summary>
        /// 卖
        /// </summary>
        /// <param name="pet"></param>
        void Sell(PetCW pet);

        /// <summary>
        /// 宠物注册
        /// </summary>
        /// <param name="perstrorcw">提供公务表的一个对象</param>
        void Login(PetStoreCW perstrorcw);

        /// <summary>
        /// 增对宠物，增加
        /// </summary>
        /// <param name="pet"></param>
        void Bread(PetCW pet);

        /// <summary>
        /// 对应宠物店iD获取宠物
        /// </summary>
        /// <param name="storeid"></param>
        void GetPetByStoreId(int storeid);

        /// <summary>
        /// 存储
        /// </summary>
        /// <param name="storeid"></param>
        void GetPetBread(int storeid);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="storeid"></param>
        void GetAccount(int storeid);
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CWModel;
using CW.Common;
using CWModel.Model;

namespace CWServer.DAL
{
      public  interface InterfaceCW
    {
        /// <summary>
        /// 买
        /// </summary>
        /// <param name="pet">提供一个宠物列表的数据</param>
        void Buy(PetCW pet);

        /// <summary>
        /// 卖
        /// </summary>
        /// <param name="pet"></param>
        void Sell(PetCW pet);

        /// <summary>
        /// 宠物注册
        /// </summary>
        /// <param name="perstrorcw">提供公务表的一个对象</param>
        void Login(PetStoreCW perstrorcw);

        /// <summary>
        /// 增对宠物，增加
        /// </summary>
        /// <param name="pet"></param>
        void Bread(PetCW pet);

        /// <summary>
        /// 对应宠物店iD获取宠物
        /// </summary>
        /// <param name="storeid"></param>
        void GetPetByStoreId(int storeid);

        /// <summary>
        /// 存储
        /// </summary>
        /// <param name="storeid"></param>
        void GetPetBread(int storeid);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="storeid"></param>
        void GetAccount(int storeid);
    }
}
>>>>>>> 45f0c71 (new)
