using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class BlogTagMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Blogs_BlogID",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_BlogID",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Tags");

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    BlogID = table.Column<int>(nullable: false),
                    TagID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => new { x.BlogID, x.TagID });
                    table.ForeignKey(
                        name: "FK_BlogTags_Blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blogs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogTags_Tags_TagID",
                        column: x => x.TagID,
                        principalTable: "Tags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_TagID",
                table: "BlogTags",
                column: "TagID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Tags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "ID",
                keyValue: 1,
                column: "BlogID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "ID",
                keyValue: 2,
                column: "BlogID",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogID",
                table: "Tags",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Blogs_BlogID",
                table: "Tags",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
