using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptionTask
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException()
            : base()
        {
        }

        public NegativeNumberException(String message)
            : base(message)
        {
        }

        public NegativeNumberException(String message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected NegativeNumberException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

    }
}
