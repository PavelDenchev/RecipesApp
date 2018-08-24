using Recipes.Constants;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Models
{
    public class Rating
    {
        public int Id { get; set; }

        [Range(AppConstants.RatingMinValue, AppConstants.RatingMaxValue)]
        public int Value { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}