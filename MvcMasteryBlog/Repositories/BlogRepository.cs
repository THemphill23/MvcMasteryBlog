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

        public IEnumerable<Blog> GetByTagID(int tagID)
        {
            var blogs = db.BlogTags.Where(t => t.TagID == tagID)
                .Select(b => b.Blog);
            return blogs;
        }

        //public IEnumerable<Blog> GetByGenreID(int genreID)
        //{
        //    var blogs = db.Blogs.Where(b => b.GenreID== genreID);
        //    return blogs;
        //}


        //public IEnumerable<Genre> GetByGenreID(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public void Create(Blog blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();
        }

        public void Delete(Blog blog)
        {
            db.Blogs.Remove(blog);
            db.SaveChanges();
        }

        public void Edit(Blog blog)
        {
            db.Blogs.Update(blog);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
