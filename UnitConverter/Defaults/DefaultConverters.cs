using Microsoft.UnitConverter.Converters;
using Microsoft.UnitConverter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.UnitConverter.Defaults
{
    public static class DefaultConverters
    {
        public static ConverterRepository AddAreaConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(DefaultUnits.Area.Acre, new LinearConverter(ratio: 4046.8564224))
                .Add(DefaultUnits.Area.Hectare, new LinearConverter(ratio: 10000))
                ;
        }

        public static ConverterRepository CreateRepository()
        {
            var res = new ConverterRepository();
            return res
                .AddAreaConverters()
                ;
        }
    }
}
