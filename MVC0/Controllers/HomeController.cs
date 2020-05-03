using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC0.Controllers
{
    public class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var result = new ViewResult();
            return result;
        }
        [HttpGet]
        public ActionResult RegForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegForm(User user)
        {
            if (user.name != null && user.email != null && user.password != null)
            {
                ViewBag.Name = user.name;
                return View("Welcome");
            }
            return View();
        }

        //// GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}