using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.AST
{
    public abstract class Value<T> : Node
    {
        public override string Name { get => $"Value[{typeof(T).ToString()}]"; }

        public virtual T Content { get; private set; }
    }

    public abstract class Value : Value<object> { }
}
