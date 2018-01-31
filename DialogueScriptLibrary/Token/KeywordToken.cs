using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    /// <summary>
    /// Token object that represents keywords
    /// </summary>
    internal sealed class KeywordToken : WordToken
    {
        public KeywordToken(string content, uint position) : base(content, position) { }
    }
}
