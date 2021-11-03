using MyShop.ViewModels.Common;
using MyShop.ViewModels.ProductImages;
using MyShop.ViewModels.ProductRatings;
using MyShop.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Application.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<ProductViewModel> GetById(int productId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<ProductImageViewModel> GetImageById(int imageId);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetFeaturedProducts(int take);
        Task<List<ProductViewModel>> GetProductsLower15(int take);
        Task<List<ProductViewModel>> GetProducts15To20(int take);
        Task<List<ProductViewModel>> GetProductsHigher20(int take);

        Task<int> AddRating(int productId, Guid userId, ProductRatingCreateRequest request);
        Task<List<ProductRatingViewModel>> GetRatingByProductId(int productId);

    }
}
