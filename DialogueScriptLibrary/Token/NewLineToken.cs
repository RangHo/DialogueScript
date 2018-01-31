using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    /// <summary>
    /// Token object that represents the end of line
    /// </summary>
    internal sealed class NewLineToken : AbstractToken
    {
        public NewLineToken(uint position) : base(Environment.NewLine, position) { }

        public NewLineToken(string content, uint position) : base(content, position) { }
    }
}
