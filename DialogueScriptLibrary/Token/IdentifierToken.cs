using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    internal sealed class IdentifierToken : WordToken
    {
        public IdentifierToken(string content) : base(content) { }
    }
}
