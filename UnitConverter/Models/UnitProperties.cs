using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.UnitConverter.Models
{
    public class UnitProperties
    {
        public Unit Key { get; init; }
        public string AccessibleName { get; init; }
        public string[] Abbreviations { get; init; } = new string[] { };
        public bool IsWhimsical { get; init; } = false;

        public Category Category => Key.Category;
        public string Name => Key.UnitName;
    }
}
