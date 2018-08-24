using System;
using System.Collections.Generic;
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
    public class DetailsModel : PageModel
    {
        private readonly IUserNotesService notesService;

        public DetailsModel(IUserNotesService notesService)
        {
            this.notesService = notesService;
        }

        public string NoteContent { get; set; }

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

            this.NoteContent = note.Content;
            this.RecipeTitle = note.Recipe.Title;

            return this.Page();
        }
    }
}