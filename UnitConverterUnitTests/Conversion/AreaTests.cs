using Microsoft.UnitConverter.Defaults;
using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;
using System;
using Xunit;
using static Microsoft.UnitConverter.Defaults.DefaultUnits;

namespace UnitConverterUnitTests.Conversion
{
    public class AreaTests
    {
        private static readonly ConverterRepository _repo = ConverterRepository.Default;

        [Theory]
        [InlineData(nameof(Area.Acre), nameof(Area.Hectare), 10, 4.0468564224)]
        [InlineData(nameof(Area.SquareMeter), nameof(Area.SquareFoot), 10, 107.6391)]
        public void TestConvert(string from, string to, double value, double expected)
        {
            Assert.Equal(Math.Round(expected, 2), Math.Round(_repo.Convert(new Unit(DefaultCategories.Area, from), new Unit(DefaultCategories.Area, to), value), 2));
        }
    }
}
