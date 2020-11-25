using Microsoft.UnitConverter.Converters;
using Microsoft.UnitConverter.Repositories;
using static Microsoft.UnitConverter.Defaults.DefaultUnits;

namespace Microsoft.UnitConverter.Defaults
{
    public static class DefaultConverters
    {
        public static ConverterRepository AddAreaConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(Area.Acre, new LinearConverter(ratio: 4046.8564224))
                .Add(Area.SquareMeter, new LinearConverter(ratio: 1))
                .Add(Area.SquareFoot, new LinearConverter(ratio: 0.09290304))
                .Add(Area.SquareYard, new LinearConverter(ratio: 0.83612736))
                .Add(Area.SquareMillimeter, new LinearConverter(ratio: 0.000001))
                .Add(Area.SquareCentimeter, new LinearConverter(ratio: 0.0001))
                .Add(Area.SquareInch, new LinearConverter(ratio: 0.00064516))
                .Add(Area.SquareMile, new LinearConverter(ratio: 2589988.110336))
                .Add(Area.SquareKilometer, new LinearConverter(ratio: 1000000))
                .Add(Area.Hectare, new LinearConverter(ratio: 10000))
                .Add(Area.Hand, new LinearConverter(ratio: 0.012516104))
                .Add(Area.Paper, new LinearConverter(ratio: 0.06032246))
                .Add(Area.SoccerField, new LinearConverter(ratio: 10869.66))
                .Add(Area.Castle, new LinearConverter(ratio: 100000))
                .Add(Area.Pyeong, new LinearConverter(ratio: 400.0 / 121.0))
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
