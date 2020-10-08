using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspCitylink.BusinessLogic;
using AspCitylink.Domains;

namespace AspCitylink.Controllers
{
    public class CartController : Controller
    {
        // контейнер для базы
        protected readonly ModelCitylinkContainer _db;

        public CartController()
        {
            _db = new ModelCitylinkContainer();
        }

        public ActionResult Details()
        {
            var cart = GetCart();

            return View(cart);
        }

        private void UpdateProductForCart(int id, int count = 1)
        {
            var product = _db.Products.Find(id);
            var cart = GetCart();
            cart.Add(product, count);
            SaveCart(cart);
        }

        // GET: Cart
        public ActionResult Purchase(int id, string returnUrl)
        {
            UpdateProductForCart(id);

            return new RedirectResult(returnUrl);
        }

        public ActionResult Increase(int id, string returnUrl)
        {
            UpdateProductForCart(id);

            return new RedirectResult(returnUrl);
        }

        public ActionResult Decrease(int id, string returnUrl)
        {
            UpdateProductForCart(id, -1);

            return new RedirectResult(returnUrl);
        }

        private Cart GetCart()
        {
            var cart = (Cart) Session["Cart"] ?? new Cart();

            return cart;
        }

        public void SaveCart(Cart cart)
        {
            Session["Cart"] = cart;
        }
    }
}