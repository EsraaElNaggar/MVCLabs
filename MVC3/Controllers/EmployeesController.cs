using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            ViewBag.Action = "Add";
            return View("EmployeeForm");
        }

        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                TempData["Message"] = "Employee added successfully ";
                //return View("Index", context.Employees.ToList());
                return RedirectToAction(nameof(Index));
            }
            return View("EmployeeForm");
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Employee employee = context.Employees.Find(id);
            if (employee != null)
            {
                ViewBag.Action = "Edit";
                return View("EmployeeForm",employee);
            }
            return HttpNotFound("Employee not found");
        }
        [HttpPost]
        //public ActionResult EditPost(Employee employee)
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Attach(employee);
                context.Entry(employee).State = EntityState.Modified;
                context.SaveChanges();
                TempData["Message"] = "Employee edited successfully ";
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Action = "Edit";
            return View("EmployeeForm", employee);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Employee employee = context.Employees.Find(id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
                return Json(true);
            }
            return HttpNotFound("Employee not found");
        }
    }
}