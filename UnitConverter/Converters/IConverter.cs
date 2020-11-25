namespace Microsoft.UnitConverter.Converters
{
    public interface IConverter
    {
        double ConvertToPivotValue(double value);
        double ConvertFromPivotValue(double value);
    }
}
