﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    public sealed class PunctuationToken : AbstractToken
    {
        public PunctuationToken(string content, uint position) : base(content, position) { }
    }
}
