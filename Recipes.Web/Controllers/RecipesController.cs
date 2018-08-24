using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipes.Common.Users.BindingModels;
using Recipes.Common.Users.ViewModels;
using Recipes.Constants;
using Recipes.Services.Users.Recipes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Recipes.Web.Controllers
{
    public class RecipesController : Controller
    {
        private readonly IUserRecipeService recipeService;

        public RecipesController(IUserRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(RecipeCreationBindingModel model)
        {
            if (this.recipeService.TitleExists(model.Title))
            {
                ModelState.AddModelError(AppConstants.TitleModelErrorKey, AppConstants.TitleExistsErrorMessage);
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            var userId = this.recipeService.GetCurrentUserId(this.User);

            this.recipeService.CreateRecipe(model, userId);

            return RedirectToPage(AppConstants.RecipesIndexRedirect);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Favourite(int id)
        {
            var userId = this.recipeService.GetCurrentUserId(this.User);
            this.recipeService.FavouriteRecipe(id, userId);

            return RedirectToPage(AppConstants.UsersFavouritesRedirect);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Unfavourite(int id)
        {
            var userId = this.recipeService.GetCurrentUserId(this.User);

            this.recipeService.UnfavouriteRecipe(id, userId);

            return RedirectToPage(AppConstants.UsersFavouritesRedirect);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Delete(int id)
        {
            var recipe = this.recipeService.GetRecipe(id);

            if (recipe == null)
            {
                return NotFound();
            }

            var userId = this.recipeService.GetCurrentUserId(this.User);

            if (userId != recipe.UserId)
            {
                return Redirect(AppConstants.HomeIndexRedirect);
            }

            var model = this.recipeService.GetRecipeDeletionModel(recipe);

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(ReviewDeletionBindingModel model)
        {
            this.recipeService.DeleteRecipe(model.Id);

            return RedirectToPage(AppConstants.UsersRecipesRedirect);
        }
    }
}
