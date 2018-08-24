using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Recipes.Data;
using Recipes.Models;
using Recipes.Services.Admin.Categories;
using Recipes.Tests.Mocks;
using Recipes.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Tests.Services
{
    [TestClass]
    public class AdminCategoryServiceTests : BaseTests
    {
        [TestMethod]
        public async Task GetCategoriesAsync_WithSomeCategories_ShouldReturnAll()
        {
            //Arrange
            this.DbContext.Categories.Add(new Category() { Id = 1, Name = "First category" });
            this.DbContext.Categories.Add(new Category() { Id = 2, Name = "Second category" });
            this.DbContext.Categories.Add(new Category() { Id = 3, Name = "Third category" });
            this.DbContext.SaveChanges();

            var service = new AdminCategoryService(this.DbContext, this.Mapper, null);

            //Act
            var categories = await service.GetCategoriesAsync();

            //Assert
            Assert.IsNotNull(categories);
            Assert.AreEqual(3, categories.Count());
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, categories.Select(c => c.Id).ToArray());
        }

        [TestMethod]
        public async Task GetCategoriesAsync_WithZeroCategories_ShouldReturnNone()
        {
            //Arrange
            var service = new AdminCategoryService(this.DbContext, this.Mapper, null);

            //Act
            var categories = await service.GetCategoriesAsync();

            //Assert
            Assert.IsNotNull(categories);
            Assert.AreEqual(0, categories.Count());
        }

        [TestMethod]
        public void NameExists_WithExistingName_ShouldReturnTrue()
        {
            //Arrange
            this.DbContext.Categories.Add(new Category() { Id = 1, Name = "First category" });
            this.DbContext.SaveChanges();
            var service = new AdminCategoryService(this.DbContext, this.Mapper, null);

            //Act
            bool result = service.NameExits("First category");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NameExists_WithoutExistingName_ShouldReturnFalse()
        {
            //Arrange
            this.DbContext.Categories.Add(new Category() { Id = 1, Name = "First category" });
            this.DbContext.SaveChanges();

            var service = new AdminCategoryService(this.DbContext, this.Mapper, null);

            //Act
            bool result = service.NameExits("Not existing category");

            //Assert
            Assert.IsFalse(result);
        }
    }
}
