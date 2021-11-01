using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyShop.WebApp.Models;
using MyShop.WebApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public HomeController(ILogger<HomeController> logger, IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _logger = logger;
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel()
            {
                FeaturedProducts = await _productApiClient.GetFeaturedProducts(5),
                ProductsLower15 = await _productApiClient.GetProductsLower15(5),
                Products15To20 = await _productApiClient.GetProducts15To20(5),
                ProductsHigher20 = await _productApiClient.GetProductsHigher20(5),
                Categories = await _categoryApiClient.GetAll(),
            };
            
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
