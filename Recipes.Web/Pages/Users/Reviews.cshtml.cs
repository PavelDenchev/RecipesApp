using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Models;
using Recipes.Services.Users.Recipes.Interfaces;
using Recipes.Services.Users.Reviews.Interfaces;

namespace Recipes.Web.Pages.Users
{
    [Authorize]
    public class ReviewsModel : PageModel
    {
        private readonly IUserReviewService reviewService;

        public ReviewsModel(IUserReviewService reviewService)
        {
            this.reviewService = reviewService;

        }

        public IEnumerable<Review> Reviews { get; set; }

        public void OnGet()
        {
            var userId = this.reviewService.GetCurrentUserId(this.User);

            var reviews = this.reviewService.GetUserReviews(userId);

            this.Reviews = reviews;
        }
    }
}