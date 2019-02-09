using IdentityDemoextension.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemoextension.Data
{
    public class DummyData
    {
        // The seed data expects three arguments: context, usermanager object and role manager object
        public static async Task Initialize(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated(); // this is to ensure that the database is created 

            string adminId1 = string.Empty;
            string adminId2 = string.Empty;

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "Member";
            string desc2 = "This is the members role";

            string password = "P@$$w0rd";

            // To check if the admin role exists in the database
            /*if (await roleManager.FindByNameAsync(role1) == null)
            {
                // Instantiate the new admin role through the constructor linked in the Application Role class
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }

            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }*/

            await CreateRole("Admin", "This is the administrator role");
            await CreateRole("Member", "This is the members role");
            await CreateRole("User", "This is the user role");

            async Task CreateRole(string role_name, string role_description)
            {
                if (!(await roleManager.RoleExistsAsync(role_name)))
                {
                    await roleManager.CreateAsync(new ApplicationRole(role_name, role_description, DateTime.Now));
                }
            }

            // To check if the user exists in the database
            if (await userManager.FindByNameAsync("rtesting@test.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "rtesting@test.com",
                    Email = "rtesting@test.com",
                    FirstName = "Adam",
                    LastName = "Aldridge",
                    Street = "Fake St",
                    City = "Vancouver",
                    Province = "BC",
                    PostalCode = "VSU K8I",
                    Country = "Canada",
                    PhoneNumber = "6902341234"
                };

                // create the user through the user manager
                var result = await userManager.CreateAsync(user);
                // If the user is successfully created. We assign the user a password and a role through the user manager object.
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            // To check if the second user exists in the database
            if (await userManager.FindByNameAsync("btesting@test.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "btesting@test.com",
                    Email = "btesting@test.com",
                    FirstName = "Bob",
                    LastName = "Parker",
                    Street = "Vermount St",
                    City = "Surrey",
                    Province = "BC",
                    PostalCode = "VSU K8I",
                    Country = "Canada",
                    PhoneNumber = "6702341234"
                };

                // create the user through the user manager
                var result = await userManager.CreateAsync(user);
                // If the user is successfully created. We assign the user a password and a role through the user manager object.
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            // to check for the third user
            if (await userManager.FindByNameAsync("ctesting@test.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "ctesting@test.com",
                    Email = "ctesting@test.com",
                    FirstName = "Smith",
                    LastName = "Aldridge",
                    Street = "Yew St",
                    City = "Vancouver",
                    Province = "BC",
                    PostalCode = "VSU K8I",
                    Country = "Canada",
                    PhoneNumber = "6905341234"
                };

                // create the user through the user manager
                var result = await userManager.CreateAsync(user);
                // If the user is successfully created. We assign the user a password and a role through the user manager object.
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }

            // to check for the fourth user
            if (await userManager.FindByNameAsync("dtesting@test.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "dtesting@test.com",
                    Email = "dtesting@test.com",
                    FirstName = "Chris",
                    LastName = "Aldridge",
                    Street = "Fake St",
                    City = "Vancouver",
                    Province = "BC",
                    PostalCode = "VSU K8I",
                    Country = "Canada",
                    PhoneNumber = "6901521234"
                };

                // create the user through the user manager
                var result = await userManager.CreateAsync(user);
                // If the user is successfully created. We assign the user a password and a role through the user manager object.
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
        }
    }
}
