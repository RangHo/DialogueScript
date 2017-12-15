using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    /// <summary>
    /// Token object that represents punctuations
    /// </summary>
    internal sealed class PunctuationToken : AbstractToken
    {
        public PunctuationToken(string content) : base(content) { }
    }
}
