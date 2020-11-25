using Microsoft.UnitConverter.Models;
using Microsoft.UnitConverter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static CategoryRepository CreateRepository()
        {
            var res = new CategoryRepository();
            return res
                .Add(new CategoryProperties
                {
                    Key = Area,
                    SupportsValueRange = CategoryProperties.ValueRange.Positive,
                })
                .Add(new CategoryProperties
                {
                    Key = Length,
                    SupportsValueRange = CategoryProperties.ValueRange.Positive,
                })
                .Add(new CategoryProperties
                {
                    Key = Weight,
                    SupportsValueRange = CategoryProperties.ValueRange.Positive,
                })
                ;
        }
    }
}
