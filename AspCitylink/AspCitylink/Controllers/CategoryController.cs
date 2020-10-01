using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspCitylink.Domains;
using AspCitylink.Models;

namespace AspCitylink.Controllers
{
    public class CategoryController : Controller
    {
        protected readonly ModelCitylinkContainer _db;

        public CategoryController()
        {
            _db = new ModelCitylinkContainer();        
        }

        // частичное представление
        // занимает только часть вьюшки основной
        // этот кусочек не статич он генарируется за счёт БД
        public PartialViewResult PartialViewMenu()
        {
            string activeCategoryName = (string)Session["ActiveCategoryName"];

            var categories = _db.Categories.ToList();

            var model = new CategoriesMenuModel()
            {
                ActiveCategoryName = activeCategoryName,
                Categories = categories
            };

            return PartialView(model);
        }
    }
}