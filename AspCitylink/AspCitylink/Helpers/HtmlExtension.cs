using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspCitylink.Infrastructure;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace AspCitylink.Helpers
{
    public static class HtmlExtension 
    {
        public static MvcHtmlString GetUserInfo(this HtmlHelper helper, string userId)
        {
            var userManager = HttpContext
                .Current
                .GetOwinContext()
                .GetUserManager<ApplicationUserManager>();

            var user = userManager.FindById(userId);
            string userInfo = $"{user.Lastname} {user.Firstname} " +
                              $"({user.UserName})";

            return new MvcHtmlString(userInfo);
        }

    }
}