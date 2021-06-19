using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones.CustomExceptions
{
    class InvalidInputFormatException : Exception
    {
        public InvalidInputFormatException() { }
        public InvalidInputFormatException(string message) : base(message) { }
        public InvalidInputFormatException(string message, Exception inner) : base(message, inner) { }
        protected InvalidInputFormatException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
