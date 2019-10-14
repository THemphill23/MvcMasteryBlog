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
                    Body = "Lorem Ipsum",
                    Genre = "Food",
                    Author = "Chef",
                    Tags = "Food, Cooking",
                    Date = 2077,
                },


                new Blog()
                {
                    ID = 2,
                    Image = "image",
                    Title = "Food Blog",
                    Body = "Lorem Ipsum",
                    Genre = "Food",
                    Author = "Chef",
                    Tags = "Food, Cooking",
                    Date = 2077,
                },
                new Blog()
                {
                    ID = 3,
                    Image = "image",
                    Title = "Food Blog",
                    Body = "Lorem Ipsum",
                    Genre = "Food",
                    Author = "Chef",
                    Tags = "Food, Cooking",
                    Date = 2077,
                });
        }
    }
}
