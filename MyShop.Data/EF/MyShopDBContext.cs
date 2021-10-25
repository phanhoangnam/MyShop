using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyShop.Data.Entities;
using MyShop.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.EF
{
    public class MyShopDBContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public MyShopDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=MyShop;Integrated Security=True");
            //    .UseLazyLoadingProxies()
            //    .LogTo(Console.WriteLine, new[] {
            //        DbLoggerCategory.Model.Name,
            //        DbLoggerCategory.Database.Command.Name,
            //        DbLoggerCategory.Database.Transaction.Name,
            //        DbLoggerCategory.Query.Name,
            //        DbLoggerCategory.ChangeTracking.Name,
            //    },
            //           LogLevel.Information)
            //    .EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Data seeding
            modelBuilder.Seed();

            //modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            //modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            //modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            //modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            //modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);



        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductRating> ProductRatings { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        
    }
}
