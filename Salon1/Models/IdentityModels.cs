﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace Salon1.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, Please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}