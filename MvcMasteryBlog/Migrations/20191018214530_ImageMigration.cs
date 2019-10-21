using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class ImageMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "BlogTags",
                columns: new[] { "BlogID", "TagID" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2019, 10, 18, 17, 45, 30, 722, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 10, 18, 17, 45, 30, 723, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2019, 10, 18, 17, 45, 30, 723, DateTimeKind.Local), "/Images/MassEffect3.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.InsertData(
                table: "BlogTags",
                columns: new[] { "BlogID", "TagID" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2019, 10, 18, 17, 35, 0, 358, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 10, 18, 17, 35, 0, 359, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateTime", "Image" },
                values: new object[] { new DateTime(2019, 10, 18, 17, 35, 0, 359, DateTimeKind.Local), "/Images/MassEffect3" });
        }
    }
}
