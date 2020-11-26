using Microsoft.UnitConverter.Converters;
using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Currency.Loaders;

namespace UnitConverter.Currency.Defaults
{
    public static class DefaultConverters
    {
        public static async Task<ConverterRepository> AddOrUpdateCurrencyConverters(this ConverterRepository converterRepository, ICurrencyDataLoader loader)
        {
            foreach (var item in await loader.LoadCurrencyConverterItem())
            {
                var unit = new Unit(DefaultCategories.Currency, item.CurrencyCode);
                converterRepository[unit] = new LinearConverter(ratio: 1.0 / item.Ratio);
            }
            return converterRepository;
        }
    }
}
