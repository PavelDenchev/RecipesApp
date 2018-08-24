using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Common.Users.ViewModels;
using Recipes.Services.Users.Recipes.Interfaces;

namespace Recipes.Web.Pages.Recipes
{
    public class SearchModel : PageModel
    {
        private readonly IUserRecipeService recipeService;

        public SearchModel(IUserRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public string CurrentUserId { get; set; }

        public IEnumerable<RecipeListingViewModel> RecipesFound { get; set; }

        public void OnGet()
        {
            var recipesFound = this.recipeService.SearchForRecipes(this.SearchTerm);
            this.RecipesFound = recipesFound;
            this.CurrentUserId = this.recipeService.GetCurrentUserId(this.User);
        }
    }
}