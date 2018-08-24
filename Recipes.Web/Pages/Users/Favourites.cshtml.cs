using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Common.Users.ViewModels;
using Recipes.Services.Users.Recipes.Interfaces;

namespace Recipes.Web.Pages.Users
{
    [Authorize]
    public class FavouritesModel : PageModel
    {
        private readonly IUserRecipeService recipeService;

        public FavouritesModel(IUserRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        public IEnumerable<RecipeListingViewModel> Recipes { get; set; }

        public string CurrentUserId { get; set; }

        public void OnGet()
        {
            var userId = this.recipeService.GetCurrentUserId(this.User);

            var favouriteRecipes = this.recipeService.GetFavouriteRecipes(userId);

            this.CurrentUserId = userId;

            this.Recipes = favouriteRecipes;
        }
    }
}