using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class BlogTagData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BlogTags",
                columns: new[] { "BlogID", "TagID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 2, 2 });
        }
    }
}
