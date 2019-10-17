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

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            blogRepo.Create(blog);
            return RedirectToAction("Blog", new { id = blog.ID });
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            ViewBag.blogID = id;
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Blog blog)
        {
            blogRepo.Delete(blog);
            return RedirectToAction("Blog", new { id = blog.ID });
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = blogRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Blog blog)
        {
            blogRepo.Edit(blog);
            return RedirectToAction("Blog", new { id = blog.ID });
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = blogRepo.GetByID(id);
            return View(model);
        }


    }



}

