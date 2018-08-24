using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Recipes.Data;
using Recipes.Models;
using Recipes.Services.Users.Notes.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipes.Services.Users.Notes
{
    public class UserNotesService : BaseService, IUserNotesService
    {
        public UserNotesService(RecipesDbContext context, IMapper mapper, UserManager<User> userManager) : base(context, mapper, userManager)
        {
        }

        public Note CreateNote(string content, string userId, int recipeId)
        {
            var note = new Note()
            {
                Content = content,
                UserId = userId,
                RecipeId = recipeId
            };

            this.Context.Notes.Add(note);
            this.Context.SaveChanges();

            return note;
        }

        public void DeleteNote(int id)
        {
            var note = this.GetNote(id);

            this.Context.Notes.Remove(note);
            this.Context.SaveChanges();
        }

        public Note GetNote(int id)
        {
            var note = this.Context.Notes.Include(n => n.Recipe).FirstOrDefault(n => n.Id == id);

            return note;
        }

        public IEnumerable<Note> GetUserNotes(string userId)
        {
            var notes = this.Context.Notes.Include(n => n.Recipe).Where(n => n.UserId == userId).ToList();
            return notes;
        }

        public bool NoteAlreadyExists(int recipeId, string userId)
        {
            if (this.Context.Notes.Any(n => n.RecipeId == recipeId && n.UserId == userId))
            {
                return true;
            }

            return false;
        }
    }
}
