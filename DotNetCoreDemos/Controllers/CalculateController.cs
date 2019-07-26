using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreDemos.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreDemos.Controllers
{
    public class CalculateController : Controller
    {
        ICalculate calculate;

        public CalculateController(ICalculate calculate)
        {
            this.calculate = calculate;
        }
        public IActionResult Index()
        {
            return View();
        }
        public string   KDV()
        {
           return  calculate.Calculate(100).ToString();
        }
    }
}