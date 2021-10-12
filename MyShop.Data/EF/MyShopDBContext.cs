using Microsoft.EntityFrameworkCore;
using MyShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.EF
{
    public class MyShopDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=MyShop;Integrated Security=True");
                //.UseLazyLoadingProxies()
                //.LogTo(Console.WriteLine, new[] {
                //    DbLoggerCategory.Model.Name,
                //    DbLoggerCategory.Database.Command.Name,
                //    DbLoggerCategory.Database.Transaction.Name,
                //    DbLoggerCategory.Query.Name,
                //    DbLoggerCategory.ChangeTracking.Name,
                //},
                //       LogLevel.Information)
                //.EnableSensitiveDataLogging();
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductRating> ProductRatings { get; set; }
    }
}
