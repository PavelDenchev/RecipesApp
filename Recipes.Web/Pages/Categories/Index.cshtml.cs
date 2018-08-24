using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Recipes.Constants;
using Recipes.Services.Users.Categories.Interfaces;

namespace Recipes.Web.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly IUserCategoryService categoryService;

        public IndexModel(IUserCategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IEnumerable<SelectListItem> Categories { get; set; }

        [BindProperty]
        [Display(Name = AppConstants.CategoryDisplayName)]
        public int CategoryId { get; set; }

        public void OnGet()
        {
            var categories = this.categoryService.GetAllCategories();

            this.Categories = categories.Select(cs => new SelectListItem()
            {
                Text = cs.Name,
                Value = cs.Id.ToString()
            }).ToList();
        }

        public IActionResult OnPost()
        {
            return RedirectToPage(AppConstants.CategoriesResultsRedirect, new { id = this.CategoryId});
        }
    }
}
