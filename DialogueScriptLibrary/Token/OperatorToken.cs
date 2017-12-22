using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    /// <summary>
    /// Token object that represents operators
    /// </summary>
    internal sealed class OperatorToken : AbstractToken
    {
        public OperatorToken(string content) : base(content) { }
    }
}
