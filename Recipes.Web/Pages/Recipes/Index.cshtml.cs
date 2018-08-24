using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Common.Users.ViewModels;
using Recipes.Models;
using Recipes.Services.Users.Recipes.Interfaces;

namespace Recipes.Web.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly IUserRecipeService recipeService;

        public IndexModel(IUserRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        public IEnumerable<RecipeListingViewModel> Recipes { get; set; }

        public string CurrentUserId { get; set; }

        public void OnGet()
        {
            this.CurrentUserId = this.recipeService.GetCurrentUserId(this.User);
            this.Recipes = recipeService.GetAllRecipes();
        }
    }
}