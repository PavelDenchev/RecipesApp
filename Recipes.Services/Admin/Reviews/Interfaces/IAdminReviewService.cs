using Recipes.Common.Admin.BindingModels;
using Recipes.Common.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Services.Admin.Reviews.Interfaces
{
    public interface IAdminReviewService
    {
        IEnumerable<ReviewViewModel> GetAllReviews();

        ReviewDeletionBindingModel GetReviewDeletionModel(int id);

        void DeleteReview(ReviewDeletionBindingModel model);
    }
}
