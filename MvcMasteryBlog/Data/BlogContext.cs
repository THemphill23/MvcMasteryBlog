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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogReviews;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                {
                    ID = 1,
                    Image = "image",
                    Title = "Food Blog",
                    Date = 2077,
                    Body = "Lorem Ipsum",
                    Author = "Chef Bobby",
                    Genre = "Food",
                    //Tags = "Food, Chef",
                },

                new Blog()
                {
                    ID = 2,
                    Image = "image",
                    Title = "Food Blog",
                    Genre = "Food",
                    Date = 2077,
                    Author = "Chef Bobby",
                    Body = "Lorem Ipsum",
                    //Tags = "Food, Chef",
                });

            modelBuilder.Entity<Tag>().HasData(
                new Tag()
                {
                    ID = 1,
                    Name = "Food",
                    BlogID = 1,
                },


                new Tag()
                {
                    ID = 2,
                    Name = "Chef",
                    BlogID = 1,
                });

            modelBuilder.Entity<Genre>().HasData(
                new Genre()
                {
                    ID = 1,
                    Name = "Food",
                    BlogID = 1,
                });

            base.OnModelCreating(modelBuilder);
            
        }
    }
}
