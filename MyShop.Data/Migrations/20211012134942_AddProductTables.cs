using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShop.Data.Migrations
{
    public partial class AddProductTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productRatings_Products_ProductId",
                table: "productRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productRatings",
                table: "productRatings");

            migrationBuilder.RenameTable(
                name: "productRatings",
                newName: "ProductRatings");

            migrationBuilder.RenameIndex(
                name: "IX_productRatings_ProductId",
                table: "ProductRatings",
                newName: "IX_ProductRatings_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductRatings",
                table: "ProductRatings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRatings_Products_ProductId",
                table: "ProductRatings",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductRatings_Products_ProductId",
                table: "ProductRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductRatings",
                table: "ProductRatings");

            migrationBuilder.RenameTable(
                name: "ProductRatings",
                newName: "productRatings");

            migrationBuilder.RenameIndex(
                name: "IX_ProductRatings_ProductId",
                table: "productRatings",
                newName: "IX_productRatings_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productRatings",
                table: "productRatings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productRatings_Products_ProductId",
                table: "productRatings",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
