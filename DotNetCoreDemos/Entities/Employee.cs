using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreDemos.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        [Display(Name="Last Name")]
        public string Lastname { get; set; }
        [Display(Name="City")]
        public string CityCode { get; set; }
    }
}
