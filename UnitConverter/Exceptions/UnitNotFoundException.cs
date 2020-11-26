using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UnitConverter.Exceptions
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
