using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspCitylink.Domains;

namespace AspCitylink.Helpers
{
    public static class ModelContainerExtension
    {
        public static bool UpdateProduct(this ModelCitylinkContainer db, Product model)
        {
            var original = db.Products.Find(model.ProductId);
            if (original == null) return false;
            db.Entry(original).CurrentValues.SetValues(model);

            db.SaveChanges();
            return true;
        }
    }
}