﻿using MyShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsShowOnHome { get; set; }
        public Status Status { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
