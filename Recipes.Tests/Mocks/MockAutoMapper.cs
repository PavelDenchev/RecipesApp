using AutoMapper;
using Recipes.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipes.Tests.Mocks
{
    public static class MockAutoMapper
    {
        static MockAutoMapper()
        {
            Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());
        }

        public static IMapper GetMapper() => Mapper.Instance;
    }
}
