using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Recipes.Services.Interfaces
{
    public interface IUserService
    {
        string GetCurrentUserId(ClaimsPrincipal user);
    }
}
