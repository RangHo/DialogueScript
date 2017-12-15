using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Token
{
    internal sealed class StringToken : AbstractToken
    {
        private string _content;

        public override string Content
        {
            get
            {
                return this._content;
            }
            protected set
            {
                this._content = value.Replace("\\n", "\n")
                                     .Replace("\\t", "\t")
                                     .Replace("\\\"", "\"")
                                     .Replace("\\'", "\"")
                                     .Replace("\\“", "\"")
                                     .Replace("\\”", "\"")
                                     .Replace("\\‘", "\"")
                                     .Replace("\\’", "\"");
                StringBuilder sb = new StringBuilder();

                bool escaped = false;
                foreach(char temp in value)
                {
                    if (escaped)
                        switch (temp)
                        {
                            
                        }
                }
            }
        }

        public StringToken(string content) : base(content) { }
    }
}
