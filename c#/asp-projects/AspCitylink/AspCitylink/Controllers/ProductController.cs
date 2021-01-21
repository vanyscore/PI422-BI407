using AspCitylink.Domains;
using AspCitylink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspCitylink.Controllers
{
    public class ProductController : Controller
    {
        protected readonly ModelCitylinkContainer _db;

        // кол-во товаров на странице
        protected int _pageSize = 5;

        public ProductController()
        {
            _db = new ModelCitylinkContainer();
        }

        public ActionResult List(int page, string categoryName = null)
        {
            Session["ActiveCategoryName"] = categoryName;

            IEnumerable<Product> productsOfCategory = string.IsNullOrEmpty(categoryName)? 
                _db.Products.AsEnumerable() :
                _db.Products.Where(p => p.CategoryOfProduct.Name == categoryName);

            // страничная навигация
            var productsForPage = productsOfCategory?
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * _pageSize)
                .Take(_pageSize)
                .ToList();

            int pageCount = productsOfCategory.Count() / _pageSize;

            var model = new PageModel()
            {
                PageCount = pageCount,
                Products = productsForPage,
                ActivePage = page,
                ActiveCategoryName = categoryName
            };

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var product = _db
                .Products
                .FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return View("NotFound");
            }

            return View(product);
        }
    }
}