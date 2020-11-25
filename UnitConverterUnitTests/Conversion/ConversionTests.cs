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

        [InlineData(nameof(Power), nameof(Power.Kilowatt), nameof(Power.Horsepower), 12, 16.09227)]

        [InlineData(nameof(Pressure), nameof(Pressure.Atmosphere), nameof(Pressure.Pascal), 20, 2026500)]

        [InlineData(nameof(Temperature), nameof(Temperature.Celsius), nameof(Temperature.Fahrenheit), 1, 33.8)]
        [InlineData(nameof(Temperature), nameof(Temperature.Celsius), nameof(Temperature.Fahrenheit), 32, 89.6)]
        [InlineData(nameof(Temperature), nameof(Temperature.Fahrenheit), nameof(Temperature.Celsius), 100, 37.778)]

        public void TestConvert(string categoryName, string from, string to, double value, double expected)
        {
            var category = new Category(categoryName);
            var fromUnit = new Unit(category, from);
            var toUnit = new Unit(category, to);

            Assert.Equal(Math.Round(expected, 2), Math.Round(_repo.Convert(value, fromUnit, toUnit), 2));
        }
    }
}
