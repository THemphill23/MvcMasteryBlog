using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class TagMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Blogs");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: true),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlogID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tags_Blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blogs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "ID", "BlogID", "Name" },
                values: new object[] { 1, 1, "Food" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "ID", "BlogID", "Name" },
                values: new object[] { 2, 1, "Chef" });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_BlogID",
                table: "Tags",
                column: "BlogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Blogs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                column: "Tags",
                value: "Food, Chef");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                column: "Tags",
                value: "Food, Chef");
        }
    }
}
