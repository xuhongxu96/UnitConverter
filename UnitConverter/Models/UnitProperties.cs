using Microsoft.UnitConverter.Properties;
using System.Globalization;

namespace Microsoft.UnitConverter.Models
{
    public class UnitProperties
    {
        public Unit Key { get; init; }
        public string LocalizedName { get; private init; }
        public string[] Abbreviations { get; private init; }
        public bool IsWhimsical { get; init; } = false;

        public Category Category => Key.Category;
        public string Name => Key.UnitName;

        public UnitProperties(Unit key)
        {
            Key = key;
            LocalizedName = Resources.ResourceManager.GetString($"{key.Category}_{key.UnitName}", CultureInfo.CurrentCulture);
            Abbreviations = Resources.ResourceManager.GetString($"{key.Category}_{key.UnitName}_Abbreviations", CultureInfo.CurrentCulture).Split(';');
        }
    }
}
