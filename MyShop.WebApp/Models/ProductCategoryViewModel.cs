using MyShop.ViewModels.Categories;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }

        public PagedResult<ProductViewModel> Products { get; set; }
    }
}
