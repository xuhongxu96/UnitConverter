using Microsoft.UnitConverter.Defaults;
using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
