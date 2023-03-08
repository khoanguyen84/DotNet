using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManage.Migrations
{
    public partial class SeedingProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "Rates" },
                values: new object[] { 1, "iPhone 13 Pro Max, Manufactory Thailand", "iPhone 13 Pro Max", 20000000.0, "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "Rates" },
                values: new object[] { 2, "iPhone 14 Pro Max, Manufactory Thailand", "iPhone 14 Pro Max", 30000000.0, "" });
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
        }
    }
}
