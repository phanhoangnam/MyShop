using AutoMapper.Configuration;
using Microsoft.AspNetCore.Http;
using MyShop.ViewModels.Categories;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.Users;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.WebApp.Services
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory, httpContextAccessor)
        {

        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var data = await GetListAsync<CategoryViewModel>("/api/categories");
            return data;
        }

        public async Task<CategoryViewModel> GetById(int id)
        {
            return await GetAsync<CategoryViewModel>($"/api/categories/{id}");
        }
    }
}
