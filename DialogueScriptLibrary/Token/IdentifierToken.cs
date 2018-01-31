using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    /// <summary>
    /// Token object that represents identifiers
    /// </summary>
    internal sealed class IdentifierToken : WordToken
    {
        public IdentifierToken(string content, uint position) : base(content, position) { }
    }
}
