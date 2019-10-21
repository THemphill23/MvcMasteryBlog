using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class AdditionalDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "ID", "Author", "Body", "DateTime", "GenreID", "Image", "Title" },
                values: new object[] { 3, "Commander Shepard", "Shepard Liara Garrus Turian Asari Thane Jacob Miranda Kaiden Ashley Space normandy Cerberous ShootingGalaxy Mass Effect Field Shotguns Pistols Heavy Weapons Rifles Armor Elcor Drell Grunt Wrex Solldier VanguardAdept Biotics", new DateTime(2019, 10, 18, 17, 35, 0, 359, DateTimeKind.Local), 1, "/Images/MassEffect3", "Space Chills" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Nintendo");

            migrationBuilder.InsertData(
                table: "BlogTags",
                columns: new[] { "BlogID", "TagID" },
                values: new object[] { 3, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2019, 10, 17, 19, 46, 54, 174, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2019, 10, 17, 19, 46, 54, 175, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Nintedo");
        }
    }
}
