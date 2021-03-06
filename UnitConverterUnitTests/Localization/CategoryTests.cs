﻿using System.Globalization;
using UnitConverter.Defaults;
using UnitConverter.Models;
using Xunit;

namespace UnitConverterUnitTests.Localization
{
    public class CategoryTests
    {
        [Theory]
        [InlineData("en-US", "Area", "Area")]
        [InlineData("zh-CN", "Area", "面积")]
        public void CheckLocalizedName(string culture, string category, string expectedLocalizedName)
        {
            CultureInfo.CurrentCulture = new CultureInfo(culture, false);
            var repo = DefaultCategories.CreateRepository();
            Assert.Equal(expectedLocalizedName, repo.Get(new Category(category)).LocalizedName);
        }
    }
}
