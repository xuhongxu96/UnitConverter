﻿using Microsoft.UnitConverter.Converters;
using Microsoft.UnitConverter.Defaults;
using Microsoft.UnitConverter.Exceptions;
using Microsoft.UnitConverter.Models;
using System;
using System.Collections.Generic;

namespace Microsoft.UnitConverter.Repositories
{
    public class ConverterRepository
    {
        private readonly Dictionary<Unit, IConverter> _converters = new Dictionary<Unit, IConverter>();

        public ConverterRepository Add(Unit unit, IConverter converter)
        {
            if (_converters.ContainsKey(unit))
            {
                throw new DuplicateUnitException(unit.ToString());
            }
            _converters.Add(unit, converter);
            return this;
        }

        public double ConvertToPivotValue(double value, Unit from)
        {
            if (!_converters.TryGetValue(from, out var converter))
            {
                throw new KeyNotFoundException(from.ToString());
            }
            return converter.ConvertToPivotValue(value, from);
        }

        public double ConvertFromPivotValue(double pivotValue, Unit to)
        {
            if (!_converters.TryGetValue(to, out var converter))
            {
                throw new KeyNotFoundException(to.ToString());
            }
            return converter.ConvertFromPivotValue(pivotValue, to);
        }

        public double Convert(double value, Unit from, Unit to)
        {
            if (!from.Category.Equals(to.Category))
            {
                throw new DifferentCategoryException($"From {from} To {to}");
            }
            if (!_converters.TryGetValue(from, out var fromConverter))
            {
                throw new KeyNotFoundException(from.ToString());
            }
            if (!_converters.TryGetValue(to, out var toConverter))
            {
                throw new KeyNotFoundException(to.ToString());
            }

            var pivot = fromConverter.ConvertToPivotValue(value, from);
            return toConverter.ConvertFromPivotValue(pivot, to);
        }

        public double ConvertMultiUnitsToPivotValue(params UnitValue[] from)
        {
            double pivot = 0;
            foreach (var unitValue in from)
            {
                if (!_converters.TryGetValue(unitValue.Unit, out var converter))
                {
                    throw new KeyNotFoundException(unitValue.Unit.ToString());
                }
                pivot += converter.ConvertToPivotValue(unitValue.Value, unitValue.Unit);
            }
            return pivot;
        }

        public double[] ConvertPivotValueToMultiUnits(double pivotValue, params Unit[] toUnits)
        {
            var res = new double[toUnits.Length];
            for (var i = 0; i < toUnits.Length; ++i)
            {
                var unit = toUnits[i];
                if (!_converters.TryGetValue(unit, out var converter))
                {
                    throw new KeyNotFoundException(unit.ToString());
                }

                var value = converter.ConvertFromPivotValue(pivotValue, unit);
                if (i < toUnits.Length - 1)
                {
                    value = Math.Round(value);
                }
                pivotValue -= converter.ConvertToPivotValue(value, unit);
                res[i] = value;
            }
            return res;
        }

        public static ConverterRepository Default { get; } = DefaultConverters.CreateRepository();
    }
}
