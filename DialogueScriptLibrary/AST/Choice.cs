using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.AST
{
    public class Choice : Statement
    {
        /// <summary>
        /// Represents an option of a choice.
        /// </summary>
        public struct Option
        {
            /// <summary>
            /// The destination label of this option.
            /// </summary>
            public string Destination;

            /// <summary>
            /// Description of this option.
            /// </summary>
            public string Content;
        }

        /// <summary>
        /// List of options.
        /// </summary>
        public List<Option> Options { get; }

        public Choice()
        {
            this.Options = new List<Option>();
        }
    }
}
