using UnitConverter.Models;

namespace UnitConverter.Converters
{
    public interface IConverter
    {
        double ConvertToPivotValue(double value, Unit from);
        double ConvertFromPivotValue(double pivotValue, Unit to);
    }
}
