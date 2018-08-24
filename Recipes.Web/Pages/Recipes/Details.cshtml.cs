using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipes.Models;
using Recipes.Services.Users.Recipes.Interfaces;

namespace Recipes.Web.Pages.Recipes
{
    public class DetailsModel : PageModel
    {
        private readonly IUserRecipeService recipeService;

        public DetailsModel(IUserRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Instructions { get; set; }

        public double AverageRating { get; set; }

        public IEnumerable<UserFavourites> UserFavourites { get; set; }

        public IEnumerable<Rating> Ratings { get; set; }

        public IEnumerable<Review> Reviews { get; set; }

        public IEnumerable<Note> Notes { get; set; }

        public string CurrentUserId { get; set; }

        public IActionResult OnGet(int id)
        {
            var recipe = this.recipeService.GetRecipe(id);

            if (recipe == null)
            {
                return NotFound();
            }

            this.CurrentUserId = this.recipeService.GetCurrentUserId(this.User);

            this.Id = recipe.Id;
            this.Title = recipe.Title;
            this.Author = recipe.User.UserName;
            this.Instructions = recipe.Instructions;
            this.AverageRating = recipe.AverageRating;
            this.UserFavourites = recipe.UsersFavourited;
            this.Reviews = recipe.Reviews;
            this.Ratings = recipe.Ratings;
            this.Notes = recipe.Notes;

            return this.Page();
        }
    }
}