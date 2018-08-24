using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipes.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.UI.Services;
using Recipes.Web.Areas.Identity.Services;
using Recipes.Models;
using Recipes.Web.Common;
using AutoMapper;
using Recipes.Services.Admin.Categories;
using Recipes.Services.Admin.Categories.Interfaces;
using Recipes.Services.Admin.Users;
using Recipes.Services.Admin.Users.Interfaces;
using Recipes.Services.Users.Recipes.Interfaces;
using Recipes.Services.Users.Recipes;
using Recipes.Services.Users.Reviews.Interfaces;
using Recipes.Services.Users.Reviews;
using Recipes.Services.Users.Categories.Interfaces;
using Recipes.Services.Users.Categories;
using Recipes.Services.Users.Notes.Intefaces;
using Recipes.Services.Users.Notes;
using Recipes.Services.Admin.Recipes.Interfaces;
using Recipes.Services.Admin.Recipes;
using Recipes.Services.Admin.Reviews.Interfaces;
using Recipes.Services.Admin.Reviews;
using Recipes.Constants;

namespace Recipes.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<RecipesDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString(AppConstants.ConnectionStringName)));

            services
                .AddIdentity<User, IdentityRole>()
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<RecipesDbContext>();

            services.AddAuthentication()
                .AddFacebook(options =>
                {
                    options.AppId = this.Configuration.GetSection(AppConstants.FacebookAppIdKeyName).Value;
                    options.AppSecret = this.Configuration.GetSection(AppConstants.FacebookAppSecretKeyName).Value;
                })
                .AddGoogle(options =>
                {
                    options.ClientId = this.Configuration.GetSection(AppConstants.GoogleAppIdKeyName).Value;
                    options.ClientSecret = this.Configuration.GetSection(AppConstants.GoogleAppSecretKeyName).Value;
                });

            services.Configure<IdentityOptions>(options =>
            {
                options.Password = new PasswordOptions()
                {
                    RequiredLength = 8,
                    RequiredUniqueChars = 5,
                    RequireDigit = true,
                    RequireLowercase = true,
                    RequireNonAlphanumeric = false,
                    RequireUppercase = true
                };

                options.SignIn.RequireConfirmedEmail = true;
            });

            services.AddSingleton<IEmailSender, EmailSender>();
            services.Configure<SendGridOptions>(this.Configuration.GetSection(AppConstants.EmailSettingsSectionKey));

            services.AddAutoMapper();

            RegisterServiceLayer(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler(AppConstants.HomeErrorRoute);
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.SeedDatabase();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: AppConstants.AreaMapRouteName,
                    template: AppConstants.AreaMapRouteTemplate);
                routes.MapRoute(
                    name: AppConstants.DefaultMapRouteName,
                    template: AppConstants.DefaultMapRouteTemplate);
            });
        }

        private static void RegisterServiceLayer(IServiceCollection services)
        {
            services.AddScoped<IAdminCategoryService, AdminCategoryService>();
            services.AddScoped<IAdminUserService, AdminUserService>();
            services.AddScoped<IUserRecipeService, UserRecipeService>();
            services.AddScoped<IUserReviewService, UserReviewService>();
            services.AddScoped<IUserCategoryService, UserCategoryService>();
            services.AddScoped<IUserNotesService, UserNotesService>();
            services.AddScoped<IAdminRecipeService, AdminRecipeService>();
            services.AddScoped<IAdminReviewService, AdminReviewService>();
        }

    }
}
