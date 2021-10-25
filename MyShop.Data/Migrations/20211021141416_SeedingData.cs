using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShop.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDefault",
                table: "ProductImages",
                newName: "IsDefault");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "ProductImages",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<string>(
                name: "Configuration",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("c99df4d6-ac53-43be-89f8-ff5ee9e54c53"), "d83682d4-63e1-4d34-9582-535f1e902926", "Administrator Role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("bad6dda3-7416-4b04-9fa7-d003c251fba0"), 0, "b0bc139b-e918-4d2f-b2e4-e0eaa398a247", new DateTime(1999, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "phan99hoangnam@gmail.com", true, "Nam", "Phan", false, null, "phan99hoangnam@gmail.com", "admin", "AQAAAAEAACcQAAAAED70gRBiCnit2247rDJg/gBe1QX9hxR/x2W6iVgRAFiy/QVbJmSa6dokBSHPIwZmSg==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IsShowOnHome", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "HP", true, "HP", 1 },
                    { 2, "Dell", true, "Dell", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("c99df4d6-ac53-43be-89f8-ff5ee9e54c53"), new Guid("bad6dda3-7416-4b04-9fa7-d003c251fba0") });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Configuration", "CreatedDate", "Description", "Name", "OriginalPrice", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, "<p><strong>Màn hình:</strong> 15.6 inch, Full HD (1920 x 1080)</p><p><strong>CPU:</strong> Intel Core i5 Ice Lake, 1.00 GHz</p><p><strong>RAM:</strong> 4 GB, SSD 256GB NVMe PCIe, <br/>Hỗ trợ khe cắm HDD SATA</p><p><strong>Đồ họa:</strong> Intel UHD Graphics</p><p><strong>HĐH:</strong> Windows 10 Home SL</p><p><strong>Nặng:</strong> 1.695 kg</p><p><strong> Pin:</strong> Li-Ion 3 cell</p>", new DateTime(2021, 10, 21, 21, 14, 14, 698, DateTimeKind.Local).AddTicks(7581), "Laptop HP Pavilion 15 cs3014TU i5 (8QP20PA) là chiếc máy tính xách tay học tập văn phòng có cấu hình khá, vận hành nhanh, thiết kế gọn nhẹ phù hợp với nhu cầu của người dùng trẻ cần di chuyển nhiều.", "Laptop HP Pavilion 15 cs3014TU i5 1035G1/4GB/256GB/Win10 (8QP20PA)", 10000000m, 15590000m, new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(5365) },
                    { 2, 1, "<p><strong>Màn hình:</strong> 13.3 inch, HD (1366 x 768)</p><p><strong>CPU:</strong> Intel Core i5 Coffee Lake, 1.60 GHz</p><p><strong>RAM:</strong> 4 GB, HDD: 1 TB SATA3,<br/>Hỗ trợ khe cắm SSD M.2 SATA3</p><p><strong>Đồ họa:,/strong> Intel® UHD Graphics 620</p><p><strong>HĐH:</strong> Windows 10 Home SL</p><p><strong>Nặng:</strong> 1.52 kg</p><p><strong> Pin:</strong> Li-Ion 3 cell</p>", new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8090), "Laptop HP Probook 430 G6 (5YM98PA) là chiếc laptop mỏng nhẹ phù hợp với dân văn phòng và sinh viên. Với Chip Core i5, RAM 4 GB, chiếc laptop HP Probook 430 có sức mạnh đủ để chạy tốt các ứng dụng văn phòng và giải trí thường ngày.", "Laptop HP Probook 13 i5 8265U/4GB/1TB/Win10 (5YM98PA)", 9000000m, 15590000m, new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8100) },
                    { 3, 2, "<p><strong>Màn hình: </strong>15.6 inch, Full HD (1920 x 1080)</p><p><strong>CPU: </strong>Intel Core i3 Kabylake, 2.30 GHz</p><p><strong>RAM:</strong> 4 GB, HDD: 1 TB SATA3<br/>Hỗ trợ khe cắm SSD M.2 PCIe</p><p><strong>Đồ họa:</strong> Intel® UHD Graphics 620</p><p><strong>HĐH:</strong> Windows 10 Home SL</p><p><strong>Nặng:</strong> 2.28 kg</p><p><strong>Pin:</strong> Li-Ion 3 cell</p>", new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8106), "Laptop Dell Inspiron 3581 có thiết kế đơn giản, độ bền cao, là chiếc laptop 15.6 inch giá rẻ phù hợp với sinh viên.", "Laptop Dell Inspiron 3581 i3 7020U/4GB/1TB/Win10 (P75F005N81A)", 8000000m, 10290000m, new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8108) },
                    { 4, 2, "<p><strong>Màn hình: </strong>15.6 inch, Full HD (1920 x 1080)</p><p><strong>CPU: </strong>Intel Core i7 Comet Lake, 1.80 GHz</p><p><strong>RAM: </strong>8 GB, SSD 256GB NVMe PCIe<br/>Hỗ trợ khe cắm HDD SATA</p><p><strong>Đồ họa: </strong>AMD Radeon 610R5, 2GB</p><p><strong>HĐH: </strong>Windows 10 Home SL</p><p><strong>Nặng:</strong> 1.99</p><p><strong>Pin: </strong>Li-Ion 3 cell</p>", new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8111), "Laptop Dell Vostro 3590 i7 (GRMGK2) là phiên bản laptop đồ họa kĩ thuật có thiết kế hiện đại, cấu hình khỏe với vi xử lí gen 10 và card đồ họa rời. Đây chính là chiếc laptop đáng cân nhắc đối với dân đồ họa hay sinh viên khối ngành kĩ thuật.", "Laptop Dell Vostro 3590 i7 10510U/8GB/256GB/2GB 610R5/Win10 (GRMGK2)", 15000000m, 25000000m, new DateTime(2021, 10, 21, 21, 14, 14, 700, DateTimeKind.Local).AddTicks(8113) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c99df4d6-ac53-43be-89f8-ff5ee9e54c53"), new Guid("bad6dda3-7416-4b04-9fa7-d003c251fba0") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c99df4d6-ac53-43be-89f8-ff5ee9e54c53"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bad6dda3-7416-4b04-9fa7-d003c251fba0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Configuration",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "IsDefault",
                table: "ProductImages",
                newName: "isDefault");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "ProductImages",
                newName: "DateCreated");
        }
    }
}
