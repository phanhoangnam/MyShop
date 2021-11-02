using MyShop.ViewModels.Categories;
using MyShop.ViewModels.ProductImages;
using MyShop.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryViewModel Category { get; set; }

        public ProductViewModel Product { get; set; }

        public List<ProductViewModel> RelatedProducts { get; set; }

        //public List<ProductImageViewModel> ProductImages { get; set; }
    }
}
