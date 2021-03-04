using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EFCore5WebApp
{
    public static class Roles
    {
        public const string ViewOnlyRoleName = "View Only";
        public const string AdminRoleName = "Admin";
    }

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var webHost = CreateHostBuilder(args).Build();

            using (var scope = webHost.Services.CreateScope())
            {
                await AddAppRoles(scope.ServiceProvider);
            }

            await webHost.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static async Task CreateRoleIfNotExists(RoleManager<IdentityRole> roleManager, string roleName)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        private static async Task AssignRoleToUser(UserManager<IdentityUser> userManager, string userEmail, string roleName)
        {
            var user = await userManager.FindByEmailAsync(userEmail);

            if (userEmail != null)
            {
                await userManager.AddToRoleAsync(user, roleName);
            }
        }

        private static async Task AddAppRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string viewOnlyRoleName = Roles.ViewOnlyRoleName;
            string adminRoleName = Roles.AdminRoleName;

            await CreateRoleIfNotExists(roleManager, adminRoleName).ConfigureAwait(false);
            await CreateRoleIfNotExists(roleManager, viewOnlyRoleName).ConfigureAwait(false);

            var viewOnlyUserEmail = "viewonly@test.com";
            var adminUserEmail = "admin@test.com";

            await AssignRoleToUser(userManager, viewOnlyUserEmail, viewOnlyRoleName).ConfigureAwait(false);
            await AssignRoleToUser(userManager, adminUserEmail, adminRoleName).ConfigureAwait(false);
        }
    }
}
