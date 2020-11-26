using System.Threading.Tasks;
using UnitConverter.Converters;
using UnitConverter.Currency.Loaders;
using UnitConverter.Models;
using UnitConverter.Repositories;

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
