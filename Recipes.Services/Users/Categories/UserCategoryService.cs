using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Recipes.Common.Users.ViewModels;
using Recipes.Data;
using Recipes.Models;
using Recipes.Services.Users.Categories.Interfaces;

namespace Recipes.Services.Users.Categories
{
    public class UserCategoryService : BaseService, IUserCategoryService
    {
        public UserCategoryService(RecipesDbContext context, IMapper mapper, UserManager<User> userManager) : base(context, mapper, userManager)
        {
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = this.Context.Categories.ToList();
            return categories;
        }

        public Category GetCategory(int id)
        {
            var category = this.Context.Categories.Find(id);
            return category;
        }

        public IEnumerable<RecipeListingViewModel> GetRecipesFromCategory(int id)
        {
            var recipes = this.Context.Recipes.Include(r => r.UsersFavourited).Include(r => r.Ratings).Include(r => r.Reviews).Include(r => r.Notes).Where(r => r.CategoryId == id).OrderBy(r => r.Title).ToList();
            var modelRecipies = this.Mapper.Map<IEnumerable<RecipeListingViewModel>>(recipes);
            return modelRecipies;
        }
    }
}
