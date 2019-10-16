using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class GenreUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Blogs_BlogID",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_BlogID",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Blogs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                column: "GenreID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                column: "GenreID",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_GenreID",
                table: "Blogs",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Genres_GenreID",
                table: "Blogs",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Genres_GenreID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_GenreID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Genres",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Blogs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Genre",
                value: "Food");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Genre",
                value: "Food");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 1,
                column: "BlogID",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_BlogID",
                table: "Genres",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Blogs_BlogID",
                table: "Genres",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
