using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Constants;
using Recipes.Models;
using Recipes.Services.Users.Recipes.Interfaces;

namespace Recipes.Web.Pages.Recipes
{
    [Authorize]
    public class RateModel : PageModel
    {
        private readonly IUserRecipeService recipeService;

        public RateModel(IUserRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        [BindProperty]
        [Required]
        [Range(AppConstants.RatingMinValue, AppConstants.RatingMaxValue)]
        [Display(Name = AppConstants.RatingValueDisplayName)]
        public int Value { get; set; }

        public Recipe Recipe { get; set; }

        public string UserId { get; set; }

        public IActionResult OnGet(int id)
        {
            this.Recipe = this.recipeService.GetRecipe(id);
            if (this.Recipe == null)
            {
                return NotFound();
            }
            this.UserId = this.recipeService.GetCurrentUserId(this.User);

            if (this.recipeService.RatingAlreadyExists(this.Recipe.Id, this.UserId))
            {
                return RedirectToPage(AppConstants.RecipesIndexRedirect);
            }

            return this.Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return this.Page();
            }

            this.UserId = this.recipeService.GetCurrentUserId(this.User);

            if (this.recipeService.RatingAlreadyExists(id, this.UserId))
            {
                return RedirectToPage(AppConstants.RecipesIndexRedirect);
            }

            this.recipeService.AddRating(this.Value, id, this.UserId);

            return RedirectToPage(AppConstants.RecipesIndexRedirect);
        }
    }
}