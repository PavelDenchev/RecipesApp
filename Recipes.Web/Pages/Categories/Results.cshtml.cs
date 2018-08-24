using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Common.Users.ViewModels;
using Recipes.Services.Users.Categories.Interfaces;
using Recipes.Services.Users.Recipes.Interfaces;

namespace Recipes.Web.Pages.Categories
{
    public class ResultsModel : PageModel
    {
        private readonly IUserCategoryService categoryService;

        public ResultsModel(IUserCategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IEnumerable<RecipeListingViewModel> Recipes { get; set; }

        public string CurrentUserId { get; set; }

        public string CategoryName { get; set; }

        public IActionResult OnGet(int id)
        {
            var category = this.categoryService.GetCategory(id);

            if (category == null)
            {
                return NotFound();
            }

            this.CategoryName = category.Name;

            var recipes = this.categoryService.GetRecipesFromCategory(id);

            this.Recipes = recipes;

            this.CurrentUserId = this.categoryService.GetCurrentUserId(this.User);

            return this.Page();
        }
    }
}