using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyShop.ViewModels.ProductRatings;
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
        private readonly IUserApiClient _userApiClient;
        private int productId;

        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient, IUserApiClient userApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
            _userApiClient = userApiClient;
        }

        public async Task<IActionResult> Detail(int id)
        {
            productId = id;
            //ViewBag.Rating = new ProductRatingCreateRequest();
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
                Ratings = await _productApiClient.GetRatingByProductId(id), 
            });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddRating(ProductRatingCreateRequest request)
        {
            
            var userId = await _userApiClient.GetUserByUserName(User.Identity.Name);
            await _productApiClient.AddRating(request.ProductId, userId.Id, request);

            return RedirectToAction("Detail", "Product", new { id = request.ProductId });
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
