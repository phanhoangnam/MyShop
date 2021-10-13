using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public string Caption { get; set; }
        public bool isDefault { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}
