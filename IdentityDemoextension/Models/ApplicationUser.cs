using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemoextension.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Specialization class for the identityuser class 
        // Constructor to reference the base class
        public ApplicationUser() : base ()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
