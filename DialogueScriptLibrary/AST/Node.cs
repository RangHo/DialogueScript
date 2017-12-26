using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.AST
{
    internal abstract class Node
    {
        private Action _methodToExecute;

        public virtual string Name { get => "Node"; }

        public Node(Action actualMethod)
        {
            this._methodToExecute = actualMethod;
        }

        public virtual void Execute()
        {
            _methodToExecute();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
