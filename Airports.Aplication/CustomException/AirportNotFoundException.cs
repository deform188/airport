using System;
using System.Collections.Generic;
using System.Text;

namespace Airports.Aplication.CustomException
{
    public class AirportNotFoundException : Exception
    {
        public AirportNotFoundException() { }

        public AirportNotFoundException(string message)
            : base(message) { }

        public AirportNotFoundException(string message, Exception inner)
            : base(message, inner) { }
    }
}
