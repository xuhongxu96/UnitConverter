using System;
using System.Linq;
using UnitConverter.Models;
using UnitConverter.Repositories;
using UnitConverterUnitTests.Utils;
using Xunit;
using static UnitConverter.Defaults.DefaultUnits;

namespace UnitConverterUnitTests.Conversion
{
    public class MultiUnitConversionTests
    {
        private static readonly ConverterRepository _repo = ConverterRepository.Default;

        [Theory]
        [InlineData(
            nameof(Length),
            new string[] { nameof(Length.Meter), nameof(Length.Centimeter) },
            nameof(Length.Millimeter),
            new double[] { 10, 20 },
            10200)
        ]
        public void TestConvertMultiUnitsToSingleUnit(string categoryName, string[] from, string to, double[] values, double expected)
        {
            var category = new Category(categoryName);
            var toUnit = new Unit(category, to);
            var fromUnits = new UnitValue[from.Length];

            for (var i = 0; i < from.Length; ++i)
            {
                fromUnits[i] = new UnitValue
                {
                    Unit = new Unit(category, from[i]),
                    Value = values[i],
                };
            }

            var pivot = _repo.ConvertMultiUnitsToPivotValue(fromUnits);
            Assert.Equal(expected, _repo.ConvertFromPivotValue(pivot, toUnit), precision: 2);
        }

        [Theory]
        [InlineData(
            nameof(Length),
            nameof(Length.Meter),
            new string[] { nameof(Length.Meter), nameof(Length.Centimeter) },
            12.025,
            new double[] { 12, 2.5 }
            )
        ]
        public void TestConvertSingleUnitToMultiUnits(string categoryName, string from, string[] to, double value, double[] expected)
        {
            var category = new Category(categoryName);
            var fromUnit = new Unit(category, from);

            var res = _repo.ConvertPivotValueToMultiUnits(
                _repo.ConvertToPivotValue(value, fromUnit),
                to.Select(o => new Unit(category, o)).ToArray()
                );

            Assert.Equal(expected, res, new RoundedDoubleComparer());
        }

        [Theory]
        [InlineData(
            nameof(Length),
            new string[] { nameof(Length.Meter), nameof(Length.Centimeter) },
            new string[] { nameof(Length.Meter), nameof(Length.Millimeter) },
            new double[] { 3, 120.23 },
            new double[] { 4, 202.3 }
            )
        ]
        public void TestConvertMultiUnitsToMultiUnits(string categoryName, string[] from, string[] to, double[] values, double[] expected)
        {
            var category = new Category(categoryName);
            var fromUnits = new UnitValue[from.Length];

            for (var i = 0; i < from.Length; ++i)
            {
                fromUnits[i] = new UnitValue
                {
                    Unit = new Unit(category, from[i]),
                    Value = values[i],
                };
            }

            var pivot = _repo.ConvertMultiUnitsToPivotValue(fromUnits);
            var res = _repo.ConvertPivotValueToMultiUnits(pivot, to.Select(o => new Unit(category, o)).ToArray());

            Assert.Equal(expected, res, new RoundedDoubleComparer());
        }
    }
}
