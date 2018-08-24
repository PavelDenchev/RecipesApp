using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Services.Users.Reviews.Interfaces;

namespace Recipes.Web.Pages.Reviews
{
    public class DetailsModel : PageModel
    {
        private readonly IUserReviewService reviewService;

        public DetailsModel(IUserReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        public string ReviewContent { get; set; }

        public string Author { get; set; }

        public string RecipeTitle { get; set; }

        public IActionResult OnGet(int id)
        {
            var review = this.reviewService.GetReview(id);

            if (review == null)
            {
                return NotFound();
            }

            this.ReviewContent = review.Content;
            this.Author = review.Author.UserName;
            this.RecipeTitle = review.Recipe.Title;

            return this.Page();
        }
    }
}