using Recipes.Constants;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        [MinLength(AppConstants.ReviewContentMinLength)]
        public string Content { get; set; }

        public string UserId { get; set; }

        public User Author { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}