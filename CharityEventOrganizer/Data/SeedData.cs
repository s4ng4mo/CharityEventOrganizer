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

            // Create roles
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string[] roleNames = { "Admin", "User", "Sponsor" };
            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}