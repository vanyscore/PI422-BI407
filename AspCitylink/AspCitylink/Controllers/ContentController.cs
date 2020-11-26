using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspCitylink.Domains;
using AspCitylink.Helpers;

namespace AspCitylink.Controllers
{
    // усилим безопасность
    [Authorize(Roles="content_manager")]
    public class ContentController : Controller
    {
        protected readonly ModelCitylinkContainer _db;

        public ContentController()
        {
            _db = new ModelCitylinkContainer();
        }

        public ActionResult EditProduct(int productId, string returnUrl)
        {
            var product = _db.Products.Find(productId);
            if (product == null)
            {
                return View("Error");
            }

            return View(product);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                if (_db.UpdateProduct(model))
                {
                    return RedirectToAction("List", "Product");
                }
                else
                {
                    return View("Error");
                }
            }

            return View("EditProduct", model);
        }
    }
}