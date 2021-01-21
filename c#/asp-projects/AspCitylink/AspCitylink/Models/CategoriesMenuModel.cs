using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspCitylink.Domains;

namespace AspCitylink.Models
{
    public class CategoriesMenuModel
    {
        public string ActiveCategoryName { get; set; }

        public List<Category> Categories { get; set; }
    }
}