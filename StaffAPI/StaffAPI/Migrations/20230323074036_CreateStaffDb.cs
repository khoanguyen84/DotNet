using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StaffAPI.Migrations
{
    public partial class CreateStaffDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "GroupName" },
                values: new object[] { 1, "Industrial" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "GroupName" },
                values: new object[] { 2, "Games" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Avatar", "Company", "Email", "GroupId", "Mobile", "Name", "Title" },
                values: new object[] { 1, "http://res.cloudinary.com/dtxyz2s1g/image/upload/v1665451443/papvmvvxex07khf2ntmk.jpg", "Walker Morrow LLC", "raduhopir@mailinator.com", 1, "+1 (527) 129-3735", "Arden Grant", "Tempora adipisci sin" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Avatar", "Company", "Email", "GroupId", "Mobile", "Name", "Title" },
                values: new object[] { 2, "http://res.cloudinary.com/dtxyz2s1g/image/upload/v1664334766/mdmzrzvbnw56tx24jyj2.jpg", "Kunde and Sons", "Carol_Hegmann@gmail.com", 2, "651-903-2931", "Kling", "Dynamic Integration Assistant" });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_GroupId",
                table: "Staffs",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
