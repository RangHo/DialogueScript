using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Utility
{
    public class UnexpectedCharacterException : Exception
    {
        public UnexpectedCharacterException() : base() { }

        public UnexpectedCharacterException(string message) : base(message) { }

        public UnexpectedCharacterException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class UnexpectedASTException : Exception
    {
        public UnexpectedASTException() : base() { }

        public UnexpectedASTException(string message) : base(message) { }

        public UnexpectedASTException(string message, Exception innerException) : base(message, innerException) { }
    }
}
