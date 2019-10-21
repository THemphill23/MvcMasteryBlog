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
   
        public virtual IList<BlogTag> BlogTags { get; set; }      

        public Tag()
        {
        }

    }


}
