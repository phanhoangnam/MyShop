using AutoMapper.Configuration;
using Microsoft.AspNetCore.Http;
using MyShop.ViewModels.Categories;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.ProductRatings;
using MyShop.ViewModels.Products;
using MyShop.ViewModels.Users;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.WebApp.Services
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductApiClient(IHttpClientFactory httpClientFactory,IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory, httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> CreateProduct(ProductCreateRequest request)
        {
            var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString("Token");


            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:5000");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            if (request.ThumbnailImage != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "thumbnailImage", request.ThumbnailImage.FileName);
            }

            requestContent.Add(new StringContent(request.Price.ToString()), "price");
            requestContent.Add(new StringContent(request.OriginalPrice.ToString()), "originalPrice");
            requestContent.Add(new StringContent(request.Name.ToString()), "name");
            requestContent.Add(new StringContent(request.Description.ToString()), "description");
            requestContent.Add(new StringContent(request.Configuration.ToString()), "configuration");
            requestContent.Add(new StringContent(request.CategoryId.ToString()), "categoryId");

            var response = await client.PostAsync($"/api/products/", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<ProductViewModel> GetById(int id)
        {
            var data = await GetAsync<ProductViewModel>($"/api/products/{id}");

            return data;
        }

        public async Task<List<ProductViewModel>> GetFeaturedProducts(int take)
        {
            var data = await GetListAsync<ProductViewModel>($"/api/products/featured/{take}");
            return data;
        }

        public async Task<List<ProductViewModel>> GetProductsLower15(int take)
        {
            var data = await GetListAsync<ProductViewModel>($"/api/products/lower15/{take}");
            return data;
        }

        public async Task<List<ProductViewModel>> GetProducts15To20(int take)
        {
            var data = await GetListAsync<ProductViewModel>($"/api/products/15to20/{take}");
            return data;
        }

        public async Task<List<ProductViewModel>> GetProductsHigher20(int take)
        {
            var data = await GetListAsync<ProductViewModel>($"/api/products/higher20/{take}");
            return data;
        }

        public async Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductViewModel>>(
                $"/api/products/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}&categoryId={request.CategoryId}");

            return data;
        }

        public async Task<bool> AddRating(int productId, Guid userId, ProductRatingCreateRequest request)
        {
            var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString("Token");


            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:5000");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            

            requestContent.Add(new StringContent(request.Comment.ToString()), "comment");
            requestContent.Add(new StringContent(request.Rating.ToString()), "rating");

            var response = await client.PostAsync($"/api/products/{productId}/{userId}/ratings", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<ProductRatingViewModel>> GetRatingByProductId(int productId)
        {
            var data = await GetListAsync<ProductRatingViewModel>($"/api/products/{productId}/ratings");
            return data;
        }
    }
}
