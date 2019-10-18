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
                    Image = "/Images/Pkmn.jfif",
                    Title = "Gotta Catch 'Em All Fever",
                    Author = "Ash Ketcham",
                    Body = "Bulbasaur Ivysaur Venusaur Charmander Charmeleon Charizard Squirtle Wartortle Blastoise " +
                    "Caterpie Metapod Butterfree Weedle Kakuna Beedrill Pidgey Pidgeotto Pidgeot Rattata Raticate " +
                    "Spearow Fearow Ekans Arbok Pikachu Raichu Sandshrew Sandslash Nidoran Nidorina Nidoqueen " +
                    "Nidoran Nidorino Nidoking Clefairy Clefable Vulpix Ninetales.",
                    GenreID = 1,
                    DateTime = DateTime.Now,
                },

                new Blog()
                {
                    ID = 2,
                    Image = "/Images/LoL.jpg",
                    Title = "A League Of Their Own",
                    Author = "Riot Legend",
                    Body = "Aatrox the Darkin Blade Ahri the Nine - Tailed Fox Akali the Rogue Assassin Alistar the Minotaur " +
                    "Amumu the Sad Mummy Anivia the Cryophoenix Annie the Dark Child Ashe the Frost Archer " +
                    "Aurelion Sol the Star Forger Azir the Emperor of the Sands Bard the Wandering Caretaker" +
                    "Blitzcrank the Great Steam Golem Brand the Burning Vengeance Braum the Heart of the Freljord " +
                    "Caitlyn the Sheriff of Piltover Camille the Steel Shadow Cassiopeia the Serpent's Embrace " +
                    "Cho'Gath the Terror of the Void Corki the Daring Bombardier Darius the Hand of Noxus Diana, Scorn of the Moon" +
                    "Dr.Mundo the Madman of Zaun Draven the Glorious Executioner",
                    GenreID = 2,
                    DateTime = DateTime.Now,

                });

            modelBuilder.Entity<Tag>().HasData(
                new Tag()
                {
                    ID = 1,
                    Name = "Role Playing",
                },

                new Tag()
                {
                    ID = 2,
                    Name = "Nintendo",
                },

                new Tag()
                {
                    ID = 3,
                    Name = "Riot",
                },

                new Tag()
                {
                    ID = 4,
                    Name = "Action",
                });

            modelBuilder.Entity<Genre>().HasData(
                new Genre()
                {
                    ID = 1,
                    Name = "RPG",
                },
                new Genre()
                {
                    ID = 2,
                    Name = "MOBA",
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
                    TagID = 3,
                },

                new BlogTag()
                {
                    BlogID = 2,
                    TagID = 4,
                });

            base.OnModelCreating(modelBuilder);
            
        }
    }
}
