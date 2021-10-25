using Microsoft.EntityFrameworkCore;
using MyShop.Data.EF;
using MyShop.Data.Entities;
using MyShop.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.Categories
{
    public class ManageCategoryService : IManageCategoryService
    {
        private readonly MyShopDBContext _context;

        public ManageCategoryService(MyShopDBContext context)
        {
            _context = context;
        }

        public async Task<int> Create(CategoryCreateRequest request)
        {
            var category = new Category()
            {
                Name = request.Name,
                Description = request.Description,
                IsShowOnHome = request.IsShowOnHome,
                Status = request.Status
            };

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category.Id;

        }

        public async Task<int> Delete(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            if (category == null)
            {
                throw new Exception($"Cannot find a category : {categoryId}");
            }

            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            var categories = _context.Categories;

            var data = await categories.Select(x => new CategoryViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                IsShowOnHome = x.IsShowOnHome,
                Status = x.Status
            }).ToListAsync();

            return data;
        }

        public async Task<CategoryViewModel> GetById(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            var categoryViewModel = new CategoryViewModel()
            {
                Name = category.Name,
                Description = category.Description,
                IsShowOnHome = category.IsShowOnHome,
                Status = category.Status
            };

            return categoryViewModel;
        }

        public async Task<int> Update(CategoryUpdateRequest request)
        {
            var category = await _context.Categories.FindAsync(request.Id);
            if (category == null)
            {
                throw new Exception($"Cannot find a category with Id: {request.Id}");
            }

            category.Name = request.Name;
            category.Description = request.Description;
            category.IsShowOnHome = request.IsShowOnHome;
            category.Status = request.Status;

            return await _context.SaveChangesAsync();
        }
    }
}
