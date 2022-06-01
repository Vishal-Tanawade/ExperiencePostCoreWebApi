using Microsoft.EntityFrameworkCore.Migrations;

namespace ExperiencePostCoreWebApi.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmpID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CellNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmpID);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpID = table.Column<int>(type: "int", nullable: false),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceInYears = table.Column<int>(type: "int", nullable: false),
                    EmployeeEmpID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skills_Employees_EmployeeEmpID",
                        column: x => x.EmployeeEmpID,
                        principalTable: "Employees",
                        principalColumn: "EmpID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmpID", "CellNumber", "Email", "FirstName", "LastName", "Password", "ProfilePicture" },
                values: new object[,]
                {
                    { 1, "(660) 663-4518", "aron.hawkins@aol.com", "Aaron", "Hawkins", "arron@123", "no-image" },
                    { 2, "(608) 265-2215", "hedy.greene@aol.com", "Hedy", "Greene", "hedy@123", "no-image" },
                    { 3, "(959) 119-8364", "melvin.porter@aol.com", "Melvin", "Porter", "melvin@123", "no-image" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "EmpID", "EmployeeEmpID", "ExperienceInYears", "Role", "SkillName" },
                values: new object[,]
                {
                    { 1, 1, null, 2, "Business Analyst", "Microsoft Office Suite" },
                    { 2, 1, null, 3, "Developer", "Testing" },
                    { 3, 1, null, 4, "Project Lead", "Stakeholder Management" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_EmployeeEmpID",
                table: "Skills",
                column: "EmployeeEmpID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
