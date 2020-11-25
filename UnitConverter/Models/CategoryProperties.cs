using System;
using System.Collections.Generic;
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
        public ValueRange SupportsValueRange { get; init; } = ValueRange.All;

        public string Name => Key.Name;
    }
}
