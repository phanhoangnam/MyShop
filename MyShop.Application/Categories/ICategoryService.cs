using MyShop.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.Categories
{
    public interface ICategoryService
    {
        Task<int> Create(CategoryCreateRequest request);
        Task<int> Update(CategoryUpdateRequest request);
        Task<int> Delete(int categoryId);
        Task<CategoryViewModel> GetById(int categoryId);
        Task<List<CategoryViewModel>> GetAll();
    }
}
