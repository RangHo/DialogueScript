using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    /// <summary>
    /// Token object that represents a word (identifier or keyword)
    /// </summary>
    internal class WordToken : AbstractToken
    {
        public WordToken(string content, uint position) : base(content, position) { }
    }
}
