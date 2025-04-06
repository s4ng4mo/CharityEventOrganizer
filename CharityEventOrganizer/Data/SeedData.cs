using System;
using System.Linq;
using System.Threading.Tasks;
using CharityEventOrganizer.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CharityEventOrganizer.Data
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            // Create roles if they don't exist
            string[] roleNames = { "Admin", "User", "Sponsor" };
            foreach (var roleName in roleNames)
            {
                var roleExists = await roleManager.RoleExistsAsync(roleName);
                if (!roleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // Check if we already have causes
            if (context.Causes.Any())
            {
                return;   // DB has been seeded
            }

            // Add causes
            context.Causes.AddRange(
                new Cause { Name = "Education", Description = "Supporting educational initiatives" },
                new Cause { Name = "Healthcare", Description = "Improving access to healthcare" },
                new Cause { Name = "Environment", Description = "Environmental conservation and sustainability" },
                new Cause { Name = "Poverty", Description = "Fighting poverty and homelessness" },
                new Cause { Name = "Animal Welfare", Description = "Supporting animal rights and care" },
                new Cause { Name = "Disaster Relief", Description = "Helping communities affected by disasters" }
            );

            await context.SaveChangesAsync();

            const string adminEmail = "admin@charityeventorganizer.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    UserName = "admin",
                    Email = adminEmail,
                    EmailConfirmed = true,
                    FirstName = "System",
                    LastName = "Administrator"
                };

                var result = await userManager.CreateAsync(adminUser, "Admin123!");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                    Console.WriteLine("Admin user created successfully");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        Console.WriteLine($"Error creating admin user: {error.Description}");
                    }
                }
            }
        }
    }
}