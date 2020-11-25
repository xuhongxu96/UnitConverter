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

        public static UnitRepository CreateRepository()
        {
            var res = new UnitRepository();
            return res
                .AddAreaUnits()
                ;
        }
    }
}
