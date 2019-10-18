using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMasteryBlog.Models;
using MvcMasteryBlog.Repositories;

namespace MvcMasteryBlog.Controllers
{
    public class GenreController : Controller
    {
        IRepository<Genre> genreRepo;

        public GenreController(IRepository<Genre> genreRepo)
        {
            this.genreRepo = genreRepo;
        }

        public ViewResult Index()
        {
            var model = genreRepo.GetAll();
            return View(model);
        }
    }
}