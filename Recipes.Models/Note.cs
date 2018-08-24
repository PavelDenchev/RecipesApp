using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Recipes.Models
{
    public class Note
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}
