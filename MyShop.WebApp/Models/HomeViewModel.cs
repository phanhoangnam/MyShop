using MyShop.ViewModels.Categories;
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
        public List<ProductViewModel> ProductsLower15 { get; set; }
        public List<ProductViewModel> Products15To20 { get; set; }
        public List<ProductViewModel> ProductsHigher20 { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
    }
}
