using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMasteryBlog.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public int ID { get; set; }
   
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }

        public Tag()
        {
        }

        public Tag(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }


}
