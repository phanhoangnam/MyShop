using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyShop.Data.EF;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.Products;

namespace MyShop.Application.Products
{
    public class PublicProductService : IPublicProductService
    {
        private readonly MyShopDBContext _context;
        public PublicProductService(MyShopDBContext context)
        {
            _context = context;
        }

        

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
                    Configuration = x.p.Configuration,
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
