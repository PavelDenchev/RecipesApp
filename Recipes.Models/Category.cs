using Recipes.Constants;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Models
{
    public class Category
    {
        public Category()
        {
            this.Recipies = new List<Recipe>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(AppConstants.NameMinLength)]
        [MaxLength(AppConstants.NameMaxLength)]
        public string Name { get; set; }

        public ICollection<Recipe> Recipies { get; set; }
    }
}