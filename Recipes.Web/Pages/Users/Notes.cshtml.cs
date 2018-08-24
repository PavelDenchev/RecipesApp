using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Models;
using Recipes.Services.Users.Notes.Intefaces;
using Recipes.Services.Users.Recipes.Interfaces;

namespace Recipes.Web.Pages.Users
{
    public class NotesModel : PageModel
    {
        private readonly IUserNotesService notesService;

        public NotesModel(IUserNotesService notesService)
        {
            this.notesService = notesService;
        }

        public IEnumerable<Note> Notes { get; set; }

        public void OnGet()
        {
            var userId = this.notesService.GetCurrentUserId(this.User);

            var notes = this.notesService.GetUserNotes(userId);

            this.Notes = notes;
        }
    }
}