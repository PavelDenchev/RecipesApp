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
    public class RecipesModel : PageModel
    {
        private readonly IUserRecipeService recipeService;

        public RecipesModel(IUserRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        public IEnumerable<RecipeListingViewModel> Recipes { get; set; }

        public void OnGet()
        {
            var userId = this.recipeService.GetCurrentUserId(this.User);

            var recipes = this.recipeService.GetUserRecipes(userId);

            this.Recipes = recipes;
        }
    }
}