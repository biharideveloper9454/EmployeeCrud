using EmployeeCrudOperation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrudOperation.Controllers
{
    public class CascadingController : Controller
    {
        private readonly ApplicationContext context;

        public CascadingController(ApplicationContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetCountries()
        {
            var country = context.Countries.ToList();
            return new JsonResult(country);
        }

        public JsonResult GetStates(int id)
        {
            var state = context.States.Where(e => e.Country.Id == id).ToList();
            return new JsonResult(state);
        }
        public JsonResult GetCities(int id)
        {
            var city = context.Cities.Where(e => e.State.Id == id).ToList();
            return new JsonResult(city);
        }
    }
}
