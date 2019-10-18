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

        public void Create(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Tag obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAll()
       {
           return db.Tags;
       }

        public IEnumerable<Tag> GetByGenreID(int id)
        {
            throw new NotImplementedException();
        }

        public Tag GetByID(int id)
       {
           return db.Tags.SingleOrDefault(b => b.ID == id);
       }


        public IEnumerable<Tag> GetByTagID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
