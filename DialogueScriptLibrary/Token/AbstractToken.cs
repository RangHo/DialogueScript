using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    internal abstract class AbstractToken
    {
        public AbstractToken(string content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Content of the token object.
        /// </summary>
        public virtual string Content { get; protected set; }
    }
}
