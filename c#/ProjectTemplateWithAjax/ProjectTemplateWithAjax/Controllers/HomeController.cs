using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ProjectTemplateWithAjax.Models;
using ProjectTemplateWithAjax.Repository;

namespace ProjectTemplateWithAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowStudents_V1(string selectedGroup)
        {
            var students = DataManager.GetStudents();

            if (selectedGroup != null)
            {
                /*
                AcademicGroup group = (AcademicGroup)
                 Enum.Parse(typeof(AcademicGroup), selectedGroup);
                */
                students = students
                    .Where(s => s.AcademicGroup.ToString() == selectedGroup)
                    .ToList();
            }
            // возвращает огромный готовый HTML
            return View(students);
        }

        // версия 2-я - данные гна странице
        // обновлять через ajax запрос и формировать html
        // с поимощью jquery (руками)
        public ActionResult ShowStudents_V2()
        {
            
            return View();
        }

        public string GetStudentsJson(string selectedGroup)
        {
            var students = DataManager.GetStudents()
                    .Where(s => s.AcademicGroup.ToString() == selectedGroup)
                    .ToList();
            string json = JsonConvert.SerializeObject(students);
            // возвращает только студентов
            return json;
        }
    }
}