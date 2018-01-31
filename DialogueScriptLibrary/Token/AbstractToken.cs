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
        public virtual uint Position { get; protected set; }

        /// <summary>
        /// Content of the token object.
        /// </summary>
        public virtual string Content { get; protected set; }

        public AbstractToken(string content, uint position)
        {
            this.Content = content;
            this.Position = position;
        }

        /// <summary>
        /// Performs shallow equality check.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            AbstractToken target = (AbstractToken)obj;
            return this.Content == target.Content
                   && this.Position == target.Position;
        }

        /// <summary>
        /// Gets a has code.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
