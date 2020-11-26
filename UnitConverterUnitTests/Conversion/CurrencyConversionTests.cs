using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;
using System;
using System.Threading.Tasks;
using UnitConverter.Currency.Defaults;
using UnitConverter.Currency.Loaders;
using UnitConverterUnitTests.Mocks;
using Xunit;

namespace UnitConverterUnitTests.Conversion
{
    public class CurrencyConversionTests
    {
        private static readonly ConverterRepository _repo = new ConverterRepository();

        [Theory]
        [InlineData("MAR", "MON", 1, 0.5)]
        [InlineData("MAR", "SAT", 1.2, 0.3)]
        public async Task TestOnMockLoader(string from, string to, double value, double expected)
        {
            await _repo.AddOrUpdateCurrencyConverters(new MockCurrencyDataLoader());

            var category = new Category(nameof(DefaultCategories.Currency));
            var fromUnit = new Unit(category, from);
            var toUnit = new Unit(category, to);

            Assert.Equal(Math.Round(expected, 2), Math.Round(_repo.Convert(value, fromUnit, toUnit), 2));
        }

        [Theory]
        [InlineData("MAR", "MON", 1, 0.5)]
        [InlineData("MAR", "SAT", 1.2, 0.3)]
        public async Task TestOnRealLoader(string from, string to, double value, double expected)
        {
            await _repo.AddOrUpdateCurrencyConverters(new CurrencyDataLoader());

            var category = new Category(nameof(DefaultCategories.Currency));
            var fromUnit = new Unit(category, from);
            var toUnit = new Unit(category, to);

            Assert.Equal(Math.Round(expected, 2), Math.Round(_repo.Convert(value, fromUnit, toUnit), 2));
        }
    }
}
