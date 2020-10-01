using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspCitylink
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new
                {
                    controller = "Product",
                    action = "List",
                    page = 1
                }
            );

            routes.MapRoute(
                "PageNav",
                "Page{page}", // Page5 =>  "Product/List/5"
                new
                {
                    controller = "Product",
                    action = "List"
                },
                new { page = @"\d+" }
                // \d+  любая цифра с числом повторов 1 и более
            );

            // добавим маршруты с категориями
            routes.MapRoute(
                "CategegoryNav",
                "{categoryName}", //  www.AspCitylink/Smart =>  categoryName = "Smart"
                new
                {
                    controller = "Product",
                    action = "List",
                    page = 1
                }
            );

            // добавим маршруты с категориями и страницами
            routes.MapRoute(
                "CategegoryPageNav",
                "{categoryName}/Page{page}", //  www.AspCitylink/Smart/Page5 =>  categoryName = "Smart", page=5
                new
                {
                    controller = "Product",
                    action = "List"
                },
                new { page = @"\d+" }
            );


            routes.MapRoute(
                name: "Full",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Product",
                    action = "List",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
