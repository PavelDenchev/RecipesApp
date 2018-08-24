using AutoMapper;
using Recipes.Common.Admin.BindingModels;
using Recipes.Common.Admin.ViewModels;
using Recipes.Common.Users.BindingModels;
using Recipes.Common.Users.ViewModels;
using Recipes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Web.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<CategoryCreationBindingModel, Category>();
            this.CreateMap<CategoryDeletionBindingModel, Category>();
            this.CreateMap<CategoryViewModel, Category>();

            this.CreateMap<UserBanningBindingModel, User>();

            this.CreateMap<RecipeViewModel, Recipe>();

            this.CreateMap<RecipeCreationBindingModel, Recipe>();
            this.CreateMap<Recipes.Common.Admin.BindingModels.RecipeDeletionBindingModel, Recipe>();
            this.CreateMap<Recipes.Common.Users.BindingModels.RecipeDeletionBindingModel, Recipe>();
            this.CreateMap<RecipeDetailsViewModel, Recipe>();
            this.CreateMap<RecipeListingViewModel, Recipe>();

            this.CreateMap<Recipes.Common.Users.BindingModels.ReviewDeletionBindingModel, Review>();
        }
    }
}
