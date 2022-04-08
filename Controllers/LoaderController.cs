using EmployeeCrudOperation.Models;
using EmployeeCrudOperation.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrudOperation.Controllers
{
    public class LoaderController : Controller
    {
        private ApplicationContext context;
       

        public LoaderController(ApplicationContext _context)
        {
            context = _context;
        }
        public IActionResult Loader()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Loader(Loader model)
        {
            var data = new Loader()
            {
                Name = model.Name
            };
            context.Loaders.Add(data);
            context.SaveChanges();
            return new JsonResult(data);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
