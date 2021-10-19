﻿using MyShop.ViewModels.Products;
using MyShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        //Task<List<ProductViewModel>> GetAll(string languageId); 
    }
}
