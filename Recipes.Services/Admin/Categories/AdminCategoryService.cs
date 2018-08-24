using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Recipes.Common.Admin.BindingModels;
using Recipes.Common.Admin.ViewModels;
using Recipes.Data;
using Recipes.Models;
using Recipes.Services.Admin.Categories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Services.Admin.Categories
{
    public class AdminCategoryService : BaseService, IAdminCategoryService
    {
        public AdminCategoryService(RecipesDbContext context, IMapper mapper, UserManager<User> userManager) : base(context, mapper, userManager)
        {
        }

        public async Task AddCategoryAsync(CategoryCreationBindingModel model)
        {
            var category = this.Mapper.Map<Category>(model);
            await this.Context.Categories.AddAsync(category);
            await this.Context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(CategoryDeletionBindingModel model)
        {
            var category = this.Mapper.Map<Category>(model);
            this.Context.Categories.Remove(category);
            await this.Context.SaveChangesAsync();
        }

        public CategoryViewModel GetCategoryViewModel(int id)
        {
            var category = this.Context.Categories.Find(id);

            if (category == null)
            {
                return null;
            }

            var model = this.Mapper.Map<CategoryViewModel>(category);
            return model;
        }

        public CategoryDeletionBindingModel GetCategoryDeletionModel(int id)
        {
            var category = this.Context.Categories.Find(id);

            if (category == null)
            {
                return null;
            }

            var model = this.Mapper.Map<CategoryDeletionBindingModel>(category);
            return model;
        }

        public async Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync()
        {
            var categories = await this.Context.Categories.ToListAsync();
            var modelCategories = this.Mapper.Map<IEnumerable<CategoryViewModel>>(categories);
            return modelCategories;
        }

        public bool NameExits(string name)
        {
            var categories = this.Context.Categories.ToList();

            foreach (var category in categories)
            {
                if (category.Name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
