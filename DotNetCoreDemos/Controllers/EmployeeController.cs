using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreDemos.Entities;
using DotNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DotNetCoreDemos.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {
            var employeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities=new List<SelectListItem>
                {
                    new SelectListItem{Text="Bartın",Value="74"},
                    new SelectListItem{Text="İstanbul",Value="34"},
                    new SelectListItem{Text="Çanakkale",Value="17"},
                    new SelectListItem{Text="Ankara",Value="06"}

                }
            };
            return View(employeeAddViewModel);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            var ss = employee;
            return View();
        }
    }
}