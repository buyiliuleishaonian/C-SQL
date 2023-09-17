<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoBao.Models;

namespace TaoBao.web
{
    public class ProductInfo
    {
        /// <summary>
        /// 创建一张临时表，在其中添加某些列
        /// </summary>
        /// <returns></returns>
        public DataTable ShoppingCart()
        {
            DataTable da= new DataTable();//实列化对象，没有结构
            //产品表
            da.Columns.Add("ID");
            da.Columns.Add("ProductName");
            da.Columns.Add("ProductPrice");
            da.Columns.Add("number");
            return da;
        }
        /// <summary>
        /// 对于临时表，添加数据
        /// </summary>
        /// <param name="productModel"></param>
        /// <param name="dataTable"></param>
        public void AddShoppingCart(ProductModel productModel,DataTable dataTable)
        {
            DataRow row = dataTable.NewRow();//没有结构
            row["id"] = productModel.ID;
            row["productname"] = productModel.ProductName;
            row["productprice"] = productModel.ProductPrice;
            row["number"] = productModel.ProductNumber;
            dataTable.Rows.Add(row);//临时表可以把多张表结合，自定义字段
            //泛型集合不需要类型转换
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaoBao.Models;

namespace TaoBao.web
{
    public class ProductInfo
    {
        /// <summary>
        /// 创建一张临时表，在其中添加某些列
        /// </summary>
        /// <returns></returns>
        public DataTable ShoppingCart()
        {
            DataTable da= new DataTable();//实列化对象，没有结构
            //产品表
            da.Columns.Add("ID");
            da.Columns.Add("ProductName");
            da.Columns.Add("ProductPrice");
            da.Columns.Add("number");
            return da;
        }
        /// <summary>
        /// 对于临时表，添加数据
        /// </summary>
        /// <param name="productModel"></param>
        /// <param name="dataTable"></param>
        public void AddShoppingCart(ProductModel productModel,DataTable dataTable)
        {
            DataRow row = dataTable.NewRow();//没有结构
            row["id"] = productModel.ID;
            row["productname"] = productModel.ProductName;
            row["productprice"] = productModel.ProductPrice;
            row["number"] = productModel.ProductNumber;
            dataTable.Rows.Add(row);//临时表可以把多张表结合，自定义字段
            //泛型集合不需要类型转换
        }
    }
}
>>>>>>> 45f0c71 (new)
