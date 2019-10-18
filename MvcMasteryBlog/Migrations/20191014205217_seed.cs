using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "ID", "Author", "BlogID", "Body", "Date", "Genre", "Image", "Tags", "Title" },
                values: new object[] { 2, "Chef", null, "Lorem Ipsum", 2077, "Food", "image", "Food, Cooking", "Food Blog" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "ID", "Author", "BlogID", "Body", "Date", "Genre", "Image", "Tags", "Title" },
                values: new object[] { 3, "Chef", null, "Lorem Ipsum", 2077, "Food", "image", "Food, Cooking", "Food Blog" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
