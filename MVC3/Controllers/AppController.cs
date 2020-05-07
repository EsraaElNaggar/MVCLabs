using MVC3.DAL;
using MVC3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3.Controllers
{
    public class AppController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var result = new ViewResult();
            return result;
        }
        [HttpGet]
        public ViewResult RegForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RegForm(Employee emp)
        {
            var ctx = new ApplicationDBContext();
            if (ModelState.IsValid)
            {
                ctx.Employees.Add(emp);
                ctx.SaveChanges();
                return View("About", emp);
            }
            return View();
        }
        [HttpGet]
        public ViewResult About()
        {
            var result = new ViewResult();
            return result;
        }
    }
}