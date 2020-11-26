using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;
using System;
using System.Threading.Tasks;
using UnitConverter.Currency.Defaults;
using UnitConverter.Currency.Loaders;
using UnitConverterUnitTests.Fixtures;
using UnitConverterUnitTests.Mocks;
using Xunit;

namespace UnitConverterUnitTests.Conversion
{
    public class CurrencyConversionTests : IClassFixture<ConverterRepositoryWithRealDataFixture>
    {
        private static readonly ConverterRepository _repo = new ConverterRepository();
        private ConverterRepositoryWithRealDataFixture _realDataRepoFixture;

        public CurrencyConversionTests(ConverterRepositoryWithRealDataFixture fixture)
        {
            _realDataRepoFixture = fixture;
        }

        [Theory]
        [InlineData("MAR", "MON", 1, 0.5)]
        [InlineData("MAR", "SAT", 1.2, 0.3)]
        public async Task TestOnMockLoader(string from, string to, double value, double expected)
        {
            await _repo.AddOrUpdateCurrencyConverters(new MockCurrencyDataLoader());

            var category = new Category(nameof(DefaultCategories.Currency));
            var fromUnit = new Unit(category, from);
            var toUnit = new Unit(category, to);

            Assert.Equal(expected, _repo.Convert(value, fromUnit, toUnit), precision: 2);
        }

        [Theory]
        [InlineData("MAR", "MON", 1, 0.5)]
        [InlineData("MAR", "SAT", 1.2, 0.3)]
        public void TestOnRealLoader(string from, string to, double value, double expected)
        {
            var category = new Category(nameof(DefaultCategories.Currency));
            var fromUnit = new Unit(category, from);
            var toUnit = new Unit(category, to);

            Assert.Equal(expected, _realDataRepoFixture.Repo.Convert(value, fromUnit, toUnit), precision: 2);
        }

        [Fact]
        public async Task TestUpdate()
        {
            var loader = new MockCurrencyDataLoader();
            var category = new Category(nameof(DefaultCategories.Currency));
            var fromUnit = new Unit(category, "RND");
            var toUnit = new Unit(category, "MAR");

            await _repo.AddOrUpdateCurrencyConverters(loader);
            var res1 = _repo.Convert(1, fromUnit, toUnit);

            await _repo.AddOrUpdateCurrencyConverters(loader);
            var res2 = _repo.Convert(1, fromUnit, toUnit);

            Assert.NotEqual(res1, res2, precision: 2);
        }
    }
}
