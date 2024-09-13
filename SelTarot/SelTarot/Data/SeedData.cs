using Microsoft.AspNetCore.Identity;
using SelTarot.EntityLayer.Concrete;

namespace SelTarot.Data
{
    public class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole<int>("Admin"));
            }

            if (!await roleManager.RoleExistsAsync("Falcı"))
            {
                await roleManager.CreateAsync(new IdentityRole<int>("Falcı"));
            }

            var adminUser = new User
            {
                UserName = "admin",
                Email = "admin@admin.com",
                EmailConfirmed = true
            };

            if (await userManager.FindByNameAsync(adminUser.UserName) == null)
            {
                var result = await userManager.CreateAsync(adminUser, "Admin123!");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}
