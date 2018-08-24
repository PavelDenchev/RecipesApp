using Microsoft.AspNetCore.Mvc;
using Recipes.Common.Admin.BindingModels;
using Recipes.Constants;
using Recipes.Services.Admin.Reviews.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Web.Areas.Admin.Controllers
{
    public class ReviewsController : AdminController
    {
        private readonly IAdminReviewService adminReviewService;

        public ReviewsController(IAdminReviewService adminReviewService)
        {
            this.adminReviewService = adminReviewService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = this.adminReviewService.GetAllReviews();

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = this.adminReviewService.GetReviewDeletionModel(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(ReviewDeletionBindingModel model)
        {
            this.adminReviewService.DeleteReview(model);

            return RedirectToAction(AppConstants.IndexRedirect);
        }
    }
}
