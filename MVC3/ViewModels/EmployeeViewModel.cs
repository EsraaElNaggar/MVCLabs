using MVC3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3.ViewModels
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public Employee Employee { get; set; }
        public List<Departments> Departments { get; set; }
    }
}