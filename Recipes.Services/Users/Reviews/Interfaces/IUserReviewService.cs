using Recipes.Common.Users.BindingModels;
using Recipes.Common.Users.ViewModels;
using Recipes.Models;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Users.Reviews.Interfaces
{
    public interface IUserReviewService : IUserService
    {
        Review CreateReview(string content, int recipeId, string userId);

        ReviewDeletionBindingModel GetReviewDeletionModel(Review review);

        Review GetReview(int id);

        IEnumerable<Review> GetReviewsForRecipe(int id);

        bool ReviewAlreadyExists(int recipeId, string userId);

        IEnumerable<Review> GetUserReviews(string userId);

        void DeleteReview(int id);
    }
}
