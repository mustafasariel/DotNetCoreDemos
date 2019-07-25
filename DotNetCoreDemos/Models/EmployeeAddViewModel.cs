
using DotNetCoreDemos.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DotNetCoreDemos.Models
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; internal set; }
        public List<Category> Categories { get; set; }
    }
}