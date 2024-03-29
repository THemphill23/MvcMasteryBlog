﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMasteryBlog.Data;

namespace MvcMasteryBlog.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcMasteryBlog.Models.Blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Body");

                    b.Property<DateTime>("DateTime");

                    b.Property<int>("GenreID");

                    b.Property<string>("Image");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("GenreID");

                    b.ToTable("Blogs");

                    b.HasData(
                        new { ID = 1, Author = "Ash Ketcham", Body = "Bulbasaur Ivysaur Venusaur Charmander Charmeleon Charizard Squirtle Wartortle Blastoise Caterpie Metapod Butterfree Weedle Kakuna Beedrill Pidgey Pidgeotto Pidgeot Rattata Raticate Spearow Fearow Ekans Arbok Pikachu Raichu Sandshrew Sandslash Nidoran Nidorina Nidoqueen Nidoran Nidorino Nidoking Clefairy Clefable Vulpix Ninetales.", DateTime = new DateTime(2019, 10, 18, 17, 45, 30, 722, DateTimeKind.Local), GenreID = 1, Image = "/Images/Pkmn.jfif", Title = "Gotta Catch 'Em All Fever" },
                        new { ID = 2, Author = "Riot Legend", Body = "Aatrox the Darkin Blade Ahri the Nine - Tailed Fox Akali the Rogue Assassin Alistar the Minotaur Amumu the Sad Mummy Anivia the Cryophoenix Annie the Dark Child Ashe the Frost Archer Aurelion Sol the Star Forger Azir the Emperor of the Sands Bard the Wandering CaretakerBlitzcrank the Great Steam Golem Brand the Burning Vengeance Braum the Heart of the Freljord Caitlyn the Sheriff of Piltover Camille the Steel Shadow Cassiopeia the Serpent's Embrace Cho'Gath the Terror of the Void Corki the Daring Bombardier Darius the Hand of Noxus Diana, Scorn of the MoonDr.Mundo the Madman of Zaun Draven the Glorious Executioner", DateTime = new DateTime(2019, 10, 18, 17, 45, 30, 723, DateTimeKind.Local), GenreID = 2, Image = "/Images/LoL.jpg", Title = "A League Of Their Own" },
                        new { ID = 3, Author = "Commander Shepard", Body = "Shepard Liara Garrus Turian Asari Thane Jacob Miranda Kaiden Ashley Space normandy Cerberous ShootingGalaxy Mass Effect Field Shotguns Pistols Heavy Weapons Rifles Armor Elcor Drell Grunt Wrex Solldier VanguardAdept Biotics", DateTime = new DateTime(2019, 10, 18, 17, 45, 30, 723, DateTimeKind.Local), GenreID = 1, Image = "/Images/MassEffect3.jpg", Title = "Space Chills" }
                    );
                });

            modelBuilder.Entity("MvcMasteryBlog.Models.BlogTag", b =>
                {
                    b.Property<int>("BlogID");

                    b.Property<int>("TagID");

                    b.HasKey("BlogID", "TagID");

                    b.HasIndex("TagID");

                    b.ToTable("BlogTags");

                    b.HasData(
                        new { BlogID = 1, TagID = 1 },
                        new { BlogID = 1, TagID = 2 },
                        new { BlogID = 2, TagID = 3 },
                        new { BlogID = 2, TagID = 4 },
                        new { BlogID = 3, TagID = 1 },
                        new { BlogID = 3, TagID = 4 }
                    );
                });

            modelBuilder.Entity("MvcMasteryBlog.Models.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Genres");

                    b.HasData(
                        new { ID = 1, Name = "RPG" },
                        new { ID = 2, Name = "MOBA" }
                    );
                });

            modelBuilder.Entity("MvcMasteryBlog.Models.Tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Tags");

                    b.HasData(
                        new { ID = 1, Name = "Role Playing" },
                        new { ID = 2, Name = "Nintendo" },
                        new { ID = 3, Name = "Riot" },
                        new { ID = 4, Name = "Action" }
                    );
                });

            modelBuilder.Entity("MvcMasteryBlog.Models.Blog", b =>
                {
                    b.HasOne("MvcMasteryBlog.Models.Genre", "Genre")
                        .WithMany("Blogs")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MvcMasteryBlog.Models.BlogTag", b =>
                {
                    b.HasOne("MvcMasteryBlog.Models.Blog", "Blog")
                        .WithMany("BlogTags")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MvcMasteryBlog.Models.Tag", "Tag")
                        .WithMany("BlogTags")
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
