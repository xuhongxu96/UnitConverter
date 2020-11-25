using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;

namespace Microsoft.UnitConverter.Defaults
{
    public static class DefaultUnits
    {
        public static class Area
        {
            private static readonly Category _cat = DefaultCategories.Area;

            public static readonly Unit Acre = new Unit(_cat, nameof(Acre));
            public static readonly Unit SquareMeter = new Unit(_cat, nameof(SquareMeter));
            public static readonly Unit SquareFoot = new Unit(_cat, nameof(SquareFoot));
            public static readonly Unit SquareYard = new Unit(_cat, nameof(SquareYard));
            public static readonly Unit SquareMillimeter = new Unit(_cat, nameof(SquareMillimeter));
            public static readonly Unit SquareCentimeter = new Unit(_cat, nameof(SquareCentimeter));
            public static readonly Unit SquareInch = new Unit(_cat, nameof(SquareInch));
            public static readonly Unit SquareMile = new Unit(_cat, nameof(SquareMile));
            public static readonly Unit SquareKilometer = new Unit(_cat, nameof(SquareKilometer));
            public static readonly Unit Hectare = new Unit(_cat, nameof(Hectare));
            public static readonly Unit Hand = new Unit(_cat, nameof(Hand));
            public static readonly Unit Paper = new Unit(_cat, nameof(Paper));
            public static readonly Unit SoccerField = new Unit(_cat, nameof(SoccerField));
            public static readonly Unit Castle = new Unit(_cat, nameof(Castle));
            public static readonly Unit Pyeong = new Unit(_cat, nameof(Pyeong));
        }

        public static class Data
        {
            private static readonly Category _cat = DefaultCategories.Data;

            public static readonly Unit Bit = new Unit(_cat, nameof(Bit));
            public static readonly Unit Byte = new Unit(_cat, nameof(Byte));
            public static readonly Unit Kilobyte = new Unit(_cat, nameof(Kilobyte));
            public static readonly Unit Megabyte = new Unit(_cat, nameof(Megabyte));
            public static readonly Unit Gigabyte = new Unit(_cat, nameof(Gigabyte));
            public static readonly Unit Terabyte = new Unit(_cat, nameof(Terabyte));
            public static readonly Unit Petabyte = new Unit(_cat, nameof(Petabyte));
            public static readonly Unit Exabytes = new Unit(_cat, nameof(Exabytes));
            public static readonly Unit Zetabytes = new Unit(_cat, nameof(Zetabytes));
            public static readonly Unit Yottabyte = new Unit(_cat, nameof(Yottabyte));
            public static readonly Unit Kilobit = new Unit(_cat, nameof(Kilobit));
            public static readonly Unit Megabit = new Unit(_cat, nameof(Megabit));
            public static readonly Unit Gigabit = new Unit(_cat, nameof(Gigabit));
            public static readonly Unit Terabit = new Unit(_cat, nameof(Terabit));
            public static readonly Unit Petabit = new Unit(_cat, nameof(Petabit));
            public static readonly Unit Exabits = new Unit(_cat, nameof(Exabits));
            public static readonly Unit Zetabits = new Unit(_cat, nameof(Zetabits));
            public static readonly Unit Yottabit = new Unit(_cat, nameof(Yottabit));
            public static readonly Unit Gibibits = new Unit(_cat, nameof(Gibibits));
            public static readonly Unit Gibibytes = new Unit(_cat, nameof(Gibibytes));
            public static readonly Unit Kibibits = new Unit(_cat, nameof(Kibibits));
            public static readonly Unit Kibibytes = new Unit(_cat, nameof(Kibibytes));
            public static readonly Unit Mebibits = new Unit(_cat, nameof(Mebibits));
            public static readonly Unit Mebibytes = new Unit(_cat, nameof(Mebibytes));
            public static readonly Unit Pebibits = new Unit(_cat, nameof(Pebibits));
            public static readonly Unit Pebibytes = new Unit(_cat, nameof(Pebibytes));
            public static readonly Unit Tebibits = new Unit(_cat, nameof(Tebibits));
            public static readonly Unit Tebibytes = new Unit(_cat, nameof(Tebibytes));
            public static readonly Unit Exbibits = new Unit(_cat, nameof(Exbibits));
            public static readonly Unit Exbibytes = new Unit(_cat, nameof(Exbibytes));
            public static readonly Unit Zebibits = new Unit(_cat, nameof(Zebibits));
            public static readonly Unit Zebibytes = new Unit(_cat, nameof(Zebibytes));
            public static readonly Unit Yobibits = new Unit(_cat, nameof(Yobibits));
            public static readonly Unit Yobibytes = new Unit(_cat, nameof(Yobibytes));
            public static readonly Unit FloppyDisk = new Unit(_cat, nameof(FloppyDisk));
            public static readonly Unit CD = new Unit(_cat, nameof(CD));
            public static readonly Unit DVD = new Unit(_cat, nameof(DVD));
        }

        public static UnitRepository AddAreaUnits(this UnitRepository unitRepository)
        {
            return unitRepository
                .Add(new UnitProperties(Area.Acre))
                .Add(new UnitProperties(Area.SquareMeter))
                .Add(new UnitProperties(Area.SquareFoot))
                .Add(new UnitProperties(Area.SquareYard))
                .Add(new UnitProperties(Area.SquareMillimeter))
                .Add(new UnitProperties(Area.SquareCentimeter))
                .Add(new UnitProperties(Area.SquareInch))
                .Add(new UnitProperties(Area.SquareMile))
                .Add(new UnitProperties(Area.SquareKilometer))
                .Add(new UnitProperties(Area.Hectare))
                .Add(new UnitProperties(Area.Hand) { IsWhimsical = true })
                .Add(new UnitProperties(Area.Paper) { IsWhimsical = true })
                .Add(new UnitProperties(Area.SoccerField) { IsWhimsical = true })
                .Add(new UnitProperties(Area.Castle) { IsWhimsical = true })
                .Add(new UnitProperties(Area.Pyeong))
                ;
        }

        public static UnitRepository AddDataUnits(this UnitRepository unitRepository)
        {
            return unitRepository
                .Add(new UnitProperties(Data.Bit))
                .Add(new UnitProperties(Data.Byte))
                .Add(new UnitProperties(Data.Kilobyte))
                .Add(new UnitProperties(Data.Megabyte))
                .Add(new UnitProperties(Data.Gigabyte))
                .Add(new UnitProperties(Data.Terabyte))
                .Add(new UnitProperties(Data.Petabyte))
                .Add(new UnitProperties(Data.Exabytes))
                .Add(new UnitProperties(Data.Zetabytes))
                .Add(new UnitProperties(Data.Yottabyte))
                .Add(new UnitProperties(Data.Kilobit))
                .Add(new UnitProperties(Data.Megabit))
                .Add(new UnitProperties(Data.Gigabit))
                .Add(new UnitProperties(Data.Terabit))
                .Add(new UnitProperties(Data.Petabit))
                .Add(new UnitProperties(Data.Exabits))
                .Add(new UnitProperties(Data.Zetabits))
                .Add(new UnitProperties(Data.Yottabit))
                .Add(new UnitProperties(Data.Gibibits))
                .Add(new UnitProperties(Data.Gibibytes))
                .Add(new UnitProperties(Data.Kibibits))
                .Add(new UnitProperties(Data.Kibibytes))
                .Add(new UnitProperties(Data.Mebibits))
                .Add(new UnitProperties(Data.Mebibytes))
                .Add(new UnitProperties(Data.Pebibits))
                .Add(new UnitProperties(Data.Pebibytes))
                .Add(new UnitProperties(Data.Tebibits))
                .Add(new UnitProperties(Data.Tebibytes))
                .Add(new UnitProperties(Data.Exbibits))
                .Add(new UnitProperties(Data.Exbibytes))
                .Add(new UnitProperties(Data.Zebibits))
                .Add(new UnitProperties(Data.Zebibytes))
                .Add(new UnitProperties(Data.Yobibits))
                .Add(new UnitProperties(Data.Yobibytes))
                .Add(new UnitProperties(Data.FloppyDisk) { IsWhimsical = true })
                .Add(new UnitProperties(Data.CD) { IsWhimsical = true })
                .Add(new UnitProperties(Data.DVD) { IsWhimsical = true })
                ;
        }

        public static UnitRepository CreateRepository()
        {
            var res = new UnitRepository();
            return res
                .AddAreaUnits()
                .AddDataUnits()
                ;
        }
    }
}
