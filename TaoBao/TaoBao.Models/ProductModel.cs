<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoBao.Models
{
    public  class ProductModel
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductNumber { get; set; }

        public ProductModel(int id,int number ,string name,decimal money)
        {
            this.ID = id;
            this.ProductName = name;    
            this.ProductPrice = money;
            this.ProductNumber = number;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoBao.Models
{
    public  class ProductModel
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductNumber { get; set; }

        public ProductModel(int id,int number ,string name,decimal money)
        {
            this.ID = id;
            this.ProductName = name;    
            this.ProductPrice = money;
            this.ProductNumber = number;
        }
    }
}
>>>>>>> 45f0c71 (new)
