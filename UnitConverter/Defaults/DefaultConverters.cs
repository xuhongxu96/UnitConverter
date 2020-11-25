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

        public static ConverterRepository AddEnergyConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(Energy.Calorie, new LinearConverter(ratio: 4.184))
                .Add(Energy.Kilocalorie, new LinearConverter(ratio: 4184))
                .Add(Energy.BritishThermalUnit, new LinearConverter(ratio: 1055.056))
                .Add(Energy.Kilojoule, new LinearConverter(ratio: 1000))
                .Add(Energy.ElectronVolt, new LinearConverter(ratio: 0.0000000000000000001602176565))
                .Add(Energy.Joule, new LinearConverter(ratio: 1))
                .Add(Energy.FootPound, new LinearConverter(ratio: 1.3558179483314))
                .Add(Energy.Battery, new LinearConverter(ratio: 9000))
                .Add(Energy.Banana, new LinearConverter(ratio: 439614))
                .Add(Energy.SliceOfCake, new LinearConverter(ratio: 1046700))
                ;
        }

        public static ConverterRepository AddLengthConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(Length.Inch, new LinearConverter(ratio: 0.0254))
                .Add(Length.Foot, new LinearConverter(ratio: 0.3048))
                .Add(Length.Yard, new LinearConverter(ratio: 0.9144))
                .Add(Length.Mile, new LinearConverter(ratio: 1609.344))
                .Add(Length.Micron, new LinearConverter(ratio: 0.000001))
                .Add(Length.Millimeter, new LinearConverter(ratio: 0.001))
                .Add(Length.Nanometer, new LinearConverter(ratio: 0.000000001))
                .Add(Length.Centimeter, new LinearConverter(ratio: 0.01))
                .Add(Length.Meter, new LinearConverter(ratio: 1))
                .Add(Length.Kilometer, new LinearConverter(ratio: 1000))
                .Add(Length.NauticalMile, new LinearConverter(ratio: 1852))
                .Add(Length.Paperclip, new LinearConverter(ratio: 0.035052))
                .Add(Length.Hand, new LinearConverter(ratio: 0.18669))
                .Add(Length.JumboJet, new LinearConverter(ratio: 76))
                ;
        }

        public static ConverterRepository AddPowerConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(Power.BritishThermalUnitPerMinute, new LinearConverter(ratio: 17.58426666666667))
                .Add(Power.FootPoundPerMinute, new LinearConverter(ratio: 0.0225969658055233))
                .Add(Power.Watt, new LinearConverter(ratio: 1))
                .Add(Power.Kilowatt, new LinearConverter(ratio: 1000))
                .Add(Power.Horsepower, new LinearConverter(ratio: 745.69987158227022))
                .Add(Power.LightBulb, new LinearConverter(ratio: 60))
                .Add(Power.Horse, new LinearConverter(ratio: 745.7))
                .Add(Power.TrainEngine, new LinearConverter(ratio: 2982799.486329081))
                ;
        }

        public static ConverterRepository AddTimeConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(Time.Day, new LinearConverter(ratio: 86400))
                .Add(Time.Second, new LinearConverter(ratio: 1))
                .Add(Time.Week, new LinearConverter(ratio: 604800))
                .Add(Time.Year, new LinearConverter(ratio: 31557600))
                .Add(Time.Millisecond, new LinearConverter(ratio: 0.001))
                .Add(Time.Microsecond, new LinearConverter(ratio: 0.000001))
                .Add(Time.Minute, new LinearConverter(ratio: 60))
                .Add(Time.Hour, new LinearConverter(ratio: 3600))
                ;
        }

        public static ConverterRepository AddVolumeConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(Volume.CupUS, new LinearConverter(ratio: 236.588237))
                .Add(Volume.PintUS, new LinearConverter(ratio: 473.176473))
                .Add(Volume.PintUK, new LinearConverter(ratio: 568.26125))
                .Add(Volume.QuartUS, new LinearConverter(ratio: 946.352946))
                .Add(Volume.QuartUK, new LinearConverter(ratio: 1136.5225))
                .Add(Volume.GallonUS, new LinearConverter(ratio: 3785.411784))
                .Add(Volume.GallonUK, new LinearConverter(ratio: 4546.09))
                .Add(Volume.Liter, new LinearConverter(ratio: 1000))
                .Add(Volume.TeaspoonUS, new LinearConverter(ratio: 4.92892159375))
                .Add(Volume.TablespoonUS, new LinearConverter(ratio: 14.78676478125))
                .Add(Volume.CubicCentimeter, new LinearConverter(ratio: 1))
                .Add(Volume.CubicYard, new LinearConverter(ratio: 764554.857984))
                .Add(Volume.CubicMeter, new LinearConverter(ratio: 1000000))
                .Add(Volume.Milliliter, new LinearConverter(ratio: 1))
                .Add(Volume.CubicInch, new LinearConverter(ratio: 16.387064))
                .Add(Volume.CubicFoot, new LinearConverter(ratio: 28316.846592))
                .Add(Volume.FluidOunceUS, new LinearConverter(ratio: 29.5735295625))
                .Add(Volume.FluidOunceUK, new LinearConverter(ratio: 28.4130625))
                .Add(Volume.TeaspoonUK, new LinearConverter(ratio: 5.91938802083333333333))
                .Add(Volume.TablespoonUK, new LinearConverter(ratio: 17.7581640625))
                .Add(Volume.CoffeeCup, new LinearConverter(ratio: 236.5882))
                .Add(Volume.Bathtub, new LinearConverter(ratio: 378541.2))
                .Add(Volume.SwimmingPool, new LinearConverter(ratio: 3750000000))
                ;
        }

        public static ConverterRepository AddWeightConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(Weight.Kilogram, new LinearConverter(ratio: 1))
                .Add(Weight.Hectogram, new LinearConverter(ratio: 0.1))
                .Add(Weight.Decagram, new LinearConverter(ratio: 0.01))
                .Add(Weight.Gram, new LinearConverter(ratio: 0.001))
                .Add(Weight.Pound, new LinearConverter(ratio: 0.45359237))
                .Add(Weight.Ounce, new LinearConverter(ratio: 0.028349523125))
                .Add(Weight.Milligram, new LinearConverter(ratio: 0.000001))
                .Add(Weight.Centigram, new LinearConverter(ratio: 0.00001))
                .Add(Weight.Decigram, new LinearConverter(ratio: 0.0001))
                .Add(Weight.LongTon, new LinearConverter(ratio: 1016.0469088))
                .Add(Weight.Tonne, new LinearConverter(ratio: 1000))
                .Add(Weight.Stone, new LinearConverter(ratio: 6.35029318))
                .Add(Weight.Carat, new LinearConverter(ratio: 0.0002))
                .Add(Weight.ShortTon, new LinearConverter(ratio: 907.18474))
                .Add(Weight.Snowflake, new LinearConverter(ratio: 0.000002))
                .Add(Weight.SoccerBall, new LinearConverter(ratio: 0.4325))
                .Add(Weight.Elephant, new LinearConverter(ratio: 4000))
                .Add(Weight.Whale, new LinearConverter(ratio: 90000))
                ;
        }

        public static ConverterRepository AddSpeedConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(Speed.CentimetersPerSecond, new LinearConverter(ratio: 1))
                .Add(Speed.FeetPerSecond, new LinearConverter(ratio: 30.48))
                .Add(Speed.KilometersPerHour, new LinearConverter(ratio: 27.777777777777777777778))
                .Add(Speed.Knot, new LinearConverter(ratio: 51.44))
                .Add(Speed.Mach, new LinearConverter(ratio: 34030))
                .Add(Speed.MetersPerSecond, new LinearConverter(ratio: 100))
                .Add(Speed.MilesPerHour, new LinearConverter(ratio: 44.7))
                .Add(Speed.Turtle, new LinearConverter(ratio: 8.94))
                .Add(Speed.Horse, new LinearConverter(ratio: 2011.5))
                .Add(Speed.Jet, new LinearConverter(ratio: 24585))
                ;
        }

        public static ConverterRepository AddAngleConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(Angle.Degree, new LinearConverter(ratio: 1))
                .Add(Angle.Radian, new LinearConverter(ratio: 57.29577951308233))
                .Add(Angle.Gradian, new LinearConverter(ratio: 0.9))
                ;
        }

        public static ConverterRepository AddPressureConverters(this ConverterRepository converterRepository)
        {
            return converterRepository
                .Add(Pressure.Atmosphere, new LinearConverter(ratio: 1))
                .Add(Pressure.Bar, new LinearConverter(ratio: 0.9869232667160128))
                .Add(Pressure.KiloPascal, new LinearConverter(ratio: 0.0098692326671601))
                .Add(Pressure.MillimeterOfMercury, new LinearConverter(ratio: 0.0013155687145324))
                .Add(Pressure.Pascal, new LinearConverter(ratio: 9.869232667160128e-6))
                .Add(Pressure.PSI, new LinearConverter(ratio: 0.068045961016531))
                ;
        }

        public static ConverterRepository CreateRepository()
        {
            var res = new ConverterRepository();
            return res
                .AddAreaConverters()
                .AddDataConverters()
                .AddEnergyConverters()
                .AddLengthConverters()
                .AddPowerConverters()
                .AddTimeConverters()
                .AddVolumeConverters()
                .AddWeightConverters()
                .AddSpeedConverters()
                .AddAngleConverters()
                .AddPressureConverters()
                ;
        }
    }
}
