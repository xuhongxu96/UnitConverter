using Microsoft.UnitConverter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Currency.Defaults;
using UnitConverter.Currency.Loaders;

namespace UnitConverterUnitTests.Fixtures
{
    public class ConverterRepositoryWithRealDataFixture : IDisposable
    {
        public readonly ConverterRepository Repo = new ConverterRepository();

        public ConverterRepositoryWithRealDataFixture()
        {
            Repo.AddOrUpdateCurrencyConverters(new CurrencyDataLoader()).GetAwaiter().GetResult();
        }

        public void Dispose()
        {
        }
    }
}
