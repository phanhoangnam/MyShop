using MyShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.ViewModels.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
