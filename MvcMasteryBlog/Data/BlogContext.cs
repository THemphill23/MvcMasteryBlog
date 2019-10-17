using Microsoft.EntityFrameworkCore;
using MvcMasteryBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMasteryBlog.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<BlogTag> BlogTags { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogReviews;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogTag>().HasKey(sc => new { sc.BlogID, sc.TagID });

            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                {
                    ID = 1,
                    Image = "image",
                    Title = "Food Blog",
                    Body = "Lorem Ipsum",
                    Author = "Chef Bobby",
                    GenreID = 1,
                },

                new Blog()
                {
                    ID = 2,
                    Image = "image",
                    Title = "Food Blog",
                    Author = "Chef Bobby",
                    Body = "Lorem Ipsum",
                    GenreID = 1,
                });

            modelBuilder.Entity<Tag>().HasData(
                new Tag()
                {
                    ID = 1,
                    Name = "Food",
                },


                new Tag()
                {
                    ID = 2,
                    Name = "Chef",
                });

            modelBuilder.Entity<Genre>().HasData(
                new Genre()
                {
                    ID = 1,
                    Name = "Food",
                });

            modelBuilder.Entity<BlogTag>().HasData(
                new BlogTag()
                {
                    BlogID = 1,
                    TagID = 1,
                },

                new BlogTag()
                {
                    BlogID = 1,
                    TagID = 2,
                },

                new BlogTag()
                {
                    BlogID = 2,
                    TagID = 1,
                },

                new BlogTag()
                {
                    BlogID = 2,
                    TagID = 2,
                });

            base.OnModelCreating(modelBuilder);
            
        }
    }
}
