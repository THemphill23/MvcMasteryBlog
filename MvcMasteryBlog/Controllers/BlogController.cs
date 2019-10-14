using Microsoft.AspNetCore.Mvc;
using MvcMasteryBlog.Models;
using MvcMasteryBlog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMasteryBlog.Controllers
{
    public class BlogController : Controller
    {
        Repository<Blog> blogRepo;

        public BlogController(Repository<Blog> blogRepo)
        {
            this.blogRepo = blogRepo;
        }

        public ViewResult Index()
        {
            var model = blogRepo.GetAll();

            return View();
        }


        public ViewResult Detail(int id)
        {
            var model = blogRepo.GetById(id);

            return View(model);
        }

    }
}
