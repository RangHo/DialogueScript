﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.AST
{
    public abstract class Statement : Node
    {
        public override string Name { get => "Statement"; }
    }
}
