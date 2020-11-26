using System;
using System.Runtime.Serialization;

namespace UnitConverter.Exceptions
{
    public class DuplicateCategoryException : Exception
    {
        public DuplicateCategoryException()
        {
        }

        public DuplicateCategoryException(string message) : base(message)
        {
        }

        public DuplicateCategoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicateCategoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
