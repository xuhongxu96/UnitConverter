using System.Collections.Generic;
using System.Threading.Tasks;
using UnitConverter.Currency.Models;

namespace UnitConverter.Currency.Loaders
{
    public interface ICurrencyDataLoader
    {
        Task<List<CurrencyConverterItem>> LoadCurrencyConverterItem();
        Task<List<CurrencyItem>> LoadCurrencyItem();
    }
}