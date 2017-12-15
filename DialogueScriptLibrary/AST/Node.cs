using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.AST
{
    internal abstract class Node
    {
        public virtual string Name { get => "Node"; }

        public virtual int LineNumber { get; private set; }

        public abstract void Execute();

        public override string ToString()
        {
            return this.Name;
        }
    }
}
