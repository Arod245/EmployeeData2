using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeData2.Data.Migrations
{
    public partial class NewEmployeeProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "salary",
                table: "EmployeeData",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "salary",
                table: "EmployeeData");
        }
    }
}
