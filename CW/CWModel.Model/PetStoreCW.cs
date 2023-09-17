<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWModel.Model
{
   public class PetStoreCW
    {
        public  int ID
        { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public int Balance { get; set; }

        public PetStoreCW(string name,string password) 
        {
            this.Name = name;
            this.PassWord = password;
        } 
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWModel.Model
{
   public class PetStoreCW
    {
        public  int ID
        { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public int Balance { get; set; }

        public PetStoreCW(string name,string password) 
        {
            this.Name = name;
            this.PassWord = password;
        } 
    }
}
>>>>>>> 45f0c71 (new)
