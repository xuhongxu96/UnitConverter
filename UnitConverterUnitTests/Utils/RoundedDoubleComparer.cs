using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace UnitConverterUnitTests.Utils
{
    public class RoundedDoubleComparer : IEqualityComparer<double>
    {
        private int _precision;

        public RoundedDoubleComparer(int precision = 2)
        {
            _precision = precision;
        }

        public bool Equals(double x, double y)
        {
            return Math.Round(x, _precision) == Math.Round(y, _precision);
        }

        public int GetHashCode([DisallowNull] double obj)
        {
            return Math.Round(obj, _precision).GetHashCode();
        }
    }
}
