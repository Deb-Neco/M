﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniChef.Domain.Model
{
    public class User
    {
        public int id { get; set; } 

        public string nome { get; set; }    

        public string senha { get; set; }

        public string email { get; set; }
    }
}
