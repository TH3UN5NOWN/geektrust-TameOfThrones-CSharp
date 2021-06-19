using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones.CustomExceptions
{
    [System.Serializable]
    public class KingdomNotFoundException : Exception
    {
        public KingdomNotFoundException() { }
        public KingdomNotFoundException(string message) : base(message) { }
        public KingdomNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected KingdomNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}