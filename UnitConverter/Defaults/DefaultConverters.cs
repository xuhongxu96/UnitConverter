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

        public static ConverterRepository AddDataConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(Data.Bit, new LinearConverter(ratio: 0.000000125))
                .Add(Data.Byte, new LinearConverter(ratio: 0.000001))
                .Add(Data.Kilobyte, new LinearConverter(ratio: 0.001))
                .Add(Data.Megabyte, new LinearConverter(ratio: 1))
                .Add(Data.Gigabyte, new LinearConverter(ratio: 1000))
                .Add(Data.Terabyte, new LinearConverter(ratio: 1000000))
                .Add(Data.Petabyte, new LinearConverter(ratio: 1000000000))
                .Add(Data.Exabytes, new LinearConverter(ratio: 1000000000000))
                .Add(Data.Zetabytes, new LinearConverter(ratio: 1000000000000000))
                .Add(Data.Yottabyte, new LinearConverter(ratio: 1000000000000000000))
                .Add(Data.Kilobit, new LinearConverter(ratio: 0.000125))
                .Add(Data.Megabit, new LinearConverter(ratio: 0.125))
                .Add(Data.Gigabit, new LinearConverter(ratio: 125))
                .Add(Data.Terabit, new LinearConverter(ratio: 125000))
                .Add(Data.Petabit, new LinearConverter(ratio: 125000000))
                .Add(Data.Exabits, new LinearConverter(ratio: 125000000000))
                .Add(Data.Zetabits, new LinearConverter(ratio: 125000000000000))
                .Add(Data.Yottabit, new LinearConverter(ratio: 125000000000000000))
                .Add(Data.Gibibits, new LinearConverter(ratio: 134.217728))
                .Add(Data.Gibibytes, new LinearConverter(ratio: 1073.741824))
                .Add(Data.Kibibits, new LinearConverter(ratio: 0.000128))
                .Add(Data.Kibibytes, new LinearConverter(ratio: 0.001024))
                .Add(Data.Mebibits, new LinearConverter(ratio: 0.131072))
                .Add(Data.Mebibytes, new LinearConverter(ratio: 1.048576))
                .Add(Data.Pebibits, new LinearConverter(ratio: 140737488.355328))
                .Add(Data.Pebibytes, new LinearConverter(ratio: 1125899906.842624))
                .Add(Data.Tebibits, new LinearConverter(ratio: 137438.953472))
                .Add(Data.Tebibytes, new LinearConverter(ratio: 1099511.627776))
                .Add(Data.Exbibits, new LinearConverter(ratio: 144115188075.855872))
                .Add(Data.Exbibytes, new LinearConverter(ratio: 1152921504606.846976))
                .Add(Data.Zebibits, new LinearConverter(ratio: 147573952589676.412928))
                .Add(Data.Zebibytes, new LinearConverter(ratio: 1180591620717411.303424))
                .Add(Data.Yobibits, new LinearConverter(ratio: 151115727451828646.838272))
                .Add(Data.Yobibytes, new LinearConverter(ratio: 1208925819614629174.706176))
                .Add(Data.FloppyDisk, new LinearConverter(ratio: 1.474560))
                .Add(Data.CD, new LinearConverter(ratio: 734.003200))
                .Add(Data.DVD, new LinearConverter(ratio: 5046.586573))
                ;
        }

        public static ConverterRepository CreateRepository()
        {
            var res = new ConverterRepository();
            return res
                .AddAreaConverters()
                .AddDataConverters()
                ;
        }
    }
}
