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

        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }

        public Genre()
        {
        }

        public Genre(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
