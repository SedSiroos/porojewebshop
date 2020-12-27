using Microsoft.EntityFrameworkCore.Migrations;

namespace Poroject.DataLayer.Migrations
{
    public partial class updateIdinEpisod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseEpisodes_courses_CourseId",
                table: "CourseEpisodes");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "CourseEpisodes",
                newName: "CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseEpisodes_CourseId",
                table: "CourseEpisodes",
                newName: "IX_CourseEpisodes_CourseID");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "CourseEpisodes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CourseEpisodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEpisodes_courses_CourseID",
                table: "CourseEpisodes",
                column: "CourseID",
                principalTable: "courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseEpisodes_courses_CourseID",
                table: "CourseEpisodes");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CourseEpisodes");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "CourseEpisodes",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseEpisodes_CourseID",
                table: "CourseEpisodes",
                newName: "IX_CourseEpisodes_CourseId");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CourseEpisodes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEpisodes_courses_CourseId",
                table: "CourseEpisodes",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
