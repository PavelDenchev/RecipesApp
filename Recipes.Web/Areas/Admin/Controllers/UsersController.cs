using Microsoft.AspNetCore.Mvc;
using Recipes.Common.Admin.BindingModels;
using Recipes.Common.Admin.ViewModels;
using Recipes.Constants;
using Recipes.Data;
using Recipes.Services.Admin.Users.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Web.Areas.Admin.Controllers
{
    public class UsersController : AdminController
    {
        private readonly IAdminUserService userService;

        public UsersController(IAdminUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await userService.GetUsersAsync();
            return View(model);
        }

        [HttpGet]
        public IActionResult Ban(string id)
        {
            var model = userService.GetUserModel(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Ban(UserBanningBindingModel model)
        {
            this.userService.BanUser(model);

            return RedirectToAction(AppConstants.IndexRedirect);
        }

        [HttpPost]
        public IActionResult Unban(string id)
        {
            this.userService.UnbanUser(id);

            return RedirectToAction(AppConstants.IndexRedirect);
        }
    }
}
