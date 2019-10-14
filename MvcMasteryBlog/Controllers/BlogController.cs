using Microsoft.AspNetCore.Mvc;
using MvcMasteryBlog.Models;
using MvcMasteryBlog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMasteryBlog.Models;
using Microsoft.AspNetCore.Mvc;
using MvcMasteryBlog.Repositories;

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


        public ViewResult Details(int id)
        {
            var model = blogRepo.GetById(id);

            return View(model);
        }

    }
}
