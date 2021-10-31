using MyShop.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApp.Models
{
    public class HomeViewModel
    {
        public List<ProductViewModel> FeaturedProducts { get; set; }
    }
}
