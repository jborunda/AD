using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AD.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Employee_Number = table.Column<string>(maxLength: 10, nullable: false),
                    First_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Middle_Name = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Department = table.Column<string>(maxLength: 50, nullable: true),
                    Department_Code = table.Column<string>(maxLength: 50, nullable: true),
                    Bureau = table.Column<string>(maxLength: 50, nullable: true),
                    Unit = table.Column<string>(maxLength: 50, nullable: true),
                    Work_address = table.Column<string>(maxLength: 50, nullable: true),
                    Work_Phone = table.Column<string>(maxLength: 10, nullable: true),
                    Admin_Flag = table.Column<bool>(nullable: false),
                    Work_City = table.Column<string>(maxLength: 100, nullable: true),
                    Work_State = table.Column<string>(maxLength: 100, nullable: true),
                    Work_Zip = table.Column<string>(maxLength: 25, nullable: true),
                    Work_Location = table.Column<string>(maxLength: 100, nullable: true),
                    Cell_Phone = table.Column<string>(maxLength: 25, nullable: true),
                    Username = table.Column<string>(maxLength: 50, nullable: true),
                    Payroll_Title = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Employee_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
