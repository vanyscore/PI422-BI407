using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspCitylink.Infrastructure;

namespace AspCitylink.Models
{
    public class RoleAndUsersModel
    {
        public UserRole Role { get; set; }

        public List<ApplicationUser> Users { get; set; }
    }
}