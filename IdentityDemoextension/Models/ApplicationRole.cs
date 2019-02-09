using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemoextension.Models
{
    // We will use this class to extend the identity role class
    public class ApplicationRole : IdentityRole
    {
        // Constructor reference to the base class
        public ApplicationRole() : base ()
        {

        }

        // Constructor to pass Role Name to the base class
        public ApplicationRole(string roleName) : base(roleName)
        {

        }

        // Constructor to pass two arguments such as Role Name, description and creation date to the base class
        public ApplicationRole(string roleName, string description, DateTime creationDate) : base(roleName)
        {
            this.Description = description;
            this.CreationDate = creationDate;
        }

        // Local properties for extension to the identity role class
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
