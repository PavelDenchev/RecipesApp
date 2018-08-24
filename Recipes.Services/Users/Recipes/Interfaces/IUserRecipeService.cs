using Microsoft.AspNetCore.Mvc.Rendering;
using Recipes.Common.Users.BindingModels;
using Recipes.Common.Users.ViewModels;
using Recipes.Models;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Users.Recipes.Interfaces
{
    public interface IUserRecipeService : IUserService
    {
        void CreateRecipe(RecipeCreationBindingModel model, string userId);

        bool TitleExists(string title);

        IEnumerable<RecipeListingViewModel> GetAllRecipes();

        IEnumerable<RecipeListingViewModel> SearchForRecipes(string searchTerm);

        IEnumerable<RecipeListingViewModel> GetFavouriteRecipes(string userId);

        IEnumerable<RecipeListingViewModel> GetUserRecipes(string userId);

        RecipeDeletionBindingModel GetRecipeDeletionModel(Recipe recipe);

        void FavouriteRecipe(int id, string userId);

        void UnfavouriteRecipe(int id, string userId);

        void AddRating(int value, int recipeId, string userId);

        Recipe GetRecipe(int id);

        bool RatingAlreadyExists(int recipeId, string userId);

        void DeleteRecipe(int id);
    }
}
