using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Recipes.Common.Admin.BindingModels;
using Recipes.Common.Admin.ViewModels;
using Recipes.Data;
using Recipes.Models;
using Recipes.Services.Admin.Reviews.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipes.Services.Admin.Reviews
{
    public class AdminReviewService : BaseService, IAdminReviewService
    {
        public AdminReviewService(RecipesDbContext context, IMapper mapper, UserManager<User> userManager) : base(context, mapper, userManager)
        {
        }

        public void DeleteReview(ReviewDeletionBindingModel model)
        {
            var review = this.Context.Reviews.Find(model.Id);

            this.Context.Reviews.Remove(review);
            this.Context.SaveChanges();
        }

        public IEnumerable<ReviewViewModel> GetAllReviews()
        {
            var reviews = this.Context.Reviews.Include(r => r.Author).Include(r => r.Recipe).ToList();

            var models = new List<ReviewViewModel>();

            foreach (var review in reviews)
            {
                var model = new ReviewViewModel()
                {
                    Id = review.Id,
                    UserName = review.Author.UserName,
                    Title = review.Recipe.Title
                };

                models.Add(model);
            }

            return models;
        }

        public ReviewDeletionBindingModel GetReviewDeletionModel(int id)
        {
            var review = this.Context.Reviews.Include(r => r.Author).Include(r => r.Recipe).FirstOrDefault(r => r.Id == id);

            var model = new ReviewDeletionBindingModel()
            {
                Id = review.Id,
                UserName = review.Author.UserName,
                Title = review.Recipe.Title
            };

            return model;
        }
    }
}
