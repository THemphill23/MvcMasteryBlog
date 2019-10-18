using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMasteryBlog.Models
{
    public class Genre
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }

        public Genre()
        {
        }

        public Genre(int id, string name, ICollection<Blog> blogs)
        {
            ID = id;
            Name = name;
            Blogs = blogs;
        }
    }
}
