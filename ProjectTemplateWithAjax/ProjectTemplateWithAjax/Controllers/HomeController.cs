using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectTemplateWithAjax.Repository;

namespace ProjectTemplateWithAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowStudents_V1()
        {
            var students = DataManager.GetStudents();

            return View(students);
        }
    }
}