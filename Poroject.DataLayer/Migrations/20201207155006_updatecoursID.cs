using Microsoft.EntityFrameworkCore.Migrations;

namespace Poroject.DataLayer.Migrations
{
    public partial class updatecoursID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "courses",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "courses",
                newName: "CourseId");
        }
    }
}
