using Microsoft.AspNetCore.Identity;
using Booker.App.Models;

namespace Booker.App.Seed
{
    public static class UserSeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var roles = new[] { "Admin", "User" };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            var users = new[]
            {
                new { Email = "admin1@booker.com", Password = "a123", Role = "Admin" },
                new { Email = "admin2@booker.com", Password = "a123", Role = "Admin" },
                new { Email = "user1@booker.com", Password = "u123", Role = "User" },
                new { Email = "user2@booker.com", Password = "u123", Role = "User" }
            };

            foreach (var userData in users)
            {
                var user = await userManager.FindByEmailAsync(userData.Email);
                if (user == null)
                {
                    user = new User
                    {
                        UserName = userData.Email,
                        Email = userData.Email,
                        EmailConfirmed = true,
                        FullName = userData.Email.Split('@')[0]
                    };

                    var result = await userManager.CreateAsync(user, userData.Password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, userData.Role);
                    }
                }
            }
        }
    }
}