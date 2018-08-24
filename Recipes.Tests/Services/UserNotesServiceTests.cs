using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes.Models;
using Recipes.Services.Users.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipes.Tests.Services
{
    [TestClass]
    public class UserNotesServiceTests : BaseTests
    {
        private string userId;
        private int recipeId;
        private string noteContent;
        private UserNotesService service;

        [TestInitialize]
        public void InitializeTests()
        {
            this.userId = Guid.NewGuid().ToString();
            this.recipeId = 1;
            this.noteContent = "Content";
            this.service = new UserNotesService(this.DbContext, this.Mapper, null);
        }

        [TestMethod]
        public void CreateNote_WithValidData_ShouldReturnNote()
        {
            //Arrange

            //Act
            var note = this.service.CreateNote(this.noteContent, this.userId, this.recipeId);

            //Assert
            Assert.IsNotNull(note);
        }

        [TestMethod]
        public void CreateNote_WithValidData_ShouldAddNoteToDb()
        {
            //Arrange

            //Act
            var note = this.service.CreateNote(this.noteContent, this.userId, this.recipeId);

            //Assert
            Assert.AreEqual(1, this.DbContext.Notes.Count());
        }

        [TestMethod]
        public void NoteAlreadyExists_WithExistingData_ShouldReturnTrue()
        {
            //Arrange
            var note = new Note()
            {
                Id = 1,
                Content = this.noteContent,
                RecipeId = this.recipeId,
                UserId = this.userId
            };

            this.DbContext.Notes.Add(note);
            this.DbContext.SaveChanges();

            //Act
            var result = service.NoteAlreadyExists(this.recipeId, this.userId);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NoteAlreadyExists_WithNonExistingData_ShouldReturnFalse()
        {
            //Arrange
            var note = new Note()
            {
                Id = 1,
                Content = this.noteContent,
                RecipeId = this.recipeId,
                UserId = this.userId
            };

            this.DbContext.Notes.Add(note);
            this.DbContext.SaveChanges();

            //Act
            var result = service.NoteAlreadyExists(2, "RandomString");

            //Assert
            Assert.IsFalse(result);
        }
    }
}
