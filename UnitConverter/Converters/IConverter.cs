using Microsoft.UnitConverter.Models;

namespace Microsoft.UnitConverter.Converters
{
    public interface IConverter
    {
        double ConvertToPivotValue(double value, Unit from);
        double ConvertFromPivotValue(double value, Unit to);
    }
}
