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
        public DateTime DateTime { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }

        public virtual IList<BlogTag> BlogTags { get; set; }

        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }


        public Blog()
        {
        }

    }
}
