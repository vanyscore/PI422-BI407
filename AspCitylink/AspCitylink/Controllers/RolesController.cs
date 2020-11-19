using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AspCitylink.Infrastructure;
using AspCitylink.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace AspCitylink.Controllers
{
    public class RolesController : Controller
    {
        public ApplicationUserManager UserManager =>
            HttpContext
                .GetOwinContext()
                .GetUserManager<ApplicationUserManager>();

        public UserRolesManager RolesManager =>
            HttpContext
                .GetOwinContext()
                .GetUserManager<UserRolesManager>();

        // GET: Roles
        public ActionResult Index()
        {
            var roles = RolesManager.Roles.ToList();
            return View(roles);
        }

        public ActionResult UsersForRoleView(string roleId)
        {
            var role = RolesManager.FindById(roleId);
            var users = UserManager.Users.Take(20).ToList();

            var model = new RoleAndUsersModel()
            {
                Users = users,
                Role = role
            };

            return View(model);
        }

        public async Task<ActionResult> AddUserToRole(string roleId, string userId)
        {
            var role = RolesManager.FindById(roleId);

            IdentityResult result = await UserManager.AddToRoleAsync(userId, role.Name);
            if (result == IdentityResult.Success)
            {
                return RedirectToAction("Index");
            }

            return View("Error");
        }
    }
}