using Microsoft.UnitConverter.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.UnitConverter.Models
{
    public class CategoryProperties
    {
        public enum ValueRange
        {
            All, PositiveWithZero, Positive, NegativeWithZero, Negative
        }

        public Category Key { get; init; }
        public string LocalizedName { get; init; }
        public ValueRange SupportsValueRange { get; init; } = ValueRange.PositiveWithZero;

        public string Name => Key.Name;

        public CategoryProperties(Category key)
        {
            Key = key;
            LocalizedName = Resources.ResourceManager.GetString($"{key.Name}", CultureInfo.CurrentCulture);
        }
    }
}
