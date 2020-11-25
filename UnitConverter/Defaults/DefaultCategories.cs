using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;
using static Microsoft.UnitConverter.Models.CategoryProperties;

namespace Microsoft.UnitConverter.Defaults
{
    public static class DefaultCategories
    {
        public static readonly Category Area = new Category(nameof(Area));
        public static readonly Category Data = new Category(nameof(Data));
        public static readonly Category Energy = new Category(nameof(Energy));
        public static readonly Category Length = new Category(nameof(Length));
        public static readonly Category Power = new Category(nameof(Power));
        public static readonly Category Time = new Category(nameof(Time));
        public static readonly Category Volume = new Category(nameof(Volume));
        public static readonly Category Weight = new Category(nameof(Weight));
        public static readonly Category Speed = new Category(nameof(Speed));
        public static readonly Category Angle = new Category(nameof(Angle));
        public static readonly Category Pressure = new Category(nameof(Pressure));
        public static readonly Category Temperature = new Category(nameof(Temperature));

        public static CategoryRepository CreateRepository()
        {
            var res = new CategoryRepository();
            return res
                .Add(new CategoryProperties(Area))
                .Add(new CategoryProperties(Data))
                .Add(new CategoryProperties(Energy))
                .Add(new CategoryProperties(Length))
                .Add(new CategoryProperties(Power) { SupportsValueRange = ValueRange.All })
                .Add(new CategoryProperties(Time))
                .Add(new CategoryProperties(Volume))
                .Add(new CategoryProperties(Weight))
                .Add(new CategoryProperties(Speed))
                .Add(new CategoryProperties(Angle) { SupportsValueRange = ValueRange.All })
                .Add(new CategoryProperties(Pressure))
                .Add(new CategoryProperties(Temperature) { SupportsValueRange = ValueRange.All })
                ;
        }
    }
}
