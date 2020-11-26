using Microsoft.UnitConverter.Converters;
using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UnitConverter.Currency.Defaults;
using UnitConverter.Currency.Models;

namespace UnitConverter.Currency.Loaders
{
    public class CurrencyDataLoader : ICurrencyDataLoader
    {
        private const string CurrencyDataURL = "https://go.microsoft.com/fwlink/?linkid=2091028";
        private const string CurrencyConverterDataURL = "https://go.microsoft.com/fwlink/?linkid=2091307";

        private HttpClient _client = new HttpClient();

        public CurrencyDataLoader() { }

        public CurrencyDataLoader(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<CurrencyItem>> LoadCurrencyItem()
        {
            var res = await _client.GetAsync(CurrencyDataURL);
            return JsonSerializer.Deserialize<List<CurrencyItem>>(await res.Content.ReadAsStringAsync());
        }

        public async Task<List<CurrencyConverterItem>> LoadCurrencyConverterItem()
        {
            var res = await _client.GetAsync(CurrencyConverterDataURL);
            return JsonSerializer.Deserialize<List<CurrencyConverterItem>>(await res.Content.ReadAsStringAsync());
        }
    }
}
