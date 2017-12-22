using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    /// <summary>
    /// Base class that all token objects must be derived from.
    /// </summary>
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

        public override bool Equals(object obj)
        {
            AbstractToken target = (AbstractToken)obj;
            return this.Content == target.Content;
        }
    }
}
