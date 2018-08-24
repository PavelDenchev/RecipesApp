using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Models;
using Recipes.Services.Users.Recipes.Interfaces;
using Recipes.Services.Users.Reviews.Interfaces;

namespace Recipes.Web.Pages.Reviews
{
    public class AllModel : PageModel
    {
        private readonly IUserReviewService reviewService;
        private readonly IUserRecipeService recipeService;

        public AllModel(IUserReviewService reviewService, IUserRecipeService recipeService)
        {
            this.reviewService = reviewService;
            this.recipeService = recipeService;
        }

        public IEnumerable<Review> Reviews { get; set; }

        public string RecipeTitle { get; set; }

        public IActionResult OnGet(int id)
        {
            var recipe = this.recipeService.GetRecipe(id);

            if (recipe == null)
            {
                return NotFound();
            }

            this.RecipeTitle = recipe.Title;

            var reviews = this.reviewService.GetReviewsForRecipe(id);

            this.Reviews = reviews;

            return this.Page();
        }
    }
}