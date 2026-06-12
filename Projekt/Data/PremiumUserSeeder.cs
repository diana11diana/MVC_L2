using Microsoft.AspNetCore.Identity;
using Projekt.Models;

namespace Projekt.Data;

public static class PremiumUserSeeder
{
    public static async Task SeedPremiumUserAsync(
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager)
    {
        string email = "premium@demo.com";
        string password = "Premium123";

        var user = await userManager.FindByEmailAsync(email);

        if (user == null)
        {
            user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                FullName = "Premium User",
                RegisteredAt = DateTime.Now,
                LastLoginAt = DateTime.Now,
                IsPremium = true
            };

            await userManager.CreateAsync(user, password);
        }
        else
        {
            user.IsPremium = true;
            user.FullName = "Premium User";
            await userManager.UpdateAsync(user);
        }

        if (await roleManager.RoleExistsAsync("User"))
        {
            if (!await userManager.IsInRoleAsync(user, "User"))
            {
                await userManager.AddToRoleAsync(user, "User");
            }
        }
    }
}