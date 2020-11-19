using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AspCitylink.Infrastructure
{
    public class UsersDbContext : IdentityDbContext<ApplicationUser>
    {
        public UsersDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static UsersDbContext Create()
        {
            System.Data.Entity.Database.SetInitializer(new MyContextInitializer());
            return new UsersDbContext();
        }
    }

    public class MyContextInitializer 
        : DropCreateDatabaseAlways<UsersDbContext>
    {
        private ApplicationUserManager _userManager;
        private RoleManager<UserRole> _roleManager;

        protected override void Seed(UsersDbContext context)
        {
            // хотим в базу сразу стандартные роли
            _userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            _roleManager = new RoleManager<UserRole>(new RoleStore<UserRole>(context));

            string[] roles = {"admin", "user", "content_manager", "sales_manager"};
            foreach (var roleName in roles)
            {
                if (!_roleManager.RoleExists(roleName))
                {
                    _roleManager.Create(new UserRole(roleName));
                }
            }
            // создадим админа
            var user = new ApplicationUser()
            {
                Email = "admin@ya.ru",
                Address = "Челябинск",
                PhoneNumber = "+7900",
                UserName = "admin@ya.ru",
                Firstname = "Вася",
                Lastname =  "Главный"
            };
            IdentityResult result = _userManager.Create(user, "1Password!");
            if (result == IdentityResult.Success)
            {
                _userManager.AddToRole(user.Id, "admin");
            }

            base.Seed(context);
        }
    }
}