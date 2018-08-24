using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Common.Users.ViewModels
{
    public class RecipeDetailsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Instructions { get; set; }

        public string UserId { get; set; }

        public string Author { get; set; }

        public string CurrentUserId { get; set; }

        public ICollection<UserFavourites> UsersFavourited { get; set; }

        public ICollection<Rating> Ratings { get; set; }
    }
}
