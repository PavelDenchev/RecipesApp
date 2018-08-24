using Microsoft.AspNetCore.Mvc.Rendering;
using Recipes.Constants;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Recipes.Common.Users.BindingModels
{
    public class RecipeCreationBindingModel
    {
        [Required]
        [MinLength(AppConstants.NameMinLength, ErrorMessage = AppConstants.NameMinLengthErrorMessage)]
        [MaxLength(AppConstants.NameMaxLength, ErrorMessage = AppConstants.NameMaxLengthErrorMessage)]
        public string Title { get; set; }

        [Required]
        [MinLength(AppConstants.RecipeInstructionsMinLength, ErrorMessage = AppConstants.RecipeInstructionsMinLengthErrorMessage)]
        public string Instructions { get; set; }

        [Display(Name = AppConstants.CategoryDisplayName)]
        public int CategoryId { get; set; }

        public string UserId { get; set; }
    }
}
