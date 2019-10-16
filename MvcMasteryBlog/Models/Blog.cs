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

        public virtual IList<BlogTag> BlogTags { get; set; }

        //public virtual ICollection<Tag> Tags { get; set; }

        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }


        public Blog()
        {
        }

        public Blog(int id, string image, string title, int date, string body,
            string author/*, ICollection<Tag> tags*/)
        {
            ID = id;
            Image = image;
            Title = title;
            Date = date;
            Body = body;
            Author = author;
            //Tags = tags;
        }
        
    }
}
