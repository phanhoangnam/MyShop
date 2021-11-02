using MyShop.ViewModels.Categories;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApp.Services
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryViewModel>> GetAll();
        Task<CategoryViewModel> GetById(int id);
    }
}
