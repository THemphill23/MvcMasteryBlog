using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class TimeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2019, 10, 17, 15, 36, 8, 85, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 10, 17, 15, 36, 8, 86, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
