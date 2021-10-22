using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShop.Data.Migrations
{
    public partial class UpdateProductRatingEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductRatings_AspNetUsers_AppUserId",
                table: "ProductRatings");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserId",
                table: "ProductRatings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "ProductRatings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c99df4d6-ac53-43be-89f8-ff5ee9e54c53"),
                column: "ConcurrencyStamp",
                value: "ebb10e67-957e-4113-aa20-8a5d03cac75f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bad6dda3-7416-4b04-9fa7-d003c251fba0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "288074ba-231d-4e76-b120-087f0d714ff1", "AQAAAAEAACcQAAAAEPM9Rh6ZsDl7y1HkBYgDNuKZg/CtImzF8qrv76VfXyqQ87Qz0pJNPzOEcWJXpoCxeQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 34, 27, 338, DateTimeKind.Local).AddTicks(4736), new DateTime(2021, 10, 22, 16, 34, 27, 340, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 34, 27, 341, DateTimeKind.Local).AddTicks(1893), new DateTime(2021, 10, 22, 16, 34, 27, 341, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 34, 27, 341, DateTimeKind.Local).AddTicks(1906), new DateTime(2021, 10, 22, 16, 34, 27, 341, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 34, 27, 341, DateTimeKind.Local).AddTicks(1910), new DateTime(2021, 10, 22, 16, 34, 27, 341, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRatings_AspNetUsers_AppUserId",
                table: "ProductRatings",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductRatings_AspNetUsers_AppUserId",
                table: "ProductRatings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProductRatings");

            migrationBuilder.AlterColumn<Guid>(
                name: "AppUserId",
                table: "ProductRatings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c99df4d6-ac53-43be-89f8-ff5ee9e54c53"),
                column: "ConcurrencyStamp",
                value: "55a2d020-1939-499b-985b-ef8b58c086bf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bad6dda3-7416-4b04-9fa7-d003c251fba0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4f282fe8-00c3-49ae-b73b-44cbfc4cd053", "AQAAAAEAACcQAAAAEL4OdmDBNFOHElcp3Rw/i3wV8Vd4XLLLnf8LgV/Zqq2uvZk6HwZLMDPMkJQCfNZJTA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 25, 38, 84, DateTimeKind.Local).AddTicks(6195), new DateTime(2021, 10, 22, 16, 25, 38, 87, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 25, 38, 87, DateTimeKind.Local).AddTicks(5091), new DateTime(2021, 10, 22, 16, 25, 38, 87, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 25, 38, 87, DateTimeKind.Local).AddTicks(5105), new DateTime(2021, 10, 22, 16, 25, 38, 87, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 25, 38, 87, DateTimeKind.Local).AddTicks(5110), new DateTime(2021, 10, 22, 16, 25, 38, 87, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRatings_AspNetUsers_AppUserId",
                table: "ProductRatings",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
