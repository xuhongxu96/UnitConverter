using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Currency.Loaders;
using UnitConverter.Currency.Models;

namespace UnitConverterUnitTests.Mocks
{
    public class MockCurrencyDataLoader : ICurrencyDataLoader
    {
        public Task<List<CurrencyConverterItem>> LoadCurrencyConverterItem()
        {
            return Task.FromResult(new List<CurrencyConverterItem>
            {
                new CurrencyConverterItem("MAR", 1.00),
                new CurrencyConverterItem("MON", 0.50),
                new CurrencyConverterItem("NEP", 0.00125),
                new CurrencyConverterItem("SAT", 0.25),
                new CurrencyConverterItem("URA", 2.75),
                new CurrencyConverterItem("VEN", 900.00),
                new CurrencyConverterItem("JUP", 1.23456789123456789),
                new CurrencyConverterItem("MER", 2.00),
                new CurrencyConverterItem("JPY", 0.00125),
                new CurrencyConverterItem("JOD", 0.25),
            });
        }

        public Task<List<CurrencyItem>> LoadCurrencyItem()
        {
            return Task.FromResult(new List<CurrencyItem>
            {
                new CurrencyItem
                {
                    CountryCode = "MAR",
                    CountryName = "Mars",
                    CurrencyCode = "MAR",
                    CurrencyName = "The Martian Dollar",
                    CurrencySymbol = "$",
                },
                new CurrencyItem
                {
                    CountryCode = "MON",
                    CountryName = "Moon",
                    CurrencyCode = "MON",
                    CurrencyName = "Moon Bucks",
                    CurrencySymbol = "$",
                },
                new CurrencyItem
                {
                    CountryCode = "NEP",
                    CountryName = "Neptune",
                    CurrencyCode = "NEP",
                    CurrencyName = "Space Coins",
                    CurrencySymbol = "$",
                },
                new CurrencyItem
                {
                    CountryCode = "SAT",
                    CountryName = "Saturn",
                    CurrencyCode = "SAT",
                    CurrencyName = "Rings",
                    CurrencySymbol = "$",
                },
                new CurrencyItem
                {
                    CountryCode = "URA",
                    CountryName = "Uranus",
                    CurrencyCode = "URA",
                    CurrencyName = "Galaxy Credits",
                    CurrencySymbol = "$",
                },
                new CurrencyItem
                {
                    CountryCode = "VEN",
                    CountryName = "Venus",
                    CurrencyCode = "VEN",
                    CurrencyName = "Venusian Seashells",
                    CurrencySymbol = "$",
                },
                new CurrencyItem
                {
                    CountryCode = "JUP",
                    CountryName = "Jupiter",
                    CurrencyCode = "JUP",
                    CurrencyName = "Gas Money",
                    CurrencySymbol = "$",
                },
                new CurrencyItem
                {
                    CountryCode = "MER",
                    CountryName = "Mercury",
                    CurrencyCode = "MER",
                    CurrencyName = "Sun Notes",
                    CurrencySymbol = "$",
                },
                new CurrencyItem
                {
                    CountryCode = "TEST1",
                    CountryName = "Test No Fractional Digits",
                    CurrencyCode = "JPY",
                    CurrencyName = "Test No Factional Digits",
                    CurrencySymbol = "$",
                },
                new CurrencyItem
                {
                    CountryCode = "TEST2",
                    CountryName = "Test Fractional Digits",
                    CurrencyCode = "JOD",
                    CurrencyName = "Test Factional Digits",
                    CurrencySymbol = "$",
                },
            });
        }
    }
}
