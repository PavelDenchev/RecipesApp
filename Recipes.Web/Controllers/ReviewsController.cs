using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipes.Common.Users.BindingModels;
using Recipes.Common.Users.ViewModels;
using Recipes.Constants;
using Recipes.Services.Users.Recipes.Interfaces;
using Recipes.Services.Users.Reviews.Interfaces;

namespace Recipes.Web.Controllers
{
    [Authorize]
    public class ReviewsController : Controller
    {
        private readonly IUserReviewService reviewService;

        public ReviewsController(IUserReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var review = this.reviewService.GetReview(id);

            if (review == null)
            {
                return NotFound();
            }

            var userId = this.reviewService.GetCurrentUserId(this.User);

            if (userId != review.UserId)
            {
                return Redirect(AppConstants.HomeIndexRedirect);
            }

            var model = this.reviewService.GetReviewDeletionModel(review);

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(ReviewDeletionBindingModel model)
        {
            this.reviewService.DeleteReview(model.Id);

            return RedirectToPage(AppConstants.UsersReviewsRedirect);
        }
    }
}