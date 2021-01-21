using System;
using System.Collections.Generic;
using System.IO;
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
                // загрузка картинок, если переданы
                if (Request.Files.Count > 0)
                {
                    // есть файл, берём
                    HttpPostedFileBase file = Request.Files[0];
                    string physicalPath = Server.MapPath("~/Content/Images");
                    string fileName = $"{Guid.NewGuid()}.jpg";
                    string filePath = Path.Combine(physicalPath, fileName);
                    file.SaveAs(filePath);
                    model.ImageUrl = $"Images/{fileName}";
                }

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