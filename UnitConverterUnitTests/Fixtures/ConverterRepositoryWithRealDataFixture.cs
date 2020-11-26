using System;
using UnitConverter.Currency.Defaults;
using UnitConverter.Currency.Loaders;
using UnitConverter.Repositories;

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
