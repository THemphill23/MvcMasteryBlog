using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class FixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Blogs_BlogID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogID",
                table: "Blogs");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Blogs");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Author", "Tags" },
                values: new object[] { "Chef Bobby", "Food, Chef" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Author", "Tags" },
                values: new object[] { "Chef Bobby", "Food, Chef" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Blogs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Author", "Tags" },
                values: new object[] { "Chef", "Food, Cooking" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Author", "Tags" },
                values: new object[] { "Chef", "Food, Cooking" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "ID", "Author", "BlogID", "Body", "Date", "Genre", "Image", "Tags", "Title" },
                values: new object[] { 3, "Chef", null, "Lorem Ipsum", 2077, "Food", "image", "Food, Cooking", "Food Blog" });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogID",
                table: "Blogs",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Blogs_BlogID",
                table: "Blogs",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
