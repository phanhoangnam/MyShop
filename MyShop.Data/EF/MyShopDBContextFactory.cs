using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.EF
{
    public class MyShopDBContextFactory : IDesignTimeDbContextFactory<MyShopDBContext>
    {
        public MyShopDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("MyShopDb");
            var optionsBuilder = new DbContextOptionsBuilder<MyShopDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MyShopDBContext(optionsBuilder.Options);
        }
    }
}
