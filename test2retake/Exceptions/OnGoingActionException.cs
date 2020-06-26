using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2retake.Exceptions
{
    public class OnGoingActionException : Exception
    {

        public OnGoingActionException()
        {
        }

        public OnGoingActionException(string message) : base(message)
        {
        }

        public OnGoingActionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
