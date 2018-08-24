using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes.Common.Admin.BindingModels;
using Recipes.Common.Users.BindingModels;
using Recipes.Data;
using Recipes.Models;
using Recipes.Services.Admin.Categories;
using Recipes.Services.Users.Recipes;
using Recipes.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipes.Tests.Services
{
    [TestClass]
    public class UserRecipeServiceTests : BaseTests
    {
        [TestMethod]
        public void GetAllRecipes_WithSomeRecipes_ShouldReturnAll()
        {
            //Arrange
            this.DbContext.Recipes.Add(new Recipe() { Id = 1, Title = "First recipe" });
            this.DbContext.Recipes.Add(new Recipe() { Id = 2, Title = "Second recipe" });
            this.DbContext.Recipes.Add(new Recipe() { Id = 3, Title = "Third recipe" });

            this.DbContext.SaveChanges();

            var service = new UserRecipeService(this.DbContext, this.Mapper, null);

            //Act
            var recipes = service.GetAllRecipes();

            //Assert
            Assert.IsNotNull(recipes);
            Assert.AreEqual(3, recipes.Count());
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, recipes.Select(c => c.Id).ToArray());
        }

        [TestMethod]
        public void GetRecipe_WithExistingId_ReturnsRecipe()
        {
            //Arrange
            this.DbContext.Recipes.Add(new Recipe() { Id = 1, Title = "First recipe" });
            this.DbContext.SaveChanges();

            var service = new UserRecipeService(this.DbContext, this.Mapper, null);

            //Act
            var recipe = service.GetRecipe(1);

            //Assert
            Assert.IsNotNull(recipe);
            Assert.AreEqual(1, recipe.Id);
            Assert.AreEqual("First recipe", recipe.Title);
        }

        [TestMethod]
        public void GetRecipe_WithNonExistingId_ReturnsNull()
        {
            //Arrange
            this.DbContext.Recipes.Add(new Recipe() { Id = 1, Title = "First recipe" });
            this.DbContext.SaveChanges();

            var service = new UserRecipeService(this.DbContext, this.Mapper, null);

            //Act
            var recipe = service.GetRecipe(200);

            //Assert
            Assert.IsNull(recipe);
        }

        [TestMethod]
        public void CreateRecipe_WithModelAndUser_AddsRecipeToDb()
        {
            //Arrange
            var userId = Guid.NewGuid().ToString();
            var model = new RecipeCreationBindingModel()
            {
                Id = 1,
                Title = "SomeRecipe",
                Instructions = "IntructionsIntructionsIntructionsIntructionsIntructions",
                CategoryId = 1
            };
            var service = new UserRecipeService(this.DbContext, this.Mapper, null);

            //Act
            service.CreateRecipe(model, userId);

            //Assert
            Assert.AreEqual(1, this.DbContext.Recipes.Count());
        }
    }
}
