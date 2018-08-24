using Recipes.Common.Users.ViewModels;
using Recipes.Models;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Services.Users.Categories.Interfaces
{
    public interface IUserCategoryService : IUserService
    {
        IEnumerable<Category> GetAllCategories();
        IEnumerable<RecipeListingViewModel> GetRecipesFromCategory(int id);
        Category GetCategory(int id);
    }
}
