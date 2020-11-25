using Microsoft.UnitConverter.Defaults;
using Microsoft.UnitConverter.Exceptions;
using Microsoft.UnitConverter.Models;
using System.Collections.Generic;

namespace Microsoft.UnitConverter.Repositories
{
    public class UnitRepository
    {
        private readonly Dictionary<Unit, UnitProperties> _units = new Dictionary<Unit, UnitProperties>();

        public UnitRepository Add(UnitProperties unit)
        {
            if (_units.ContainsKey(unit.Key))
            {
                throw new DuplicateUnitException(unit.Key.ToString());
            }

            _units.Add(unit.Key, unit);
            return this;
        }

        public static UnitRepository Default { get; } = DefaultUnits.CreateRepository();
    }
}
