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
using Recipes.Services.Users.Reviews.Interfaces;

namespace Recipes.Web.Pages.Reviews
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly IUserReviewService reviewService;
        private readonly IUserRecipeService recipeService;

        public CreateModel(IUserReviewService reviewService, IUserRecipeService recipeService)
        {
            this.reviewService = reviewService;
            this.recipeService = recipeService;
        }

        [BindProperty]
        [Required]
        [MinLength(AppConstants.ReviewContentMinLength, ErrorMessage = AppConstants.ReviewContentMinLengthErrorMessage)]
        [Display(Name = AppConstants.ReviewContentDisplayName)]
        public string ReviewContent { get; set; }

        public string Title { get; set; }

        public int RecipeId { get; set; }

        public IActionResult OnGet(int id)
        {
            var recipe = this.recipeService.GetRecipe(id);

            if (recipe == null)
            {
                return NotFound();
            }

            this.RecipeId = recipe.Id;
            this.Title = recipe.Title;

            var userId = this.reviewService.GetCurrentUserId(this.User);

            if (this.reviewService.ReviewAlreadyExists(this.RecipeId, userId))
            {
                return Redirect(AppConstants.HomeIndexRedirect);
            }

            return this.Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return this.Page();
            }

            var userId = this.reviewService.GetCurrentUserId(this.User);

            if (this.reviewService.ReviewAlreadyExists(id, userId))
            {
                return Redirect(AppConstants.HomeIndexRedirect);
            }

            var review = this.reviewService.CreateReview(this.ReviewContent, id, userId);

            return RedirectToPage(AppConstants.ReviewsDetailsRedirect, new { id = review.Id });
        }
    }
}