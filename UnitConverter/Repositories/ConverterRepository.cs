using Microsoft.UnitConverter.Converters;
using Microsoft.UnitConverter.Defaults;
using Microsoft.UnitConverter.Exceptions;
using Microsoft.UnitConverter.Models;
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

        public double Convert(Unit from, Unit to, double value)
        {
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

        public static ConverterRepository Default { get; } = DefaultConverters.CreateRepository();
    }
}
