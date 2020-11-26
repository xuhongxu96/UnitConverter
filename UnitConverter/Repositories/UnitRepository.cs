using System.Collections.Generic;
using UnitConverter.Defaults;
using UnitConverter.Exceptions;
using UnitConverter.Models;

namespace UnitConverter.Repositories
{
    public class UnitRepository
    {
        private readonly Dictionary<Unit, UnitProperties> _units = new Dictionary<Unit, UnitProperties>();

        public UnitRepository Clear()
        {
            _units.Clear();
            return this;
        }

        public UnitRepository Add(UnitProperties unit)
        {
            if (_units.ContainsKey(unit.Key))
            {
                throw new DuplicateUnitException(unit.Key.ToString());
            }

            _units.Add(unit.Key, unit);
            return this;
        }

        public UnitProperties this[Unit unit]
        {
            get => _units[unit];
            set => _units[unit] = value;
        }

        public static UnitRepository Default { get; } = DefaultUnits.CreateRepository();
    }
}
