using Recipes.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Recipes.Common.Admin.BindingModels
{
    public class CategoryCreationBindingModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(AppConstants.NameMinLength, ErrorMessage = AppConstants.NameMinLengthErrorMessage)]
        [MaxLength(AppConstants.NameMaxLength, ErrorMessage = AppConstants.NameMaxLengthErrorMessage)]
        public string Name { get; set; }
    }
}
