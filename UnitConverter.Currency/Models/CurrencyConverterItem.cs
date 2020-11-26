using System.Text.Json.Serialization;

namespace UnitConverter.Currency.Models
{
    public class CurrencyConverterItem
    {
        [JsonPropertyName("An")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("Rt")]
        public double Ratio { get; set; }

        public CurrencyConverterItem() { }
        public CurrencyConverterItem(string currencyCode, double ratio)
        {
            CurrencyCode = currencyCode;
            Ratio = ratio;
        }
    }
}
