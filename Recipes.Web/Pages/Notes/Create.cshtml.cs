using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Constants;
using Recipes.Services.Users.Notes.Intefaces;
using Recipes.Services.Users.Recipes.Interfaces;

namespace Recipes.Web.Pages.Notes
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly IUserNotesService notesService;
        private readonly IUserRecipeService recipeService;

        public CreateModel(IUserNotesService notesService, IUserRecipeService recipeService)
        {
            this.notesService = notesService;
            this.recipeService = recipeService;
        }

        [BindProperty]
        [Required]
        [Display(Name = AppConstants.NoteContentDisplayName)]
        public string NoteContent { get; set; }

        public int RecipeId { get; set; }

        public string RecipeTitle { get; set; }

        public IActionResult OnGet(int id)
        {
            var recipe = this.recipeService.GetRecipe(id);

            if (recipe == null)
            {
                return NotFound();
            }

            var userId = this.notesService.GetCurrentUserId(this.User);

            if (this.notesService.NoteAlreadyExists(recipe.Id, userId))
            {
                return Redirect(AppConstants.HomeIndexRedirect);
            }

            this.RecipeId = recipe.Id;
            this.RecipeTitle = recipe.Title;

            return this.Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return this.Page();
            }

            var userId = this.notesService.GetCurrentUserId(this.User);

            var note = this.notesService.CreateNote(this.NoteContent, userId, id);

            return RedirectToPage(AppConstants.NotesIndexRedirect, new { id = note.Id});
        }
    }
}