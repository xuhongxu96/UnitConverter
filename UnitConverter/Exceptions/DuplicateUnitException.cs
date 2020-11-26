using System;
using System.Runtime.Serialization;

namespace UnitConverter.Exceptions
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
