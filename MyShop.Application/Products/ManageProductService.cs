using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MyShop.Application.Common;
using MyShop.Data.EF;
using MyShop.Data.Entities;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.ProductImages;
using MyShop.ViewModels.ProductRatings;
using MyShop.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly MyShopDBContext _context;
        private readonly IStorageService _storageService;

        public ManageProductService(MyShopDBContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<int> AddImage(int productId, ProductImageCreateRequest request)
        {
            var productImage = new ProductImage()
            {
                Caption = request.Caption,
                CreatedDate = DateTime.Now,
                IsDefault = request.IsDefault,
                ProductId = productId,
            };

            // Save image
            if (request.ImageFile != null)
            {
                productImage.ImagePath = await this.SaveFile(request.ImageFile);

            }
            _context.ProductImages.Add(productImage);
            await _context.SaveChangesAsync();
            return productImage.Id;
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Name = request.Name,
                Description = request.Description,
                Configuration = request.Configuration,
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                CategoryId = request.CategoryId,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            // Save image
            if (request.ThumbnailImage != null)
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Caption = "Thumbnail image",
                        CreatedDate = DateTime.Now,
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true
                    }
                };
            }

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                throw new Exception($"Cannot find a product : {productId}");
            }

            var images = _context.ProductImages.Where(i => i.ProductId == productId);
            foreach (var image in images)
            {
                await _storageService.DeleteFileAsync(image.ImagePath);
            }

            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request)
        {
            // 1. Select join
            var query = from p in _context.Products
                        join c in _context.Categories on p.CategoryId equals c.Id
                        select new { p };

            // 2. Filter
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.p.Name.Contains(request.Keyword));
            }

            if (request.CategoryId != null && request.CategoryId != 0)
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
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };

            return pageResult;
        }

        public async Task<ProductViewModel> GetById(int productId)
        {
            var product = await _context.Products.FindAsync(productId);

            var productImage = await _context.ProductImages.Where(x => x.ProductId == productId && x.IsDefault == true).FirstOrDefaultAsync();

            var productViewModel = new ProductViewModel()
            {
                Id = product.Id,
                CreatedDate = product.CreatedDate,
                UpdatedDate = product.UpdatedDate,
                Description = product.Description,
                Configuration = product.Configuration,
                Name = product.Name,
                OriginalPrice = product.OriginalPrice,
                Price = product.Price,
                CategoryId = product.CategoryId,
                ThumbnailImage = productImage.ImagePath,
            };
            return productViewModel;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request)
        {
            //1. Select join
            var query = from p in _context.Products
                        join c in _context.Categories on p.CategoryId equals c.Id
                        select new { p };
            //2. filter
            if (request.CategoryId.HasValue && request.CategoryId.Value > 0)
            {
                query = query.Where(x => x.p.CategoryId == request.CategoryId);
            }
            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
                    CreatedDate = x.p.CreatedDate,
                    Description = x.p.Description,
                    Configuration = x.p.Configuration,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                }).ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<List<ProductViewModel>> GetFeaturedProducts(int take)
        {
            //1. Select join
            var query = from p in _context.Products
                        join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi
                        from pi in ppi.DefaultIfEmpty()
                        join c in _context.Categories on p.CategoryId equals c.Id into picc
                        from c in picc.DefaultIfEmpty()
                        where p.IsFeatured == true
                        select new { p, pi };

            var data = await query.OrderByDescending(x => x.p.CreatedDate).Take(take)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
                    CreatedDate = x.p.CreatedDate,
                    Description = x.p.Description,
                    Configuration = x.p.Configuration,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    ThumbnailImage = x.pi.ImagePath
                }).ToListAsync();

            return data;
        }

        public async Task<ProductImageViewModel> GetImageById(int imageId)
        {
            var image = await _context.ProductImages.FindAsync(imageId);
            if (image == null)
            {
                throw new Exception($"Cannot find an image with id = {imageId}");
            }
            var viewModel = new ProductImageViewModel()
            {
                Id = image.Id,
                Caption = image.Caption,
                CreatedDate = image.CreatedDate,
                ImagePath = image.ImagePath,
                IsDefault = image.IsDefault,
                ProductId = image.ProductId,
            };
            return viewModel;
        }

        public async Task<List<ProductImageViewModel>> GetListImages(int productId)
        {
            return await _context.ProductImages.Where(x => x.ProductId == productId)
                .Select(i => new ProductImageViewModel()
                {
                    Id = i.Id,
                    Caption = i.Caption,
                    CreatedDate = i.CreatedDate,
                    ImagePath = i.ImagePath,
                    IsDefault = i.IsDefault,
                    ProductId = i.ProductId,
                }).ToListAsync();
        }

        public async Task<int> RemoveImage(int imageId)
        {
            var productImage = await _context.ProductImages.FindAsync(imageId);
            if (productImage == null)
            {
                throw new Exception($"Cannot find an image with id = {imageId}");
            }
            _context.ProductImages.Remove(productImage);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if (product == null)
            {
                throw new Exception($"Cannot find a product with Id: {request.Id}");
            }

            product.Name = request.Name;
            product.Description = request.Description;
            product.Configuration = request.Configuration;

            // Save image
            if (request.ThumbnailImage != null)
            {
                var thumbnailImage = await _context.ProductImages.FirstOrDefaultAsync(i => i.IsDefault == true && i.ProductId == request.Id);
                if (thumbnailImage != null)
                {
                    thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                    _context.ProductImages.Update(thumbnailImage);
                }
            }

            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request)
        {

            var productImage = await _context.ProductImages.FindAsync(imageId);
            if (productImage == null)
            {
                throw new Exception($"Cannot find an image with id = {imageId}");
            }

            // Save image
            if (request.ImageFile != null)
            {
                productImage.ImagePath = await this.SaveFile(request.ImageFile);

            }
            _context.ProductImages.Update(productImage);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                throw new Exception($"Cannot find a product with Id: {productId}");
            }

            product.Price = newPrice;

            return await _context.SaveChangesAsync() > 0;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }

        public async Task<List<ProductViewModel>> GetProductsLower15(int take)
        {
            //1. Select join
            var query = from p in _context.Products
                        join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi
                        from pi in ppi.DefaultIfEmpty()
                        join c in _context.Categories on p.CategoryId equals c.Id into picc
                        from c in picc.DefaultIfEmpty()
                        where p.IsFeatured == true && p.Price < (decimal)15000000
                        select new { p, pi };

            var data = await query.OrderByDescending(x => x.p.CreatedDate).Take(take)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
                    CreatedDate = x.p.CreatedDate,
                    Description = x.p.Description,
                    Configuration = x.p.Configuration,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    ThumbnailImage = x.pi.ImagePath
                }).ToListAsync();

            return data;
        }

        public async Task<List<ProductViewModel>> GetProducts15To20(int take)
        {
            //1. Select join
            var query = from p in _context.Products
                        join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi
                        from pi in ppi.DefaultIfEmpty()
                        join c in _context.Categories on p.CategoryId equals c.Id into picc
                        from c in picc.DefaultIfEmpty()
                        where p.IsFeatured == true && p.Price >= (decimal)15000000 && p.Price <= (decimal)20000000
                        select new { p, pi };

            var data = await query.OrderByDescending(x => x.p.CreatedDate).Take(take)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
                    CreatedDate = x.p.CreatedDate,
                    Description = x.p.Description,
                    Configuration = x.p.Configuration,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    ThumbnailImage = x.pi.ImagePath
                }).ToListAsync();

            return data;
        }

        public async Task<List<ProductViewModel>> GetProductsHigher20(int take)
        {
            //1. Select join
            var query = from p in _context.Products
                        join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi
                        from pi in ppi.DefaultIfEmpty()
                        join c in _context.Categories on p.CategoryId equals c.Id into picc
                        from c in picc.DefaultIfEmpty()
                        where p.IsFeatured == true && p.Price > (decimal)20000000
                        select new { p, pi };

            var data = await query.OrderByDescending(x => x.p.CreatedDate).Take(take)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.p.Name,
                    CreatedDate = x.p.CreatedDate,
                    Description = x.p.Description,
                    Configuration = x.p.Configuration,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    ThumbnailImage = x.pi.ImagePath
                }).ToListAsync();

            return data;
        }

        public async Task<int> AddRating(int productId, Guid userId, ProductRatingCreateRequest request)
        {
            var productRating = new ProductRating()
            {
                ProductId = productId,
                UserId = userId,
                Comment = request.Comment,
                Rating = request.Rating,
                PublishedDate = DateTime.Now
            };
            
            _context.ProductRatings.Add(productRating);
            await _context.SaveChangesAsync();
            return productRating.Id;
        }

        public async Task<List<ProductRatingViewModel>> GetRatingByProductId(int productId)
        {
            //var productRating = _context.ProductRatings.Where(x => x.ProductId == productId);

            var query = from pr in _context.ProductRatings
                        join u in _context.AppUsers on pr.UserId equals u.Id
                        where pr.ProductId == productId
                        select new { pr, u };

            var productRatingViewModel = await query.Select(x => new ProductRatingViewModel()
            {
                Id = x.pr.Id,
                UserId = x.pr.UserId,
                ProductId = x.pr.ProductId,
                Comment = x.pr.Comment,
                Rating = x.pr.Rating,
                PublishedDate = x.pr.PublishedDate,
                UserName = x.u.UserName,
                
            }).ToListAsync();
            return productRatingViewModel;
        }
    }


}
