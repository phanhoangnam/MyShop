using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.ViewModels.ProductRatings
{
    public class ProductRatingCreateRequest
    {
        public int ProductId { get; set; }
        //public Guid UserId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}
