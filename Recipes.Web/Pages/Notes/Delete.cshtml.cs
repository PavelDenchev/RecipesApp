using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Constants;
using Recipes.Services.Users.Notes.Intefaces;
using Recipes.Services.Users.Recipes.Interfaces;

namespace Recipes.Web.Pages.Notes
{
    public class DeleteModel : PageModel
    {
        private readonly IUserNotesService notesService;

        public DeleteModel(IUserNotesService notesService)
        {
            this.notesService = notesService;
        }

        public int Id { get; set; }

        public string RecipeTitle { get; set; }

        public IActionResult OnGet(int id)
        {
            var note = this.notesService.GetNote(id);

            if (note == null)
            {
                return NotFound();
            }

            var userId = this.notesService.GetCurrentUserId(this.User);

            if (note.UserId != userId)
            {
                return Redirect(AppConstants.HomeIndexRedirect);
            }

            this.Id = note.Id;
            this.RecipeTitle = note.Recipe.Title;

            return this.Page();
        }

        public IActionResult OnPost(int id)
        {
            this.notesService.DeleteNote(id);

            return RedirectToPage(AppConstants.UsersNotesRedirect);
        }
    }
}