using Microsoft.EntityFrameworkCore.Migrations;

namespace Poroject.DataLayer.Migrations
{
    public partial class mig_UpdateCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_CourseLevels_CourseLevelLevelId",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_courses_CourseStatuses_CourseStatusStatusId",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_CourseLevelLevelId",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_CourseStatusStatusId",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "CourseLevelLevelId",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "CourseStatusStatusId",
                table: "courses");

            migrationBuilder.AlterColumn<int>(
                name: "CoursePrice",
                table: "courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateIndex(
                name: "IX_courses_LevelId",
                table: "courses",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_courses_StatusId",
                table: "courses",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_CourseLevels_LevelId",
                table: "courses",
                column: "LevelId",
                principalTable: "CourseLevels",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_courses_CourseStatuses_StatusId",
                table: "courses",
                column: "StatusId",
                principalTable: "CourseStatuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_CourseLevels_LevelId",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_courses_CourseStatuses_StatusId",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_LevelId",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_StatusId",
                table: "courses");

            migrationBuilder.AlterColumn<bool>(
                name: "CoursePrice",
                table: "courses",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CourseLevelLevelId",
                table: "courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseStatusStatusId",
                table: "courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_courses_CourseLevelLevelId",
                table: "courses",
                column: "CourseLevelLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_courses_CourseStatusStatusId",
                table: "courses",
                column: "CourseStatusStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_CourseLevels_CourseLevelLevelId",
                table: "courses",
                column: "CourseLevelLevelId",
                principalTable: "CourseLevels",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_courses_CourseStatuses_CourseStatusStatusId",
                table: "courses",
                column: "CourseStatusStatusId",
                principalTable: "CourseStatuses",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
