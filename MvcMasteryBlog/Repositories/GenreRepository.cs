using MvcMasteryBlog.Data;
using MvcMasteryBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMasteryBlog.Repositories
{
    public class GenreRepository : IRepository<Genre>
    {
        private BlogContext db;

        public GenreRepository(BlogContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Genres.Count();
        }

        public IEnumerable<Genre> GetAll()
        {
            return db.Genres;
        }

        public Genre GetByID(int id)
        {
            return db.Genres.Single(b => b.ID == id);
        }
    }
}
