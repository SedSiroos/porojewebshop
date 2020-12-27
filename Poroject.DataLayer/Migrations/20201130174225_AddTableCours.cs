using Microsoft.EntityFrameworkCore.Migrations;

namespace Poroject.DataLayer.Migrations
{
    public partial class AddTableCours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseGroups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseGroups", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_courseGroups_courseGroups_ParentId",
                        column: x => x.ParentId,
                        principalTable: "courseGroups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_courseGroups_ParentId",
                table: "courseGroups",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseGroups");
        }
    }
}
