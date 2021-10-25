using MyShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.ViewModels.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
