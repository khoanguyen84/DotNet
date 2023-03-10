using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopingCart.Migrations
{
    public partial class SeedingProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 15000000, "iPhone 13 Pro Max" },
                    { 2, 25000000, "iPhone 14 Pro Max" },
                    { 3, 7000000, "iPhone X" },
                    { 4, 12000000, "iPhone 11 Pro Max" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
