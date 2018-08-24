using Microsoft.AspNetCore.Mvc;
using Recipes.Common.Admin.BindingModels;
using Recipes.Constants;
using Recipes.Services.Admin.Categories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Web.Areas.Admin.Controllers
{
    public class CategoriesController : AdminController
    {
        private readonly IAdminCategoryService categoryService;

        public CategoriesController(IAdminCategoryService cookingStyleService)
        {
            this.categoryService = cookingStyleService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var ingredients = await this.categoryService.GetCategoriesAsync();
            return View(ingredients);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreationBindingModel model)
        {
            if (this.categoryService.NameExits(model.Name))
            {
                ModelState.AddModelError(AppConstants.CategoryModelErrorKey, AppConstants.CategoryExistsErrorMessage);
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            await this.categoryService.AddCategoryAsync(model);

            return RedirectToAction(AppConstants.IndexRedirect);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = this.categoryService.GetCategoryDeletionModel(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(CategoryDeletionBindingModel model)
        {
            await this.categoryService.DeleteCategoryAsync(model);

            return RedirectToAction(AppConstants.IndexRedirect);
        }
    }
}
