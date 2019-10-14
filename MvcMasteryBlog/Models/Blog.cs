using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMasteryBlog.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public int Date { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Tags { get; set; }

        public Blog()
        {
        }

        public Blog(int id, string image, string title, int date, string body,
            string author, string genre, string tags)
        {
            this.ID = id;
            this.Image = image;
            this.Title = title;
            this.Date = date;
            this.Body = body;
            this.Author = author;
            this.Genre = genre;
            this.Tags = tags;
        }
    }
}
