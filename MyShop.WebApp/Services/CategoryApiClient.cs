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
            return await GetListAsync<CategoryViewModel>("/api/categories");
        }
    }
}
