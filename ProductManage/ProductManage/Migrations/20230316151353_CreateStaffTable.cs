using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManage.Migrations
{
    public partial class CreateStaffTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "DateOfBirth", "Email", "Fullname" },
                values: new object[] { 1, new DateTime(2023, 3, 16, 22, 13, 53, 323, DateTimeKind.Local).AddTicks(8780), "khoa.nguyen@codegym.vn", "Khoa Nguyễn" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "DateOfBirth", "Email", "Fullname" },
                values: new object[] { 2, new DateTime(2023, 3, 16, 22, 13, 53, 323, DateTimeKind.Local).AddTicks(8792), "quang.dang@codegym.vn", "Quang Đặng" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
