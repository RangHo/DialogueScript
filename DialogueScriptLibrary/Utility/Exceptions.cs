using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Utility
{

    [Serializable]
    public class UnexpectedTerminationException : Exception
    {
        public UnexpectedTerminationException() { }
        public UnexpectedTerminationException(string message) : base(message) { }
        public UnexpectedTerminationException(string message, Exception inner) : base(message, inner) { }
        protected UnexpectedTerminationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    
    [Serializable]
    public class UnexpectedCharacterException : Exception
    {
        public UnexpectedCharacterException() { }
        public UnexpectedCharacterException(string message) : base(message) { }
        public UnexpectedCharacterException(string message, Exception inner) : base(message, inner) { }
        protected UnexpectedCharacterException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class UnexpectedTokenException : Exception
    {
        public UnexpectedTokenException() { }
        public UnexpectedTokenException(string message) : base(message) { }
        public UnexpectedTokenException(string message, Exception inner) : base(message, inner) { }
        protected UnexpectedTokenException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
