using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes.Data;
using Recipes.Services.Admin.Categories;
using Recipes.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Tests
{
    [TestClass]
    public abstract class BaseTests
    {
        [TestInitialize]
        public void TestsSetup()
        {
            this.DbContext = MockDbContext.GetDbContext();
            this.Mapper = MockAutoMapper.GetMapper();
        }

        protected RecipesDbContext DbContext { get; private set; }

        protected IMapper Mapper { get; private set; }
    }
}
