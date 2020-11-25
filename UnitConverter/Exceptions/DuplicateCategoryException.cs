using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.UnitConverter.Exceptions
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
