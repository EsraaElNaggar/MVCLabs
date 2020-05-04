using MVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Controllers
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
                var ctx = new ModelContext();
                if (ModelState.IsValid)
                {
                    ctx.Employees.Add(emp);
                    ctx.SaveChanges();
                    return View("Welcome", emp);
                }
                return View();
            }

            //// GET: App
            //public ActionResult Index()
            //{
            //    return View();
            //}
    }
}