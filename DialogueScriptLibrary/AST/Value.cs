using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.AST
{
    internal abstract class Value<T> : Node
    {
        public override string Name { get => $"Value[{typeof(T).ToString()}]"; }

        public virtual T Content { get; private set; }

        
    }

    internal abstract class Value : Value<object> { }
}
