using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Common.Admin.BindingModels;
using Recipes.Constants;
using Recipes.Services.Admin.Recipes.Interfaces;

namespace Recipes.Web.Areas.Admin.Controllers
{
    public class RecipesController : AdminController
    {
        private readonly IAdminRecipeService adminRecipeService;

        public RecipesController(IAdminRecipeService adminRecipeService)
        {
            this.adminRecipeService = adminRecipeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = this.adminRecipeService.GetAllRecipes();

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = this.adminRecipeService.GetRecipeDeletionModel(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(RecipeDeletionBindingModel model)
        {
            this.adminRecipeService.DeleteRecipe(model);

            return RedirectToAction(AppConstants.IndexRedirect);
        }
    }
}