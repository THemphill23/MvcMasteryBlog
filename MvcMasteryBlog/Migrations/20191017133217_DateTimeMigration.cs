using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class DateTimeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Blogs");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Blogs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "Date",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: 2077);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: 2077);
        }
    }
}
