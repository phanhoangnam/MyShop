using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyShop.Application.Products;
using MyShop.Data.EF;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.Products;

namespace eShopSolution.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        private readonly MyShopDBContext _context;
        public PublicProductService(MyShopDBContext context)
        {
            _context = context;
        }

        //public async Task<List<ProductViewModel>> GetAll(string languageId)
        //{
        //    // 1. Select join
        //    var query = from p in _context.Products
        //                join pt in _context.ProductTranslations on p.Id equals pt.ProductId
        //                join pic in _context.ProductInCategories on p.Id equals pic.ProductId
        //                join c in _context.Categories on pic.CategoryId equals c.Id
        //                where pt.LanguageId == languageId
        //                select new { p, pt, pic };

        //    var data = await query.Select(x => new ProductViewModel()
        //        {
        //            Id = x.p.Id,
        //            Name = x.pt.Name,
        //            DateCreated = x.p.DateCreated,
        //            Description = x.pt.Description,
        //            Details = x.pt.Details,
        //            LanguageId = x.pt.LanguageId,
        //            OriginalPrice = x.p.OriginalPrice,
        //            Price = x.p.Price,
        //            SeoAlias = x.pt.SeoAlias,
        //            SeoDescription = x.pt.SeoDescription,
        //            SeoTitle = x.pt.SeoTitle,
        //            Stock = x.p.Stock,
        //            ViewCount = x.p.ViewCount
        //        }).ToListAsync();

        //    return data;
        //}

        public async Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request)
        {
            // 1. Select join
            var query = from p in _context.Products
                        join c in _context.Categories on p.CategoryId equals c.Id
                        select new { p };

            // 2. Filter
            
            if (request.CategoryId.HasValue && request.CategoryId.Value > 0)
            {
                query = query.Where(x => x.p.CategoryId == request.CategoryId);
            }

            // 3. Paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
                    CreatedDate = x.p.CreatedDate,
                    UpdatedDate = x.p.UpdatedDate,
                    Description = x.p.Description,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                }).ToListAsync();

            // 4. Select and projection
            var pageResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };

            return pageResult;
        }
    }
}
