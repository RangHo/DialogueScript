using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    internal sealed class NewLineToken : AbstractToken
    {
        public NewLineToken() : base(Environment.NewLine) { }

        public NewLineToken(string content) : base(content) { }
    }
}
