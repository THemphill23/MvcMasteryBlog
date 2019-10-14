using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "ID", "Author", "BlogID", "Body", "Date", "Genre", "Image", "Tags", "Title" },
                values: new object[] { 1, "Chef", null, "Lorem Ipsum", 2077, "Food", "image", "Food, Cooking", "Food Blog" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
