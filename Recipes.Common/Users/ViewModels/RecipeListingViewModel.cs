using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Common.Users.ViewModels
{
    public class RecipeListingViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<UserFavourites> UsersFavourited { get; set; }

        public ICollection<Rating> Ratings { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
