using Microsoft.EntityFrameworkCore;
using Recipes.Data;
using System;

namespace Recipes.Tests.Mocks
{
    public static class MockDbContext
    {
        public static RecipesDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<RecipesDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            return new RecipesDbContext(options);
        }
    }
}
