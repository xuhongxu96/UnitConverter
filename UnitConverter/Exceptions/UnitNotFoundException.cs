using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.UnitConverter.Exceptions
{
    public class UnitNotFoundException : KeyNotFoundException
    {
        public UnitNotFoundException()
        {
        }

        public UnitNotFoundException(string message) : base(message)
        {
        }

        public UnitNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnitNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
