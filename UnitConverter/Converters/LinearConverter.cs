using Microsoft.UnitConverter.Models;

namespace Microsoft.UnitConverter.Converters
{
    public class LinearConverter : IConverter
    {
        private double _offset;
        private double _ratio;
        private bool _offsetFirst;

        public LinearConverter(double offset = 0, double ratio = 1, bool offsetFirst = true)
        {
            _offset = offset;
            _ratio = ratio;
            _offsetFirst = offsetFirst;
        }

        public double ConvertToPivotValue(double value, Unit from)
        {
            if (_offsetFirst)
            {
                return (value + _offset) * _ratio;
            }
            else
            {
                return (value * _ratio) + _offset;
            }
        }

        public double ConvertFromPivotValue(double pivotValue, Unit to)
        {
            if (_offsetFirst)
            {
                return pivotValue / _ratio - _offset;
            }
            else
            {
                return (pivotValue - _offset) / _ratio;
            }
        }
    }
}
