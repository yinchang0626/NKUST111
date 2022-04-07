using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrations
{
    public partial class add_course_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "學分數",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "學制",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "必選修",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "總修課人數",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "開課老師",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "學分數",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "學制",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "必選修",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "總修課人數",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "開課老師",
                table: "Courses");
        }
    }
}
