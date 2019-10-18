using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMasteryBlog.Migrations
{
    public partial class DataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Author", "Body", "DateTime", "Title" },
                values: new object[] { "Ash Ketcham", "Bulbasaur Ivysaur Venusaur Charmander Charmeleon Charizard Squirtle Wartortle Blastoise Caterpie Metapod Butterfree Weedle Kakuna Beedrill Pidgey Pidgeotto Pidgeot Rattata Raticate Spearow Fearow Ekans Arbok Pikachu Raichu Sandshrew Sandslash Nidoran Nidorina Nidoqueen Nidoran Nidorino Nidoking Clefairy Clefable Vulpix Ninetales.", new DateTime(2019, 10, 17, 19, 29, 40, 69, DateTimeKind.Local), "Gotta Catch 'Em All Fever" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "RPG");

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "MOBA" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Role Playing");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Nintedo");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 3, "Riot" },
                    { 4, "Action" }
                });

            migrationBuilder.InsertData(
                table: "BlogTags",
                columns: new[] { "BlogID", "TagID" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "BlogTags",
                columns: new[] { "BlogID", "TagID" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Author", "Body", "DateTime", "GenreID", "Title" },
                values: new object[] { "Riot Legend", "Aatrox the Darkin Blade Ahri the Nine - Tailed Fox Akali the Rogue Assassin Alistar the Minotaur Amumu the Sad Mummy Anivia the Cryophoenix Annie the Dark Child Ashe the Frost Archer Aurelion Sol the Star Forger Azir the Emperor of the Sands Bard the Wandering CaretakerBlitzcrank the Great Steam Golem Brand the Burning Vengeance Braum the Heart of the Freljord Caitlyn the Sheriff of Piltover Camille the Steel Shadow Cassiopeia the Serpent's Embrace Cho'Gath the Terror of the Void Corki the Daring Bombardier Darius the Hand of Noxus Diana, Scorn of the MoonDr.Mundo the Madman of Zaun Draven the Glorious Executioner", new DateTime(2019, 10, 17, 19, 29, 40, 70, DateTimeKind.Local), 2, "A League Of Their Own" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "BlogTags",
                keyColumns: new[] { "BlogID", "TagID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "BlogTags",
                columns: new[] { "BlogID", "TagID" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Author", "Body", "DateTime", "Title" },
                values: new object[] { "Chef Bobby", "Lorem Ipsum", new DateTime(2019, 10, 17, 15, 36, 8, 85, DateTimeKind.Local), "Food Blog" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Author", "Body", "DateTime", "GenreID", "Title" },
                values: new object[] { "Chef Bobby", "Lorem Ipsum", new DateTime(2019, 10, 17, 15, 36, 8, 86, DateTimeKind.Local), 1, "Food Blog" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Food");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Food");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Chef");
        }
    }
}
