using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.UnitConverter.Exceptions
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
