using MvcMasteryBlog.Data;
using MvcMasteryBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MvcMasteryBlog.Repositories
{
    public class BlogRepository : IRepository<Blog>
    {
        private BlogContext db;

        public BlogRepository(BlogContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Blogs.Count();
        }


        public IEnumerable<Blog> GetAll()
        {
            return db.Blogs;
        }


        public Blog GetByID(int id)
        {
            return db.Blogs.SingleOrDefault(b => b.ID == id);
        }
    }
}
