#pragma checksum "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Reviews\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3438d60c5dec653b53bb7757d009a466690cef71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Reviews_Details), @"mvc.1.0.razor-page", @"/Pages/Reviews/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Reviews/Details.cshtml", typeof(AspNetCore.Pages_Reviews_Details), @"{id}")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\_ViewImports.cshtml"
using Recipes.Web;

#line default
#line hidden
#line 2 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\_ViewImports.cshtml"
using Recipes.Models;

#line default
#line hidden
#line 3 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\_ViewImports.cshtml"
using Recipes.Common.Admin.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\_ViewImports.cshtml"
using Recipes.Common.Users.BindingModels;

#line default
#line hidden
#line 5 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\_ViewImports.cshtml"
using Recipes.Common.Users.ViewModels;

#line default
#line hidden
#line 6 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\_ViewImports.cshtml"
using Recipes.Web.Helpers;

#line default
#line hidden
#line 7 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\_ViewImports.cshtml"
using Recipes.Data;

#line default
#line hidden
#line 8 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\_ViewImports.cshtml"
using Recipes.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3438d60c5dec653b53bb7757d009a466690cef71", @"/Pages/Reviews/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a819cbbcf5080305221e1ee8f1358b9465f75e67", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Reviews_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Reviews\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(104, 17, true);
            WriteLiteral("\r\n<h2>Review for ");
            EndContext();
            BeginContext(122, 17, false);
#line 7 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Reviews\Details.cshtml"
          Write(Model.RecipeTitle);

#line default
#line hidden
            EndContext();
            BeginContext(139, 14, true);
            WriteLiteral("</h2>\r\n<h5>by ");
            EndContext();
            BeginContext(154, 12, false);
#line 8 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Reviews\Details.cshtml"
  Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(166, 62, true);
            WriteLiteral("</h5>\r\n\r\n<div class=\"container break-text\">\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(229, 19, false);
#line 12 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Reviews\Details.cshtml"
   Write(Model.ReviewContent);

#line default
#line hidden
            EndContext();
            BeginContext(248, 18, true);
            WriteLiteral("\r\n    </p>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipes.Web.Pages.Reviews.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Recipes.Web.Pages.Reviews.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Recipes.Web.Pages.Reviews.DetailsModel>)PageContext?.ViewData;
        public Recipes.Web.Pages.Reviews.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
