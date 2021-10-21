﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyShop.Data.EF;

namespace MyShop.Data.Migrations
{
    [DbContext(typeof(MyShopDBContext))]
    partial class MyShopDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("bad6dda3-7416-4b04-9fa7-d003c251fba0"),
                            RoleId = new Guid("c99df4d6-ac53-43be-89f8-ff5ee9e54c53")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyShop.Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c99df4d6-ac53-43be-89f8-ff5ee9e54c53"),
                            ConcurrencyStamp = "d83682d4-63e1-4d34-9582-535f1e902926",
                            Description = "Administrator Role",
                            Name = "admin",
                            NormalizedName = "admin"
                        });
                });

            modelBuilder.Entity("MyShop.Data.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bad6dda3-7416-4b04-9fa7-d003c251fba0"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b0bc139b-e918-4d2f-b2e4-e0eaa398a247",
                            Dob = new DateTime(1999, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "phan99hoangnam@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Nam",
                            LastName = "Phan",
                            LockoutEnabled = false,
                            NormalizedEmail = "phan99hoangnam@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAED70gRBiCnit2247rDJg/gBe1QX9hxR/x2W6iVgRAFiy/QVbJmSa6dokBSHPIwZmSg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("MyShop.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsShowOnHome")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "HP",
                            IsShowOnHome = true,
                            Name = "HP",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dell",
                            IsShowOnHome = true,
                            Name = "Dell",
                            Status = 1
                        });
                });

            modelBuilder.Entity("MyShop.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Configuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Configuration = "<p><strong>Màn hình:</strong> 15.6 inch, Full HD (1920 x 1080)</p><p><strong>CPU:</strong> Intel Core i5 Ice Lake, 1.00 GHz</p><p><strong>RAM:</strong> 4 GB, SSD 256GB NVMe PCIe, <br/>Hỗ trợ khe cắm HDD SATA</p><p><strong>Đồ họa:</strong> Intel UHD Graphics</p><p><strong>HĐH:</strong> Windows 10 Home SL</p><p><strong>Nặng:</strong> 1.695 kg</p><p><strong> Pin:</strong> Li-Ion 3 cell</p>",
                            CreatedDate = new DateTime(2021, 10, 21, 21, 14, 14, 698, DateTimeKind.Local).AddTicks(7581),
                            Description = "Laptop HP Pavilion 15 cs3014TU i5 (8QP20PA) là chiếc máy tính xách tay học tập văn phòng có cấu hình khá, vận hành nhanh, thiết kế gọn nhẹ phù hợp với nhu cầu của người dùng trẻ cần di chuyển nhiều.",
                            Name = "Laptop HP Pavilion 15 cs3014TU i5 1035G1/4GB/256GB/Win10 (8QP20PA)",
                            OriginalPrice = 10000000m,
                            Price = 15590000m,
                            UpdatedDate = new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(5365)
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Configuration = "<p><strong>Màn hình:</strong> 13.3 inch, HD (1366 x 768)</p><p><strong>CPU:</strong> Intel Core i5 Coffee Lake, 1.60 GHz</p><p><strong>RAM:</strong> 4 GB, HDD: 1 TB SATA3,<br/>Hỗ trợ khe cắm SSD M.2 SATA3</p><p><strong>Đồ họa:,/strong> Intel® UHD Graphics 620</p><p><strong>HĐH:</strong> Windows 10 Home SL</p><p><strong>Nặng:</strong> 1.52 kg</p><p><strong> Pin:</strong> Li-Ion 3 cell</p>",
                            CreatedDate = new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8090),
                            Description = "Laptop HP Probook 430 G6 (5YM98PA) là chiếc laptop mỏng nhẹ phù hợp với dân văn phòng và sinh viên. Với Chip Core i5, RAM 4 GB, chiếc laptop HP Probook 430 có sức mạnh đủ để chạy tốt các ứng dụng văn phòng và giải trí thường ngày.",
                            Name = "Laptop HP Probook 13 i5 8265U/4GB/1TB/Win10 (5YM98PA)",
                            OriginalPrice = 9000000m,
                            Price = 15590000m,
                            UpdatedDate = new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8100)
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Configuration = "<p><strong>Màn hình: </strong>15.6 inch, Full HD (1920 x 1080)</p><p><strong>CPU: </strong>Intel Core i3 Kabylake, 2.30 GHz</p><p><strong>RAM:</strong> 4 GB, HDD: 1 TB SATA3<br/>Hỗ trợ khe cắm SSD M.2 PCIe</p><p><strong>Đồ họa:</strong> Intel® UHD Graphics 620</p><p><strong>HĐH:</strong> Windows 10 Home SL</p><p><strong>Nặng:</strong> 2.28 kg</p><p><strong>Pin:</strong> Li-Ion 3 cell</p>",
                            CreatedDate = new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8106),
                            Description = "Laptop Dell Inspiron 3581 có thiết kế đơn giản, độ bền cao, là chiếc laptop 15.6 inch giá rẻ phù hợp với sinh viên.",
                            Name = "Laptop Dell Inspiron 3581 i3 7020U/4GB/1TB/Win10 (P75F005N81A)",
                            OriginalPrice = 8000000m,
                            Price = 10290000m,
                            UpdatedDate = new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8108)
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Configuration = "<p><strong>Màn hình: </strong>15.6 inch, Full HD (1920 x 1080)</p><p><strong>CPU: </strong>Intel Core i7 Comet Lake, 1.80 GHz</p><p><strong>RAM: </strong>8 GB, SSD 256GB NVMe PCIe<br/>Hỗ trợ khe cắm HDD SATA</p><p><strong>Đồ họa: </strong>AMD Radeon 610R5, 2GB</p><p><strong>HĐH: </strong>Windows 10 Home SL</p><p><strong>Nặng:</strong> 1.99</p><p><strong>Pin: </strong>Li-Ion 3 cell</p>",
                            CreatedDate = new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8111),
                            Description = "Laptop Dell Vostro 3590 i7 (GRMGK2) là phiên bản laptop đồ họa kĩ thuật có thiết kế hiện đại, cấu hình khỏe với vi xử lí gen 10 và card đồ họa rời. Đây chính là chiếc laptop đáng cân nhắc đối với dân đồ họa hay sinh viên khối ngành kĩ thuật.",
                            Name = "Laptop Dell Vostro 3590 i7 10510U/8GB/256GB/2GB 610R5/Win10 (GRMGK2)",
                            OriginalPrice = 15000000m,
                            Price = 25000000m,
                            UpdatedDate = new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8113)
                        });
                });

            modelBuilder.Entity("MyShop.Data.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("MyShop.Data.Entities.ProductRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("AppUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductRatings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("MyShop.Data.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("MyShop.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("MyShop.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("MyShop.Data.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyShop.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("MyShop.Data.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyShop.Data.Entities.Product", b =>
                {
                    b.HasOne("MyShop.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MyShop.Data.Entities.ProductImage", b =>
                {
                    b.HasOne("MyShop.Data.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MyShop.Data.Entities.ProductRating", b =>
                {
                    b.HasOne("MyShop.Data.Entities.AppUser", "AppUser")
                        .WithMany("ProductRatings")
                        .HasForeignKey("AppUserId");

                    b.HasOne("MyShop.Data.Entities.Product", "Product")
                        .WithMany("ProductRatings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MyShop.Data.Entities.AppUser", b =>
                {
                    b.Navigation("ProductRatings");
                });

            modelBuilder.Entity("MyShop.Data.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MyShop.Data.Entities.Product", b =>
                {
                    b.Navigation("ProductImages");

                    b.Navigation("ProductRatings");
                });
#pragma warning restore 612, 618
        }
    }
}
