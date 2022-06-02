using Microsoft.EntityFrameworkCore.Migrations;

namespace ExperiencePostCoreWebApi.Migrations
{
    public partial class EmployeeTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 1,
                column: "ProfilePicture",
                value: "noImage.png");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 2,
                column: "ProfilePicture",
                value: "noImage.png");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 3,
                column: "ProfilePicture",
                value: "noImage.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 1,
                column: "ProfilePicture",
                value: "no-image");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 2,
                column: "ProfilePicture",
                value: "no-image");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmpID",
                keyValue: 3,
                column: "ProfilePicture",
                value: "no-image");
        }
    }
}
