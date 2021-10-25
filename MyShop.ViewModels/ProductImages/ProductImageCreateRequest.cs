using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.ViewModels.ProductImages
{
    public class ProductImageCreateRequest
    {
        public string Caption { get; set; }
        public bool IsDefault { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
