using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Recipes.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Web.Areas.Admin.Controllers
{
    [Area(AppConstants.AdministratorAreaName)]
    [Authorize(Roles = AppConstants.AdministratorRoleName)]
    public abstract class AdminController : Controller
    {
    }
}
