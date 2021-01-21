using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AspCitylink.Infrastructure
{
    public class UserRole : IdentityRole
    {
        public UserRole()
        {
            
        }

        public UserRole(string roleName) : base(roleName)
        {
        }
    }
}