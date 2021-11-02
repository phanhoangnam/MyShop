using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShop.Data.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c99df4d6-ac53-43be-89f8-ff5ee9e54c53"),
                column: "ConcurrencyStamp",
                value: "07777651-f517-4137-85df-1812557e3eda");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bad6dda3-7416-4b04-9fa7-d003c251fba0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6346be9b-47e5-4a81-8358-7b418673b126", "AQAAAAEAACcQAAAAEPCy0WtN80GddiDfk9Du4Ug0TaVrSP/1EIHt476RES+gPS4FEr8Rc97Xpvij9uHwqA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 30, 22, 18, 59, 496, DateTimeKind.Local).AddTicks(3448), new DateTime(2021, 10, 30, 22, 18, 59, 497, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 30, 22, 18, 59, 498, DateTimeKind.Local).AddTicks(1230), new DateTime(2021, 10, 30, 22, 18, 59, 498, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 30, 22, 18, 59, 498, DateTimeKind.Local).AddTicks(1243), new DateTime(2021, 10, 30, 22, 18, 59, 498, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2021, 10, 30, 22, 18, 59, 498, DateTimeKind.Local).AddTicks(1248), new DateTime(2021, 10, 30, 22, 18, 59, 498, DateTimeKind.Local).AddTicks(1249) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Products");

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
        }
    }
}
