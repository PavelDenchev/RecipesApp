using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Recipes.Constants;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Web.Common
{
    public static class ApplicationBuilderExtensions
    {
        //This gets changed immediately after being added to the database
        private const string DefaultAdminPassword = AppConstants.DefaultAdminPass;

        private static readonly IdentityRole[] roles =
        {
            new IdentityRole(AppConstants.AdministratorRoleName)
        };

        public static async void SeedDatabase(this IApplicationBuilder app)
        {
            var serviceFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            var scope = serviceFactory.CreateScope();
            using (scope)
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

                foreach (var role in roles)
                {
                    if (!await roleManager.RoleExistsAsync(role.Name))
                    {
                        await roleManager.CreateAsync(role);
                    }
                }

                var user = await userManager.FindByNameAsync(AppConstants.DefaultAdminUserName);
                if (user == null)
                {
                    user = new User()
                    {
                        UserName = AppConstants.DefaultAdminUserName,
                        Email = AppConstants.DefaultAdminEmail,
                        EmailConfirmed = true
                    };

                    await userManager.CreateAsync(user, DefaultAdminPassword);
                    await userManager.AddToRoleAsync(user, roles[0].Name);
                }
            }
        }
    }
}
