using MvcMasteryBlog.Data;
using MvcMasteryBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMasteryBlog.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
       private BlogContext db;

       public TagRepository(BlogContext db)
       {
           this.db = db;
       }

       public int Count()
       {
           return db.Tags.Count();
       }

       public IEnumerable<Tag> GetAll()
       {
           return db.Tags;
       }

       public Tag GetByID(int id)
       {
           return db.Tags.Single(b => b.ID == id);
       }
    }
}
