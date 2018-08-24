using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Models
{
    public class UserFavourites
    {
        public string UserId { get; set; }

        public User User { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}
