using Microsoft.AspNetCore.Mvc;
using MyShop.ViewModels.Products;
using MyShop.WebApp.Models;
using MyShop.WebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Detail(int id)
        {
            ViewBag.FeaturedProduct = new HomeViewModel()
            {
                FeaturedProducts = await _productApiClient.GetFeaturedProducts(4),
            };

            var product = await _productApiClient.GetById(id);
            return View(new ProductDetailViewModel()
            {
                Product = product,
                Category = await _categoryApiClient.GetById(product.CategoryId),
                RelatedProducts = await _productApiClient.GetFeaturedProducts(4),
            });
        }
         
        public async Task<IActionResult> Category(int id, int page = 1)
        {
            ViewBag.Categories = new HomeViewModel()
            {
                Categories = await _categoryApiClient.GetAll(),
            };

            var products = await _productApiClient.GetPagings(new GetManageProductPagingRequest()
            {
                CategoryId = id,
                PageIndex = page,
                PageSize = 10
            });
            return View(new ProductCategoryViewModel()
            {
                Category = await _categoryApiClient.GetById(id),
                Products = products
            }); ;
        }
    }
}
