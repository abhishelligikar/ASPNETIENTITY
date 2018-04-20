using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetIdentityApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Password { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        //public System.Data.Entity.DbSet<AspNetIdentityApp.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}