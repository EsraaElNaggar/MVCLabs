using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3.DAL;
using MVC3.Models;

namespace MVC3.Controllers
{
    public class EmployeesController : Controller
    {
        ApplicationDBContext context = new ApplicationDBContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View(context.Employees.ToList());
        }
        //[ChildActionOnly]
        //public PartialViewResult EmployeePartial(int Id)
        //{
        //    Employee employee = context.Employees.Find(Id);
        //    return PartialView("_EmployeePartial", employee);
        //}

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                //return View("Index", context.Employees.ToList());
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}