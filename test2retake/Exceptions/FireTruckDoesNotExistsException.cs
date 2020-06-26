using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2retake.Exceptions
{
    public class FireTruckDoesNotExistsException : Exception
    {
        public FireTruckDoesNotExistsException()
        {
        }

        public FireTruckDoesNotExistsException(string message) : base(message)
        {
        }

        public FireTruckDoesNotExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
