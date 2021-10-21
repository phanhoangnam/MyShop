using MyShop.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "HP",
                    Description = "HP",
                    IsShowOnHome = true,
                    Status = Enums.Status.Active
                },
                new Category()
                {
                    Id = 2,
                    Name = "Dell",
                    Description = "Dell",
                    IsShowOnHome = true,
                    Status = Enums.Status.Active
                });

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Laptop HP Pavilion 15 cs3014TU i5 1035G1/4GB/256GB/Win10 (8QP20PA)",
                    Description = "Laptop HP Pavilion 15 cs3014TU i5 (8QP20PA) là chiếc máy tính xách tay " +
                                  "học tập văn phòng có cấu hình khá, vận hành nhanh, thiết kế gọn nhẹ phù hợp với nhu cầu " +
                                  "của người dùng trẻ cần di chuyển nhiều.",
                    Configuration = "<p><strong>Màn hình:</strong> 15.6 inch, Full HD (1920 x 1080)</p>" +
                                    "<p><strong>CPU:</strong> Intel Core i5 Ice Lake, 1.00 GHz</p>" +
                                    "<p><strong>RAM:</strong> 4 GB, SSD 256GB NVMe PCIe, <br/>Hỗ trợ khe cắm HDD SATA</p>" +
                                    "<p><strong>Đồ họa:</strong> Intel UHD Graphics</p>" +
                                    "<p><strong>HĐH:</strong> Windows 10 Home SL</p>" +
                                    "<p><strong>Nặng:</strong> 1.695 kg</p>" +
                                    "<p><strong> Pin:</strong> Li-Ion 3 cell</p>",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    OriginalPrice = 10000000,
                    Price = 15590000,
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Laptop HP Probook 13 i5 8265U/4GB/1TB/Win10 (5YM98PA)",
                    Description = "Laptop HP Probook 430 G6 (5YM98PA) là chiếc laptop mỏng nhẹ phù hợp với dân văn phòng " +
                                  "và sinh viên. Với Chip Core i5, RAM 4 GB, chiếc laptop HP Probook 430 có sức mạnh đủ để chạy tốt " +
                                  "các ứng dụng văn phòng và giải trí thường ngày.",
                    Configuration = "<p><strong>Màn hình:</strong> 13.3 inch, HD (1366 x 768)</p>" +
                                    "<p><strong>CPU:</strong> Intel Core i5 Coffee Lake, 1.60 GHz</p>" +
                                    "<p><strong>RAM:</strong> 4 GB, HDD: 1 TB SATA3,<br/>Hỗ trợ khe cắm SSD M.2 SATA3</p>" +
                                    "<p><strong>Đồ họa:,/strong> Intel® UHD Graphics 620</p>" +
                                    "<p><strong>HĐH:</strong> Windows 10 Home SL</p>" +
                                    "<p><strong>Nặng:</strong> 1.52 kg</p>" +
                                    "<p><strong> Pin:</strong> Li-Ion 3 cell</p>",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    OriginalPrice = 9000000,
                    Price = 15590000,
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Laptop Dell Inspiron 3581 i3 7020U/4GB/1TB/Win10 (P75F005N81A)",
                    Description = "Laptop Dell Inspiron 3581 có thiết kế đơn giản, độ bền cao, " +
                                  "là chiếc laptop 15.6 inch giá rẻ phù hợp với sinh viên.",
                    Configuration = "<p><strong>Màn hình: </strong>15.6 inch, Full HD (1920 x 1080)</p>" +
                                    "<p><strong>CPU: </strong>Intel Core i3 Kabylake, 2.30 GHz</p>" +
                                    "<p><strong>RAM:</strong> 4 GB, HDD: 1 TB SATA3<br/>Hỗ trợ khe cắm SSD M.2 PCIe</p>" +
                                    "<p><strong>Đồ họa:</strong> Intel® UHD Graphics 620</p>" +
                                    "<p><strong>HĐH:</strong> Windows 10 Home SL</p>" +
                                    "<p><strong>Nặng:</strong> 2.28 kg</p>" +
                                    "<p><strong>Pin:</strong> Li-Ion 3 cell</p>",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    OriginalPrice = 8000000,
                    Price = 10290000,
                    CategoryId = 2
                },
                new Product()
                {
                    Id = 4,
                    Name = "Laptop Dell Vostro 3590 i7 10510U/8GB/256GB/2GB 610R5/Win10 (GRMGK2)",
                    Description = "Laptop Dell Vostro 3590 i7 (GRMGK2) là phiên bản laptop đồ họa kĩ thuật " +
                                  "có thiết kế hiện đại, cấu hình khỏe với vi xử lí gen 10 và card đồ họa rời. " +
                                  "Đây chính là chiếc laptop đáng cân nhắc đối với dân đồ họa hay sinh viên khối ngành kĩ thuật.",
                    Configuration = "<p><strong>Màn hình: </strong>15.6 inch, Full HD (1920 x 1080)</p>" +
                                    "<p><strong>CPU: </strong>Intel Core i7 Comet Lake, 1.80 GHz</p>" +
                                    "<p><strong>RAM: </strong>8 GB, SSD 256GB NVMe PCIe<br/>Hỗ trợ khe cắm HDD SATA</p>" +
                                    "<p><strong>Đồ họa: </strong>AMD Radeon 610R5, 2GB</p>" +
                                    "<p><strong>HĐH: </strong>Windows 10 Home SL</p>" +
                                    "<p><strong>Nặng:</strong> 1.99</p>" +
                                    "<p><strong>Pin: </strong>Li-Ion 3 cell</p>",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    OriginalPrice = 15000000,
                    Price = 25000000,
                    CategoryId = 2
                });

            // any guid
            var roleId = new Guid("C99DF4D6-AC53-43BE-89F8-FF5EE9E54C53");
            var adminId = new Guid("BAD6DDA3-7416-4B04-9FA7-D003C251FBA0");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator Role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "phan99hoangnam@gmail.com",
                NormalizedEmail = "phan99hoangnam@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456@Aa"),
                SecurityStamp = string.Empty,
                FirstName = "Nam",
                LastName = "Phan",
                Dob = new DateTime(1999, 11, 18)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }



    }
}
