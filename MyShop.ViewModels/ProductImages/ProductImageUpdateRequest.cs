using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.ViewModels.ProductImages
{
    public class ProductImageUpdateRequest
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public bool isDefault { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
