using Microsoft.UnitConverter.Defaults;
using Microsoft.UnitConverter.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Microsoft.UnitConverter.Defaults.DefaultUnits;

namespace UnitConverterUnitTests
{
    public class AreaTests
    {
        private static readonly ConverterRepository _repo = ConverterRepository.Default;

        [Theory]
        [InlineData(10, 4.0468564224)]
        public void TestConvert(double value, double expected)
        {
            Assert.Equal(expected, _repo.Convert(Area.Acre, Area.Hectare, value));
        }
    }
}
