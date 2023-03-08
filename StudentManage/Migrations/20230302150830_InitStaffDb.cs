using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManage.Migrations
{
    public partial class InitStaffDb : Migration
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
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "DateOfBirth", "Fullname" },
                values: new object[] { 1, new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khoa Nguyễn" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffId", "DateOfBirth", "Fullname" },
                values: new object[] { 2, new DateTime(2000, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quang Đặng" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
