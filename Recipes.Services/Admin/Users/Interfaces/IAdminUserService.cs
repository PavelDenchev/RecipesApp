using Recipes.Common.Admin.BindingModels;
using Recipes.Common.Admin.ViewModels;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Admin.Users.Interfaces
{
    public interface IAdminUserService
    {
        Task<IEnumerable<UserViewModel>> GetUsersAsync();

        UserViewModel GetUserModel(string id);

        void BanUser(UserBanningBindingModel model);

        void UnbanUser(string id);
    }
}
