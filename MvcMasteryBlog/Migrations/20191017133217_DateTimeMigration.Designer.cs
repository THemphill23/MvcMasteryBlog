﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMasteryBlog.Data;

namespace MvcMasteryBlog.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20191017133217_DateTimeMigration")]
    partial class DateTimeMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        new { ID = 1, Author = "Chef Bobby", Body = "Lorem Ipsum", DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreID = 1, Image = "image", Title = "Food Blog" },
                        new { ID = 2, Author = "Chef Bobby", Body = "Lorem Ipsum", DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreID = 1, Image = "image", Title = "Food Blog" }
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
                        new { BlogID = 2, TagID = 1 },
                        new { BlogID = 2, TagID = 2 }
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
                        new { ID = 1, Name = "Food" }
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
                        new { ID = 1, Name = "Food" },
                        new { ID = 2, Name = "Chef" }
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
