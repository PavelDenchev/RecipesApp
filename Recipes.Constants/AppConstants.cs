using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Constants
{
    public static class AppConstants
    {
        public const string NameMinLengthErrorMessage = "This field must have a minimum of 3 characters";
        public const string NameMaxLengthErrorMessage = "This field must have a maximum of 30 characters";
        public const string RecipeInstructionsMinLengthErrorMessage = "The instructions must contain atleast 50 characters.";
        public const string ReviewContentMinLengthErrorMessage = "The review must be atleast 10 characters long.";
        public const string CategoryExistsErrorMessage = "Category already exists";
        public const string TitleExistsErrorMessage = "Title already exists";

        public const string TitleModelErrorKey = "Title";
        public const string CategoryModelErrorKey = "Name";
        public const string CategoryDisplayName = "Category";
        public const string NoteContentDisplayName = "Note";
        public const string RatingValueDisplayName = "Rating";
        public const string ReviewContentDisplayName = "Review";
        public const string AdministratorAreaName = "Admin";
        public const string AdministratorRoleName = "Administrator";
        public const string DefaultAdminUserName = "admin";
        public const string DefaultAdminEmail = "admin@recipes.com";
        public const string DefaultAdminPass = "Adminpass1234";
        public const string ConnectionStringName = "RecipesApp";
        public const string FacebookAppIdKeyName = "ExternalAuthentication:Facebook:AppId";
        public const string FacebookAppSecretKeyName = "ExternalAuthentication:Facebook:AppSecret";
        public const string GoogleAppIdKeyName = "ExternalAuthentication:Google:ClientId";
        public const string GoogleAppSecretKeyName = "ExternalAuthentication:Google:ClientSecret";
        public const string EmailSettingsSectionKey = "EmailSettings";

        public const string IndexRedirect = "Index";
        public const string RecipesIndexRedirect = "/Recipes/Index";
        public const string UsersFavouritesRedirect = "/Users/Favourites";
        public const string UsersRecipesRedirect = "/Users/Recipes";
        public const string UsersReviewsRedirect = "/Users/Reviews";
        public const string UsersNotesRedirect = "/Users/Notes";
        public const string HomeIndexRedirect = "/Home/Index";
        public const string CategoriesResultsRedirect = "/Categories/Results";
        public const string NotesIndexRedirect = "/Notes/Details";
        public const string ReviewsDetailsRedirect = "/Reviews/Details";
        public const string HomeErrorRoute = "/Home/Error";

        public const string AreaMapRouteName = "area";
        public const string AreaMapRouteTemplate = "{area:exists}/{controller=Home}/{action=Index}/{id?}";
        public const string DefaultMapRouteName = "default";
        public const string DefaultMapRouteTemplate = "{controller=Home}/{action=Index}/{id?}";

        public const int NameMinLength = 3;
        public const int NameMaxLength = 30;
        public const int RatingMinValue = 1;
        public const int RatingMaxValue = 5;
        public const int RecipeInstructionsMinLength = 50;
        public const int ReviewContentMinLength = 10;
    }
}
