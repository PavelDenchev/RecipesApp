using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Recipes.Common.Admin.BindingModels;
using Recipes.Common.Admin.ViewModels;
using Recipes.Data;
using Recipes.Models;
using Recipes.Services.Admin.Recipes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipes.Services.Admin.Recipes
{
    public class AdminRecipeService : BaseService, IAdminRecipeService
    {
        public AdminRecipeService(RecipesDbContext context, IMapper mapper, UserManager<User> userManager) : base(context, mapper, userManager)
        {
        }

        public void DeleteRecipe(RecipeDeletionBindingModel model)
        {
            var recipe = this.Mapper.Map<Recipe>(model);

            this.Context.Recipes.Remove(recipe);
            this.Context.SaveChanges();
        }

        public IEnumerable<RecipeViewModel> GetAllRecipes()
        {
            var recipes = this.Context.Recipes.ToList();

            var model = this.Mapper.Map<IEnumerable<RecipeViewModel>>(recipes);

            return model;
        }

        public RecipeDeletionBindingModel GetRecipeDeletionModel(int id)
        {
            var recipe = this.Context.Recipes.Find(id);

            var model = this.Mapper.Map<RecipeDeletionBindingModel>(recipe);

            return model;
        }
    }
}
