using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMasteryBlog.Controllers
{
    public class BlogController : Controller
    {
        public ViewResult Index()
        {
            var model = blogRepo.GetAll();

            return View(model);
        }

        public ViewResult Detail(int id)
        {
            var model = blogRepo.GetByID(id);

            return View(model);
        }

    }
}
