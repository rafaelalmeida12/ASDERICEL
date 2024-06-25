using AtletaAsdericel.Models;
using Microsoft.AspNetCore.Identity;

namespace AtletaAsdericel.Helpers
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            string[] roleNames = { "Admin", "User" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    // Criar os roles e fazer o seed no banco de dados
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }

        public static async Task SeedAdminUserAsync(UserManager<Usuario> userManager, RoleManager<IdentityRole> roleManager)
        {
            // Aqui você pode criar um super usuário que irá manter o aplicativo web
            var poweruser = new Usuario
            {
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
            };

            string userPassword = "Admin@123";
            var user = await userManager.FindByEmailAsync("admin@admin.com");

            if (user == null)
            {
                var createPowerUser = await userManager.CreateAsync(poweruser, userPassword);
                if (createPowerUser.Succeeded)
                {
                    // Aqui nós ligamos o novo usuário ao role
                    await userManager.AddToRoleAsync(poweruser, "Admin");
                }
            }
        }
    }

}
