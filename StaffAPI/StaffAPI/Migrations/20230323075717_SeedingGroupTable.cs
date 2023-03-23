using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StaffAPI.Migrations
{
    public partial class SeedingGroupTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "GroupName" },
                values: new object[] { 3, "Beauty" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "GroupName" },
                values: new object[] { 4, "Automotive" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "GroupName" },
                values: new object[] { 5, "Garden" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
