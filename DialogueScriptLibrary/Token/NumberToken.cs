using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    /// <summary>
    /// Token object that represents numbers (both integers and decimals)
    /// </summary>
    public sealed class NumberToken : AbstractToken
    {
        public NumberToken(string content, uint position) : base(content, position) { }
    }
}
