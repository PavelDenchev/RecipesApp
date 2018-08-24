using Recipes.Common.Admin.BindingModels;
using Recipes.Common.Admin.ViewModels;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Services.Admin.Recipes.Interfaces
{
    public interface IAdminRecipeService
    {
        IEnumerable<RecipeViewModel> GetAllRecipes();

        RecipeDeletionBindingModel GetRecipeDeletionModel(int id);

        void DeleteRecipe(RecipeDeletionBindingModel model);
    }
}
