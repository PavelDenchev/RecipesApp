using Recipes.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Recipes.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.Ratings = new List<Rating>();
            this.Reviews = new List<Review>();
            this.UsersFavourited = new List<UserFavourites>();
            this.Notes = new List<Note>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(AppConstants.NameMinLength)]
        [MaxLength(AppConstants.NameMaxLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(AppConstants.RecipeInstructionsMinLength)]
        public string Instructions { get; set; }

        public double AverageRating { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public ICollection<Rating> Ratings { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<UserFavourites> UsersFavourited { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
