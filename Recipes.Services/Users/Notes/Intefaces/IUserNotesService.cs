using Recipes.Models;
using Recipes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Services.Users.Notes.Intefaces
{
    public interface IUserNotesService : IUserService
    {
        void DeleteNote(int id);

        bool NoteAlreadyExists(int recipeId, string userId);

        Note CreateNote(string content, string userId, int recipeId);

        Note GetNote(int id);

        IEnumerable<Note> GetUserNotes(string userId);
    }
}
