using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.AST
{
    public abstract class Node
    {
        /// <summary>
        /// Name of the AST node
        /// </summary>
        public virtual string Name { get => "Node"; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
