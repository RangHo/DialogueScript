using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Utility
{
    public abstract class AbstractCharacter<TImage>
    {
        public abstract void Say(string content);
    }
}
