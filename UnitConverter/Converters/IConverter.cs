using Microsoft.UnitConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.UnitConverter.Converters
{
    public interface IConverter
    {
        double ConvertToPivotValue(double value);
        double ConvertFromPivotValue(double value);
    }
}
