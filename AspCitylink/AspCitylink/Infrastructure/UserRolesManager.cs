using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace AspCitylink.Infrastructure
{
    public class UserRolesManager : RoleManager<UserRole>
    {
        public UserRolesManager(IRoleStore<UserRole, string> store) 
            : base(store)
        {
        }

        public static UserRolesManager 
            Create(IdentityFactoryOptions<UserRolesManager> options, 
                IOwinContext context)
        {
            var userContext = context.Get<UsersDbContext>();
            var store = new RoleStore<UserRole>(userContext);
            var manager = new UserRolesManager(store);

            return manager;
        }
    }
}