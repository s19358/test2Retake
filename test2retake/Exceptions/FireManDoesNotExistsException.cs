using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2retake.Exceptions
{
    public class FireManDoesNotExistsException : Exception
    {
        public FireManDoesNotExistsException()
        {
        }

        public FireManDoesNotExistsException(string message) : base(message)
        {
        }

        public FireManDoesNotExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
