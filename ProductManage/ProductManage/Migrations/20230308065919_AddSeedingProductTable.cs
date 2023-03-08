using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManage.Migrations
{
    public partial class AddSeedingProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "Rates" },
                values: new object[] { 3, "iPhone X, Manufactory Thailand", "iPhone X", 4000000.0, "" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price", "Rates" },
                values: new object[] { 4, "iPhone 11, Manufactory Thailand", "iPhone 11", 10000000.0, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
