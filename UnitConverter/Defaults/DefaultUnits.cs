using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.UnitConverter.Defaults
{
    public static class DefaultUnits
    {
        public static class Area
        {
            private static readonly Category _cat = DefaultCategories.Area;

            public static readonly Unit Acre = new Unit(_cat, nameof(Acre));
            public static readonly Unit Hectare = new Unit(_cat, nameof(Hectare));
        }

        public static UnitRepository AddAreaUnits(this UnitRepository unitRepository)
        {
            return unitRepository
                .Add(new UnitProperties
                {
                    Key = Area.Acre,
                    Abbreviations = new string[] { },
                    AccessibleName = "Acre",
                })
                .Add(new UnitProperties
                {
                    Key = Area.Hectare,
                    Abbreviations = new string[] { },
                    AccessibleName = "Hectare",
                })
                ;
        }

        public static UnitRepository CreateRepository()
        {
            var res = new UnitRepository();
            return res
                .AddAreaUnits()
                ;
        }
    }
}
