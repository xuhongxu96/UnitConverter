using System;
using System.Runtime.Serialization;

namespace UnitConverter.Exceptions
{
    public class DifferentCategoryException : Exception
    {
        public DifferentCategoryException()
        {
        }

        public DifferentCategoryException(string message) : base(message)
        {
        }

        public DifferentCategoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DifferentCategoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
