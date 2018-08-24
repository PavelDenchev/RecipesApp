using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Recipes.Common.Admin.BindingModels;
using Recipes.Common.Admin.ViewModels;
using Recipes.Data;
using Recipes.Models;
using Recipes.Services.Admin.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Admin.Users
{
    public class AdminUserService : BaseService, IAdminUserService
    {
        public AdminUserService(RecipesDbContext context, IMapper mapper, UserManager<User> userManager) : base(context, mapper, userManager)
        {
        }

        public async Task<IEnumerable<UserViewModel>> GetUsersAsync()
        {
            var admins = await this.UserManager.GetUsersInRoleAsync("Administrator");

            var regularUsers = new List<User>();

            foreach (var u in this.UserManager.Users)
            {
                if (!admins.Contains(u))
                {
                    regularUsers.Add(u);
                }
            }

            var model = this.Mapper.Map<IEnumerable<UserViewModel>>(regularUsers);

            return model;
        }

        public UserViewModel GetUserModel(string id)
        {
            var user = this.Context.Users.Find(id);

            if (user == null)
            {
                return null;
            }

            var model = this.Mapper.Map<UserViewModel>(user);
            return model;
        }

        public void BanUser(UserBanningBindingModel model)
        {
            var user = this.Mapper.Map<User>(model);
            var dbUser = this.Context.Users.Find(model.Id);
            dbUser.LockoutEnd = DateTimeOffset.MaxValue;
            this.Context.SaveChanges();
        }

        public void UnbanUser(string id)
        {
            var dbUser = this.Context.Users.Find(id);

            if (dbUser == null)
            {
                return;
            }

            dbUser.LockoutEnd = null;
            this.Context.SaveChanges();
        }
    }
}
