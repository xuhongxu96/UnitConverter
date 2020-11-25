using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.UnitConverter.Exceptions
{
    public class DuplicateUnitException : Exception
    {
        public DuplicateUnitException()
        {
        }

        public DuplicateUnitException(string message) : base(message)
        {
        }

        public DuplicateUnitException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicateUnitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
