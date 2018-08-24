using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Recipes.Common.Users.BindingModels;
using Recipes.Common.Users.ViewModels;
using Recipes.Data;
using Recipes.Models;
using Recipes.Services.Users.Recipes.Interfaces;

namespace Recipes.Services.Users.Recipes
{
    public class UserRecipeService : BaseService, IUserRecipeService
    {
        public UserRecipeService(RecipesDbContext context, IMapper mapper, UserManager<User> userManager) : base(context, mapper, userManager)
        {
        }

        public void AddRating(int value, int recipeId, string userId)
        {
            var recipe = this.GetRecipe(recipeId);

            if (recipe == null)
            {
                return;
            }

            if (this.Context.Ratings.Any(r => r.RecipeId == recipeId && r.UserId == userId))
            {
                return;
            }
            var rating = new Rating()
            {
                Value = value,
                RecipeId = recipeId,
                UserId = userId
            };
            this.Context.Ratings.Add(rating);
            this.Context.SaveChanges();

            var totalRating = 0;

            foreach (var r in recipe.Ratings)
            {
                totalRating += r.Value;
            }

            double averageRating = 0;

            if (recipe.Ratings.Count > 0)
            {
                averageRating = totalRating / recipe.Ratings.Count;
            }

            recipe.AverageRating = averageRating;

            this.Context.SaveChanges();
        }

        public void CreateRecipe(RecipeCreationBindingModel model, string userId)
        {
            model.UserId = userId;
            var recipe = this.Mapper.Map<Recipe>(model);
            this.Context.Recipes.Add(recipe);
            this.Context.SaveChanges();
        }

        public void FavouriteRecipe(int id, string userId)
        {

            if (this.GetRecipe(id) == null)
            {
                return;
            }

            if (this.Context.UserFavourites.Any(uf => uf.RecipeId == id && uf.UserId == userId))
            {
                return;
            }

            var userFavourite = new UserFavourites()
            {
                UserId = userId,
                RecipeId = id
            };
            this.Context.UserFavourites.Add(userFavourite);
            this.Context.SaveChanges();
        }

        public void UnfavouriteRecipe(int id, string userId)
        {
            if (this.GetRecipe(id) == null)
            {
                return;
            }

            var userFavourite = this.Context.UserFavourites.FirstOrDefault(uf => uf.RecipeId == id && uf.UserId == userId);
            if (userFavourite == null)
            {
                return;
            }

            this.Context.UserFavourites.Remove(userFavourite);
            this.Context.SaveChanges();
        }

        public Recipe GetRecipe(int id)
        {
            var recipe = this.Context.Recipes.Include(r => r.User).Include(r => r.UsersFavourited).Include(r => r.Ratings).Include(r => r.Reviews).Include(r => r.Notes).FirstOrDefault(r => r.Id == id);
            return recipe;
        }

        public IEnumerable<RecipeListingViewModel> GetAllRecipes()
        {
            var recipes = this.Context.Recipes.Include(r => r.UsersFavourited).Include(r => r.Ratings).Include(r => r.Reviews).Include(r => r.Notes).OrderBy(r => r.Title).ToList();
            var modelRecipes = this.Mapper.Map<IEnumerable<RecipeListingViewModel>>(recipes);
            return modelRecipes;
        }

        public bool TitleExists(string title)
        {
            foreach (var recipe in this.Context.Recipes)
            {
                if (recipe.Title == title)
                {
                    return true;
                }
            }

            return false;
        }

        public bool RatingAlreadyExists(int recipeId, string userId)
        {
            if (this.Context.Ratings.Any(r => r.RecipeId == recipeId && r.UserId == userId))
            {
                return true;
            }

            return false;
        }

        public IEnumerable<RecipeListingViewModel> SearchForRecipes(string searchTerm)
        {
            var foundRecipes = this.Context.Recipes.Include(r => r.UsersFavourited).Include(r => r.Ratings).Include(r => r.Reviews).Include(r => r.Notes).Where(r => r.Title.ToLower() == searchTerm.ToLower()).OrderBy(r => r.Title).ToList();

            var modelRecipes = this.Mapper.Map<IEnumerable<RecipeListingViewModel>>(foundRecipes);
            return modelRecipes;
        }

        public IEnumerable<RecipeListingViewModel> GetFavouriteRecipes(string userId)
        {
            var favourites = this.Context.UserFavourites.Include(uf => uf.Recipe).Where(uf => uf.UserId == userId).Select(uf => uf.Recipe).Include(r => r.Ratings).Include(r => r.Reviews).Include(r => r.Notes).OrderBy(r => r.Title).ToList();

            var modelRecipes = this.Mapper.Map<IEnumerable<RecipeListingViewModel>>(favourites);
            return modelRecipes;
        }

        public IEnumerable<RecipeListingViewModel> GetUserRecipes(string userId)
        {
            var recipes = this.Context.Recipes.Include(r => r.UsersFavourited).Include(r => r.Ratings).Include(r => r.Reviews).Include(r => r.Notes).Where(r => r.UserId == userId).OrderBy(r => r.Title).ToList();

            var modelRecipes = this.Mapper.Map<IEnumerable<RecipeListingViewModel>>(recipes);
            return modelRecipes;
        }

        public RecipeDeletionBindingModel GetRecipeDeletionModel(Recipe recipe)
        {
            var model = this.Mapper.Map<RecipeDeletionBindingModel>(recipe);
            return model;
        }

        public void DeleteRecipe(int id)
        {
            var recipe = this.GetRecipe(id);

            if (recipe == null)
            {
                return;
            }

            this.Context.Recipes.Remove(recipe);
            this.Context.SaveChanges();
        }
    }
}
