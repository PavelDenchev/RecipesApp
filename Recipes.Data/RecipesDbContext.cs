using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Recipes.Models;

namespace Recipes.Data
{
    public class RecipesDbContext : IdentityDbContext<User>
    {
        public RecipesDbContext(DbContextOptions<RecipesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<UserFavourites> UserFavourites { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<User>()
                .HasMany(u => u.FavouritedRecipes)
                .WithOne(uf => uf.User)
                .HasForeignKey(uf => uf.UserId);

            builder
                .Entity<Recipe>()
                .HasMany(r => r.UsersFavourited)
                .WithOne(uf => uf.Recipe)
                .HasForeignKey(uf => uf.RecipeId);

            builder
                .Entity<UserFavourites>()
                .HasKey(uf => new { uf.RecipeId, uf.UserId });

            builder
                .Entity<User>()
                .HasMany(u => u.Ratings)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);

            builder
                .Entity<Recipe>()
                .HasMany(r => r.Ratings)
                .WithOne(ra => ra.Recipe)
                .HasForeignKey(ra => ra.RecipeId);

            builder
                .Entity<Rating>()
                .HasKey(r => new { r.RecipeId, r.UserId });

            builder.Entity<Recipe>()
                .HasIndex(r => r.Title)
                .IsUnique();

            builder.Entity<Category>()
                .HasIndex(r => r.Name)
                .IsUnique();

            base.OnModelCreating(builder);
        }
    }
}
