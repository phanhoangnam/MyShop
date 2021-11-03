﻿using MyShop.ViewModels.Categories;
using MyShop.ViewModels.Common;
using MyShop.ViewModels.ProductRatings;
using MyShop.ViewModels.Products;
using MyShop.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApp.Services
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductViewModel>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<ProductViewModel> GetById(int id);

        Task<List<ProductViewModel>> GetFeaturedProducts(int take);
        Task<List<ProductViewModel>> GetProductsLower15(int take);
        Task<List<ProductViewModel>> GetProducts15To20(int take);
        Task<List<ProductViewModel>> GetProductsHigher20(int take);

        Task<bool> AddRating(int productId, Guid userId, ProductRatingCreateRequest request);
        Task<List<ProductRatingViewModel>> GetRatingByProductId(int productId);
    }
}
