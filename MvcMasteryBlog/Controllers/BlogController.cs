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
        IRepository<Blog> blogRepo;

        public BlogController(IRepository<Blog> blogRepo)
        {
            this.blogRepo = blogRepo;
        }

        public ViewResult Index()
        {
            var model = blogRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = blogRepo.GetByID(id);

            return View(model);
        }

    }



}

