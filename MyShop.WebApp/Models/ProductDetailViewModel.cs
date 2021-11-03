using MyShop.ViewModels.Categories;
using MyShop.ViewModels.ProductRatings;
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

        public List<ProductRatingViewModel> Ratings { get; set; }
        public string Comment { get; set; }
        public Guid UserId { get; set; }
        public int ProductId { get; set; }

        //public List<ProductImageViewModel> ProductImages { get; set; }
    }
}
