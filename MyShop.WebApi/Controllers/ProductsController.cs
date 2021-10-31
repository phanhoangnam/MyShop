using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.Application.Products;
using MyShop.ViewModels.ProductImages;
using MyShop.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;

        public ProductsController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        // http://localhost:port/products?pageIndex=1&pageSize=10&CategoryId=
        [HttpGet]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetPublicProductPagingRequest request)
        {
            var products = await _publicProductService.GetAllByCategoryId(request);
            return Ok(products);
        }


        // http://localhost:port/product/productId
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById(int productId)
        {
            var product = await _manageProductService.GetById(productId);
            if (product == null)
            {
                return NotFound("Cannot find product");
            }
            return Ok(product);
        }

        [HttpGet("featured/{take}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetFeaturedProducts(int take)
        {
            var products = await _manageProductService.GetFeaturedProducts(take);
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _manageProductService.Create(request);
            if (productId == 0)
            {
                return BadRequest();
            }
            var product = await _manageProductService.GetById(productId);
            return CreatedAtAction(nameof(GetById), new { id = productId }, product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedRequest = await _manageProductService.Update(request);
            if (affectedRequest == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedRequest = await _manageProductService.Delete(productId);
            if (affectedRequest == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var isSuccessful = await _manageProductService.UpdatePrice(productId, newPrice);
            if (isSuccessful)
            {
                return Ok();
            }
            return BadRequest();
        }


        // Image
        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage(int productId, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _manageProductService.AddImage(productId, request);
            if (imageId == 0)
            {
                return BadRequest();
            }
            var image = await _manageProductService.GetImageById(imageId);
            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _manageProductService.UpdateImage(imageId, request);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _manageProductService.RemoveImage(imageId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }


        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _manageProductService.GetImageById(imageId);
            if (image == null)
            {
                return NotFound("Cannot find product");
            }
            return Ok(image);
        }
    }
}
