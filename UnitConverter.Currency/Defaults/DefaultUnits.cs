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
    public static class DefaultUnits
    {

        public static async Task<UnitRepository> AddOrUpdateCurrencyUnits(this UnitRepository unitRepository, ICurrencyDataLoader loader)
        {
            foreach (var item in await loader.LoadCurrencyItem())
            {
                var unit = new Unit(DefaultCategories.Currency, item.CurrencyCode);
                unitRepository[unit] = new UnitProperties(unit)
                {
                    Abbreviations = new string[] { item.CurrencySymbol },
                };
            }
            return unitRepository;
        }

    }
}
