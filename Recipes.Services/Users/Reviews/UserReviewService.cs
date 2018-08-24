using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Recipes.Common.Users.BindingModels;
using Recipes.Common.Users.ViewModels;
using Recipes.Data;
using Recipes.Models;
using Recipes.Services.Users.Reviews.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Users.Reviews
{
    public class UserReviewService : BaseService, IUserReviewService
    {
        public UserReviewService(RecipesDbContext context, IMapper mapper, UserManager<User> userManager) : base(context, mapper, userManager)
        {
        }

        public Review CreateReview(string content, int recipeId, string userId)
        {
            var review = new Review()
            {
                Content = content,
                UserId = userId,
                RecipeId = recipeId
            };

            this.Context.Reviews.Add(review);
            this.Context.SaveChanges();

            return review;
        }

        public void DeleteReview(int id)
        {
            var review = this.GetReview(id);

            if (review == null)
            {
                return;
            }

            this.Context.Reviews.Remove(review);
            this.Context.SaveChanges();
        }

        public Review GetReview(int id)
        {
            var review = this.Context.Reviews.Include(r => r.Recipe).Include(r => r.Author).FirstOrDefault(r => r.Id == id);
            if (review == null)
            {
                return null;
            }

            return review;
        }

        public ReviewDeletionBindingModel GetReviewDeletionModel(Review review)
        {
            var reviewModel = this.Mapper.Map<ReviewDeletionBindingModel>(review);
            reviewModel.RecipeTitle = review.Recipe.Title;

            return reviewModel;
        }

        public IEnumerable<Review> GetReviewsForRecipe(int id)
        {
            var reviews = this.Context.Reviews.Include(r => r.Recipe).Include(r => r.Author).Where(r => r.RecipeId == id).ToList();

            return reviews;
        }

        public IEnumerable<Review> GetUserReviews(string userId)
        {
            var reviews = this.Context.Reviews.Include(r => r.Recipe).Where(r => r.UserId == userId);

            return reviews;
        }


        public bool ReviewAlreadyExists(int recipeId, string userId)
        {
            if (this.Context.Reviews.Any(r => r.RecipeId == recipeId && r.UserId == userId))
            {
                return true;
            }

            return false;
        }
    }
}
