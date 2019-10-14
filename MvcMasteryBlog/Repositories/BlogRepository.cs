using MvcMasteryBlog.Data;
using MvcMasteryBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMasteryBlog.Repositories
{
    public class BlogRepository : Repository<Blog>
    {

        public BlogRepository(BlogContext context) : base(context)
        {
        }

    }
}
