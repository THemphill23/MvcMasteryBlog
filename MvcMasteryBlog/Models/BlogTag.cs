using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMasteryBlog.Models
{
    public class BlogTag
    {
        public virtual int BlogID { get; set; }
        public virtual Blog Blog { get; set; }

        public virtual int TagID { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
