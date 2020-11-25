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

        public static class Energy
        {
            private static readonly Category _cat = DefaultCategories.Energy;

            public static readonly Unit Bit = new Unit(_cat, nameof(Bit));
            public static readonly Unit Calorie = new Unit(_cat, nameof(Calorie));
            public static readonly Unit Kilocalorie = new Unit(_cat, nameof(Kilocalorie));
            public static readonly Unit BritishThermalUnit = new Unit(_cat, nameof(BritishThermalUnit));
            public static readonly Unit Kilojoule = new Unit(_cat, nameof(Kilojoule));
            public static readonly Unit ElectronVolt = new Unit(_cat, nameof(ElectronVolt));
            public static readonly Unit Joule = new Unit(_cat, nameof(Joule));
            public static readonly Unit FootPound = new Unit(_cat, nameof(FootPound));
            public static readonly Unit Battery = new Unit(_cat, nameof(Battery));
            public static readonly Unit Banana = new Unit(_cat, nameof(Banana));
            public static readonly Unit SliceOfCake = new Unit(_cat, nameof(SliceOfCake));
        }

        public static class Length
        {
            private static readonly Category _cat = DefaultCategories.Length;

            public static readonly Unit Inch = new Unit(_cat, nameof(Inch));
            public static readonly Unit Foot = new Unit(_cat, nameof(Foot));
            public static readonly Unit Yard = new Unit(_cat, nameof(Yard));
            public static readonly Unit Mile = new Unit(_cat, nameof(Mile));
            public static readonly Unit Micron = new Unit(_cat, nameof(Micron));
            public static readonly Unit Millimeter = new Unit(_cat, nameof(Millimeter));
            public static readonly Unit Nanometer = new Unit(_cat, nameof(Nanometer));
            public static readonly Unit Centimeter = new Unit(_cat, nameof(Centimeter));
            public static readonly Unit Meter = new Unit(_cat, nameof(Meter));
            public static readonly Unit Kilometer = new Unit(_cat, nameof(Kilometer));
            public static readonly Unit NauticalMile = new Unit(_cat, nameof(NauticalMile));
            public static readonly Unit Paperclip = new Unit(_cat, nameof(Paperclip));
            public static readonly Unit Hand = new Unit(_cat, nameof(Hand));
            public static readonly Unit JumboJet = new Unit(_cat, nameof(JumboJet));
        }

        public static class Power
        {
            private static readonly Category _cat = DefaultCategories.Power;

            public static readonly Unit BritishThermalUnitPerMinute = new Unit(_cat, nameof(BritishThermalUnitPerMinute));
            public static readonly Unit FootPoundPerMinute = new Unit(_cat, nameof(FootPoundPerMinute));
            public static readonly Unit Watt = new Unit(_cat, nameof(Watt));
            public static readonly Unit Kilowatt = new Unit(_cat, nameof(Kilowatt));
            public static readonly Unit Horsepower = new Unit(_cat, nameof(Horsepower));
            public static readonly Unit LightBulb = new Unit(_cat, nameof(LightBulb));
            public static readonly Unit Horse = new Unit(_cat, nameof(Horse));
            public static readonly Unit TrainEngine = new Unit(_cat, nameof(TrainEngine));
        }

        public static class Time
        {
            private static readonly Category _cat = DefaultCategories.Time;

            public static readonly Unit Day = new Unit(_cat, nameof(Day));
            public static readonly Unit Second = new Unit(_cat, nameof(Second));
            public static readonly Unit Week = new Unit(_cat, nameof(Week));
            public static readonly Unit Year = new Unit(_cat, nameof(Year));
            public static readonly Unit Millisecond = new Unit(_cat, nameof(Millisecond));
            public static readonly Unit Microsecond = new Unit(_cat, nameof(Microsecond));
            public static readonly Unit Minute = new Unit(_cat, nameof(Minute));
            public static readonly Unit Hour = new Unit(_cat, nameof(Hour));
        }

        public static class Volume
        {
            private static readonly Category _cat = DefaultCategories.Volume;

            public static readonly Unit CupUS = new Unit(_cat, nameof(CupUS));
            public static readonly Unit PintUS = new Unit(_cat, nameof(PintUS));
            public static readonly Unit PintUK = new Unit(_cat, nameof(PintUK));
            public static readonly Unit QuartUS = new Unit(_cat, nameof(QuartUS));
            public static readonly Unit QuartUK = new Unit(_cat, nameof(QuartUK));
            public static readonly Unit GallonUS = new Unit(_cat, nameof(GallonUS));
            public static readonly Unit GallonUK = new Unit(_cat, nameof(GallonUK));
            public static readonly Unit Liter = new Unit(_cat, nameof(Liter));
            public static readonly Unit TeaspoonUS = new Unit(_cat, nameof(TeaspoonUS));
            public static readonly Unit TablespoonUS = new Unit(_cat, nameof(TablespoonUS));
            public static readonly Unit CubicCentimeter = new Unit(_cat, nameof(CubicCentimeter));
            public static readonly Unit CubicYard = new Unit(_cat, nameof(CubicYard));
            public static readonly Unit CubicMeter = new Unit(_cat, nameof(CubicMeter));
            public static readonly Unit Milliliter = new Unit(_cat, nameof(Milliliter));
            public static readonly Unit CubicInch = new Unit(_cat, nameof(CubicInch));
            public static readonly Unit CubicFoot = new Unit(_cat, nameof(CubicFoot));
            public static readonly Unit FluidOunceUS = new Unit(_cat, nameof(FluidOunceUS));
            public static readonly Unit FluidOunceUK = new Unit(_cat, nameof(FluidOunceUK));
            public static readonly Unit TeaspoonUK = new Unit(_cat, nameof(TeaspoonUK));
            public static readonly Unit TablespoonUK = new Unit(_cat, nameof(TablespoonUK));
            public static readonly Unit CoffeeCup = new Unit(_cat, nameof(CoffeeCup));
            public static readonly Unit Bathtub = new Unit(_cat, nameof(Bathtub));
            public static readonly Unit SwimmingPool = new Unit(_cat, nameof(SwimmingPool));
        }

        public static class Weight
        {
            private static readonly Category _cat = DefaultCategories.Weight;

            public static readonly Unit Kilogram = new Unit(_cat, nameof(Kilogram));
            public static readonly Unit Hectogram = new Unit(_cat, nameof(Hectogram));
            public static readonly Unit Decagram = new Unit(_cat, nameof(Decagram));
            public static readonly Unit Gram = new Unit(_cat, nameof(Gram));
            public static readonly Unit Pound = new Unit(_cat, nameof(Pound));
            public static readonly Unit Ounce = new Unit(_cat, nameof(Ounce));
            public static readonly Unit Milligram = new Unit(_cat, nameof(Milligram));
            public static readonly Unit Centigram = new Unit(_cat, nameof(Centigram));
            public static readonly Unit Decigram = new Unit(_cat, nameof(Decigram));
            public static readonly Unit LongTon = new Unit(_cat, nameof(LongTon));
            public static readonly Unit Tonne = new Unit(_cat, nameof(Tonne));
            public static readonly Unit Stone = new Unit(_cat, nameof(Stone));
            public static readonly Unit Carat = new Unit(_cat, nameof(Carat));
            public static readonly Unit ShortTon = new Unit(_cat, nameof(ShortTon));
            public static readonly Unit Snowflake = new Unit(_cat, nameof(Snowflake));
            public static readonly Unit SoccerBall = new Unit(_cat, nameof(SoccerBall));
            public static readonly Unit Elephant = new Unit(_cat, nameof(Elephant));
            public static readonly Unit Whale = new Unit(_cat, nameof(Whale));
        }

        public static class Speed
        {
            private static readonly Category _cat = DefaultCategories.Speed;

            public static readonly Unit CentimetersPerSecond = new Unit(_cat, nameof(CentimetersPerSecond));
            public static readonly Unit FeetPerSecond = new Unit(_cat, nameof(FeetPerSecond));
            public static readonly Unit KilometersPerHour = new Unit(_cat, nameof(KilometersPerHour));
            public static readonly Unit Knot = new Unit(_cat, nameof(Knot));
            public static readonly Unit Mach = new Unit(_cat, nameof(Mach));
            public static readonly Unit MetersPerSecond = new Unit(_cat, nameof(MetersPerSecond));
            public static readonly Unit MilesPerHour = new Unit(_cat, nameof(MilesPerHour));
            public static readonly Unit Turtle = new Unit(_cat, nameof(Turtle));
            public static readonly Unit Horse = new Unit(_cat, nameof(Horse));
            public static readonly Unit Jet = new Unit(_cat, nameof(Jet));
        }

        public static class Angle
        {
            private static readonly Category _cat = DefaultCategories.Angle;

            public static readonly Unit Degree = new Unit(_cat, nameof(Degree));
            public static readonly Unit Radian = new Unit(_cat, nameof(Radian));
            public static readonly Unit Gradian = new Unit(_cat, nameof(Gradian));
        }

        public static class Pressure
        {
            private static readonly Category _cat = DefaultCategories.Pressure;

            public static readonly Unit Atmosphere = new Unit(_cat, nameof(Atmosphere));
            public static readonly Unit Bar = new Unit(_cat, nameof(Bar));
            public static readonly Unit KiloPascal = new Unit(_cat, nameof(KiloPascal));
            public static readonly Unit MillimeterOfMercury = new Unit(_cat, nameof(MillimeterOfMercury));
            public static readonly Unit Pascal = new Unit(_cat, nameof(Pascal));
            public static readonly Unit PSI = new Unit(_cat, nameof(PSI));
        }

        public static class Temperature
        {
            private static readonly Category _cat = DefaultCategories.Temperature;

            public static readonly Unit Celsius = new Unit(_cat, nameof(Celsius));
            public static readonly Unit Fahrenheit = new Unit(_cat, nameof(Fahrenheit));
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

        public static UnitRepository AddEnergyUnits(this UnitRepository unitRepository)
        {
            return unitRepository
               .Add(new UnitProperties(Energy.Calorie))
               .Add(new UnitProperties(Energy.Kilocalorie))
               .Add(new UnitProperties(Energy.BritishThermalUnit))
               .Add(new UnitProperties(Energy.Kilojoule))
               .Add(new UnitProperties(Energy.ElectronVolt))
               .Add(new UnitProperties(Energy.Joule))
               .Add(new UnitProperties(Energy.FootPound))
               .Add(new UnitProperties(Energy.Battery) { IsWhimsical = true })
               .Add(new UnitProperties(Energy.Banana) { IsWhimsical = true })
               .Add(new UnitProperties(Energy.SliceOfCake) { IsWhimsical = true })
               ;
        }

        public static UnitRepository AddLengthUnits(this UnitRepository unitRepository)
        {
            return unitRepository
               .Add(new UnitProperties(Length.Inch))
               .Add(new UnitProperties(Length.Foot))
               .Add(new UnitProperties(Length.Yard))
               .Add(new UnitProperties(Length.Mile))
               .Add(new UnitProperties(Length.Micron))
               .Add(new UnitProperties(Length.Millimeter))
               .Add(new UnitProperties(Length.Nanometer))
               .Add(new UnitProperties(Length.Centimeter))
               .Add(new UnitProperties(Length.Meter))
               .Add(new UnitProperties(Length.Kilometer))
               .Add(new UnitProperties(Length.NauticalMile))
               .Add(new UnitProperties(Length.Paperclip) { IsWhimsical = true })
               .Add(new UnitProperties(Length.Hand) { IsWhimsical = true })
               .Add(new UnitProperties(Length.JumboJet) { IsWhimsical = true })
               ;
        }

        public static UnitRepository AddPowerUnits(this UnitRepository unitRepository)
        {
            return unitRepository
               .Add(new UnitProperties(Power.BritishThermalUnitPerMinute))
               .Add(new UnitProperties(Power.FootPoundPerMinute))
               .Add(new UnitProperties(Power.Watt))
               .Add(new UnitProperties(Power.Kilowatt))
               .Add(new UnitProperties(Power.Horsepower))
               .Add(new UnitProperties(Power.LightBulb) { IsWhimsical = true })
               .Add(new UnitProperties(Power.Horse) { IsWhimsical = true })
               .Add(new UnitProperties(Power.TrainEngine) { IsWhimsical = true })
               ;
        }

        public static UnitRepository AddTimeUnits(this UnitRepository unitRepository)
        {
            return unitRepository
               .Add(new UnitProperties(Time.Day))
               .Add(new UnitProperties(Time.Second))
               .Add(new UnitProperties(Time.Week))
               .Add(new UnitProperties(Time.Year))
               .Add(new UnitProperties(Time.Millisecond))
               .Add(new UnitProperties(Time.Microsecond))
               .Add(new UnitProperties(Time.Minute))
               .Add(new UnitProperties(Time.Hour))
               ;
        }

        public static UnitRepository AddVolumeUnits(this UnitRepository unitRepository)
        {
            return unitRepository
               .Add(new UnitProperties(Volume.CupUS))
               .Add(new UnitProperties(Volume.PintUS))
               .Add(new UnitProperties(Volume.PintUK))
               .Add(new UnitProperties(Volume.QuartUS))
               .Add(new UnitProperties(Volume.QuartUK))
               .Add(new UnitProperties(Volume.GallonUS))
               .Add(new UnitProperties(Volume.GallonUK))
               .Add(new UnitProperties(Volume.Liter))
               .Add(new UnitProperties(Volume.TeaspoonUS))
               .Add(new UnitProperties(Volume.TablespoonUS))
               .Add(new UnitProperties(Volume.CubicCentimeter))
               .Add(new UnitProperties(Volume.CubicYard))
               .Add(new UnitProperties(Volume.CubicMeter))
               .Add(new UnitProperties(Volume.Milliliter))
               .Add(new UnitProperties(Volume.CubicInch))
               .Add(new UnitProperties(Volume.CubicFoot))
               .Add(new UnitProperties(Volume.FluidOunceUS))
               .Add(new UnitProperties(Volume.FluidOunceUK))
               .Add(new UnitProperties(Volume.TeaspoonUK))
               .Add(new UnitProperties(Volume.TablespoonUK))
               .Add(new UnitProperties(Volume.CoffeeCup) { IsWhimsical = true })
               .Add(new UnitProperties(Volume.Bathtub) { IsWhimsical = true })
               .Add(new UnitProperties(Volume.SwimmingPool) { IsWhimsical = true })
               ;
        }

        public static UnitRepository AddWeightUnits(this UnitRepository unitRepository)
        {
            return unitRepository
               .Add(new UnitProperties(Weight.Kilogram))
               .Add(new UnitProperties(Weight.Hectogram))
               .Add(new UnitProperties(Weight.Decagram))
               .Add(new UnitProperties(Weight.Gram))
               .Add(new UnitProperties(Weight.Pound))
               .Add(new UnitProperties(Weight.Ounce))
               .Add(new UnitProperties(Weight.Milligram))
               .Add(new UnitProperties(Weight.Centigram))
               .Add(new UnitProperties(Weight.Decigram))
               .Add(new UnitProperties(Weight.LongTon))
               .Add(new UnitProperties(Weight.Tonne))
               .Add(new UnitProperties(Weight.Stone))
               .Add(new UnitProperties(Weight.Carat))
               .Add(new UnitProperties(Weight.ShortTon))
               .Add(new UnitProperties(Weight.Snowflake) { IsWhimsical = true })
               .Add(new UnitProperties(Weight.SoccerBall) { IsWhimsical = true })
               .Add(new UnitProperties(Weight.Elephant) { IsWhimsical = true })
               .Add(new UnitProperties(Weight.Whale) { IsWhimsical = true })
               ;
        }

        public static UnitRepository AddSpeedUnits(this UnitRepository unitRepository)
        {
            return unitRepository
               .Add(new UnitProperties(Speed.CentimetersPerSecond))
               .Add(new UnitProperties(Speed.FeetPerSecond))
               .Add(new UnitProperties(Speed.KilometersPerHour))
               .Add(new UnitProperties(Speed.Knot))
               .Add(new UnitProperties(Speed.Mach))
               .Add(new UnitProperties(Speed.MetersPerSecond))
               .Add(new UnitProperties(Speed.MilesPerHour))
               .Add(new UnitProperties(Speed.Turtle) { IsWhimsical = true })
               .Add(new UnitProperties(Speed.Horse) { IsWhimsical = true })
               .Add(new UnitProperties(Speed.Jet) { IsWhimsical = true })
               ;
        }

        public static UnitRepository AddAngleUnits(this UnitRepository unitRepository)
        {
            return unitRepository
               .Add(new UnitProperties(Angle.Degree))
               .Add(new UnitProperties(Angle.Radian))
               .Add(new UnitProperties(Angle.Gradian))
               ;
        }

        public static UnitRepository AddPressureUnits(this UnitRepository unitRepository)
        {
            return unitRepository
               .Add(new UnitProperties(Pressure.Atmosphere))
               .Add(new UnitProperties(Pressure.Bar))
               .Add(new UnitProperties(Pressure.KiloPascal))
               .Add(new UnitProperties(Pressure.MillimeterOfMercury))
               .Add(new UnitProperties(Pressure.Pascal))
               .Add(new UnitProperties(Pressure.PSI))
               ;
        }

        public static UnitRepository AddTemperatureUnits(this UnitRepository unitRepository)
        {
            return unitRepository
                .Add(new UnitProperties(Temperature.Celsius))
                .Add(new UnitProperties(Temperature.Fahrenheit))
                ;
        }

        public static UnitRepository CreateRepository()
        {
            var res = new UnitRepository();
            return res
                .AddAreaUnits()
                .AddDataUnits()
                .AddEnergyUnits()
                .AddLengthUnits()
                .AddPowerUnits()
                .AddTimeUnits()
                .AddVolumeUnits()
                .AddWeightUnits()
                .AddSpeedUnits()
                .AddAngleUnits()
                .AddPressureUnits()
                .AddTemperatureUnits()
                ;
        }
    }
}
