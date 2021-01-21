using AspCitylink.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspCitylink.Models
{
    public class PageModel
    {
        public string ActiveCategoryName { get; set; }
        public int ActivePage { get; set; }

        public int PageCount { get; set; }

        public List<Product> Products { get; set; }
    }
}