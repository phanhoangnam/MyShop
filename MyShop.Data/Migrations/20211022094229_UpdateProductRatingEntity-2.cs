using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShop.Data.Migrations
{
    public partial class UpdateProductRatingEntity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductRatings_AspNetUsers_AppUserId",
                table: "ProductRatings");

            migrationBuilder.DropIndex(
                name: "IX_ProductRatings_AppUserId",
                table: "ProductRatings");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "ProductRatings");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c99df4d6-ac53-43be-89f8-ff5ee9e54c53"),
                column: "ConcurrencyStamp",
                value: "c6b2764c-db75-4697-8d33-e6fe1d1d71f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bad6dda3-7416-4b04-9fa7-d003c251fba0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b71de1f8-07e5-46c3-8e2a-5f767eb6a459", "AQAAAAEAACcQAAAAEM8eiKdnV4vAk2hjnzIRCkJfjz/zXwL3FMkeV0syfjzmRno/7eR7JMHSJX2117G0iA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 42, 27, 942, DateTimeKind.Local).AddTicks(5710), new DateTime(2021, 10, 22, 16, 42, 27, 947, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 42, 27, 947, DateTimeKind.Local).AddTicks(8742), new DateTime(2021, 10, 22, 16, 42, 27, 947, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 42, 27, 947, DateTimeKind.Local).AddTicks(8755), new DateTime(2021, 10, 22, 16, 42, 27, 947, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 22, 16, 42, 27, 947, DateTimeKind.Local).AddTicks(8761), new DateTime(2021, 10, 22, 16, 42, 27, 947, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductRatings_UserId",
                table: "ProductRatings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRatings_AspNetUsers_UserId",
                table: "ProductRatings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductRatings_AspNetUsers_UserId",
                table: "ProductRatings");

            migrationBuilder.DropIndex(
                name: "IX_ProductRatings_UserId",
                table: "ProductRatings");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "ProductRatings",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductRatings_AppUserId",
                table: "ProductRatings",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRatings_AspNetUsers_AppUserId",
                table: "ProductRatings",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
