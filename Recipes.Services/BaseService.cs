using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Recipes.Data;
using Recipes.Models;
using System;
using System.Security.Claims;

namespace Recipes.Services
{
    public abstract class BaseService
    {
        protected BaseService(RecipesDbContext context, IMapper mapper, UserManager<User> userManager)
        {
            this.Context = context;
            this.Mapper = mapper;
            this.UserManager = userManager;
        }

        protected RecipesDbContext Context { get; private set; }

        protected UserManager<User> UserManager { get; private set; } 

        protected IMapper Mapper { get; private set; }

        public string GetCurrentUserId(ClaimsPrincipal user)
        {
            var userId = this.UserManager.GetUserId(user);
            return userId;
        }
    }
}
