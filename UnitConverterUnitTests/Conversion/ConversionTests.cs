using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;
using System;
using Xunit;
using static Microsoft.UnitConverter.Defaults.DefaultUnits;

namespace UnitConverterUnitTests.Conversion
{
    public class ConversionTests
    {
        private static readonly ConverterRepository _repo = ConverterRepository.Default;

        [Theory]

        [InlineData(nameof(Area), nameof(Area.Acre), nameof(Area.Hectare), 10, 4.0468564224)]
        [InlineData(nameof(Area), nameof(Area.SquareMeter), nameof(Area.SquareFoot), 10, 107.6391)]

        [InlineData(nameof(Data), nameof(Data.Bit), nameof(Data.Byte), 32, 4)]

        public void TestConvert(string categoryName, string from, string to, double value, double expected)
        {
            var category = new Category(categoryName);
            var fromUnit = new Unit(category, from);
            var toUnit = new Unit(category, to);

            Assert.Equal(Math.Round(expected, 2), Math.Round(_repo.Convert(fromUnit, toUnit, value), 2));
        }
    }
}
