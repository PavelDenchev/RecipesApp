#pragma checksum "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53a427a4d26036aa227fe63429af30ca6376415e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared_DisplayTemplates_IndexModel), @"mvc.1.0.view", @"/Pages/Shared/DisplayTemplates/IndexModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/DisplayTemplates/IndexModel.cshtml", typeof(AspNetCore.Pages_Shared_DisplayTemplates_IndexModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a427a4d26036aa227fe63429af30ca6376415e", @"/Pages/Shared/DisplayTemplates/IndexModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a819cbbcf5080305221e1ee8f1358b9465f75e67", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_DisplayTemplates_IndexModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipes.Web.Pages.Recipes.IndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Recipes/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Reviews/All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Notes/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Recipes/Rate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Favourite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Reviews/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
 foreach (var recipe in Model.Recipes)
{

#line default
#line hidden
            BeginContext(90, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(113, 12, false);
#line 6 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
       Write(recipe.Title);

#line default
#line hidden
            EndContext();
            BeginContext(125, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(144, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b961aea04eb648f596f17da6645ffd19", async() => {
                BeginContext(227, 11, true);
                WriteLiteral("View Recipe");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 7 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
                                              WriteLiteral(recipe.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(242, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(261, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e31e1df39294f0697fbadc26bdadbd1", async() => {
                BeginContext(340, 12, true);
                WriteLiteral("View Reviews");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 8 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
                                          WriteLiteral(recipe.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(356, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 9 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
          
            if (!recipe.Notes.Any(n => n.RecipeId == recipe.Id && n.UserId == Model.CurrentUserId))
            {

#line default
#line hidden
            BeginContext(491, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(511, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a160c87317d4c359b95371afd6af976", async() => {
                BeginContext(591, 8, true);
                WriteLiteral("Add Note");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
                                                   WriteLiteral(recipe.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(603, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 13 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(658, 61, true);
            WriteLiteral("                <td class=\"text-success\">Note created!</td>\r\n");
            EndContext();
#line 17 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
            }

            if (!recipe.Ratings.Any(r => r.RecipeId == recipe.Id && r.UserId == Model.CurrentUserId))
            {

#line default
#line hidden
            BeginContext(854, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(874, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0128632dc5f04f71b820e493ed306b2d", async() => {
                BeginContext(952, 4, true);
                WriteLiteral("Rate");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
                                                  WriteLiteral(recipe.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(960, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 22 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1015, 54, true);
            WriteLiteral("                <td class=\"text-success\">Rated!</td>\r\n");
            EndContext();
#line 26 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
            }

            if (!recipe.UsersFavourited.Any(uf => uf.RecipeId == recipe.Id && uf.UserId == Model.CurrentUserId))
            {

#line default
#line hidden
            BeginContext(1215, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1235, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3ee8603747e43e094021f0b75db2b6f", async() => {
                BeginContext(1336, 9, true);
                WriteLiteral("Favourite");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
                                                                         WriteLiteral(recipe.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1349, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 31 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1404, 59, true);
            WriteLiteral("                <td class=\"text-success\">Favourited!</td>\r\n");
            EndContext();
#line 35 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
            }

            if (!recipe.Reviews.Any(r => r.RecipeId == recipe.Id && r.UserId == Model.CurrentUserId))
            {

#line default
#line hidden
            BeginContext(1598, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1618, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4287a5d3b8054623b4cdccf6c5650e53", async() => {
                BeginContext(1698, 10, true);
                WriteLiteral("Add Review");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
                                                    WriteLiteral(recipe.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1712, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 40 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1767, 57, true);
            WriteLiteral("                <td class=\"text-success\">Reviewed!</td>\r\n");
            EndContext();
#line 44 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1850, 11, true);
            WriteLiteral("    </tr>\r\n");
            EndContext();
#line 47 "C:\Users\laptop_asus\documents\visual studio 2017\Projects\RecipesApp\Recipes.Web\Pages\Shared\DisplayTemplates\IndexModel.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipes.Web.Pages.Recipes.IndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591