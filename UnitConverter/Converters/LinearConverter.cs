using Microsoft.UnitConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public double ConvertToPivotValue(double value)
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

        public double ConvertFromPivotValue(double value)
        {
            if (_offsetFirst)
            {
                return value / _ratio - _offset;
            }
            else
            {
                return (value - _offset) / _ratio;
            }
        }
    }
}
