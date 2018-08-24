using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Common.Admin.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }
    }
}
