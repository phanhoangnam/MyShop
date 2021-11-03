using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.ViewModels.ProductRatings
{
    public class ProductRatingViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Guid UserId { get; set; }
        public string Comment { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Rating { get; set; }
        public string UserName { get; set; }
        
    }
}
