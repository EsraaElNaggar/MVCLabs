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
        public ViewResult RegForm(User user)
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