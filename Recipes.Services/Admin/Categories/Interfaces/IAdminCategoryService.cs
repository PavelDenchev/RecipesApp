using Recipes.Common.Admin.BindingModels;
using Recipes.Common.Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Admin.Categories.Interfaces
{
    public interface IAdminCategoryService
    {
        Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync();

        Task AddCategoryAsync(CategoryCreationBindingModel model);

        Task DeleteCategoryAsync(CategoryDeletionBindingModel model);

        CategoryViewModel GetCategoryViewModel(int id);

        CategoryDeletionBindingModel GetCategoryDeletionModel(int id);

        bool NameExits(string name);
    }
}
