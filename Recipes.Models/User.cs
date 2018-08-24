using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            this.Recipes = new List<Recipe>();
            this.Reviews = new List<Review>();
            this.Ratings = new List<Rating>();
            this.FavouritedRecipes = new List<UserFavourites>();
            this.Notes = new List<Note>();
        }

        public ICollection<Recipe> Recipes { get; set; }

        public ICollection<UserFavourites> FavouritedRecipes { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Rating> Ratings { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
