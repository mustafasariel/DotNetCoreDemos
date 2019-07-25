using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreDemos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreDemos.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello .net core";
        }
        public ViewResult Index2()
        {
            ViewModel model = new ViewModel();


            model.Students.Add(new Entities.Student() { Number = "124", Name = "Kerem", Lastname = "sarıel" });
            model.Students.Add(new Entities.Student() { Number = "125", Name = "Emirhan", Lastname = "sarıel" });

            model.Teachers.Add(new Entities.Teacher() { Name = "mustafa", Lastname = "sarıel" });
            model.Teachers.Add(new Entities.Teacher() { Name = "mustafa", Lastname = "sarıel" });

            return View(model);
        }

        public StatusCodeResult Index3()
        {
            return NotFound();
        }

        public JsonResult GetJSon()
        {
            ViewModel model = new ViewModel();


            model.Students.Add(new Entities.Student() { Number = "124", Name = "Kerem", Lastname = "sarıel" });
            model.Students.Add(new Entities.Student() { Number = "125", Name = "Emirhan", Lastname = "sarıel" });

            model.Teachers.Add(new Entities.Teacher() { Name = "serpil", Lastname = "sarıel" });
            model.Teachers.Add(new Entities.Teacher() { Name = "mustafa", Lastname = "sarıel" });

            return Json(model);
        }
        /// <summary>
        /// Query string model binding
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public JsonResult GetJSon2(string key)
        {
            ViewModel model = new ViewModel();


            model.Students.Add(new Entities.Student() { Number = "124", Name = "Kerem", Lastname = "sarıel" });
            model.Students.Add(new Entities.Student() { Number = "125", Name = "Emirhan", Lastname = "sarıel" });

            model.Teachers.Add(new Entities.Teacher() { Name = "serpil", Lastname = "sarıel" });
            model.Teachers.Add(new Entities.Teacher() { Name = "mustafa", Lastname = "sarıel" });


            if (String.IsNullOrEmpty(key))
            {
                return Json(model.Students);
            }
            else
            {
                var result = model.Students.Where(x => x.Name.ToLower().Contains(key));

                return Json(result);
            }
        }
        /// <summary>
        /// Nasıl çalışır, studenformdaki formda arama sonucunda hangi actionın çalıştırılıcağı belirilir.
        /// bunda göre GetJSon2 actionanına aşağıdaki gibi bir kod ile yönlendiriliğini söylemiş olduk.
        /// @using (Html.BeginForm("GetJSon2", "Home"))
        /// </summary>
        /// <returns></returns>
        public ViewResult StudentForm()
        {
            return View();
        }

        public new string RouteData(int id)
        {
            return id.ToString();
        }
    }
}