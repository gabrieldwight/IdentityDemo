using System;
using System.Collections.Generic;
using System.Text;
using IdentityDemoextension.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityDemoextension.Data
{
    // To modify the identityDBContext class extension to identity user, identity role and a generic string
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
