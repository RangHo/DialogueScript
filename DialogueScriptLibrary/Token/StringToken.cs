using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using RangHo.DialogueScript.Utility;

namespace RangHo.DialogueScript.Token
{
    /// <summary>
    /// Token object that represents string literals
    /// </summary>
    public sealed class StringToken : AbstractToken
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
                StringBuilder sb = new StringBuilder();
                char[] valueArray = value.ToCharArray();

                bool escaped = false;
                for (int i = 0; i < valueArray.Length; i++)
                {
                    // Handles escaped characters.
                    if (escaped)
                    {
                        string escapedStr;

                        switch (valueArray[i])
                        {
                            // NewLine character
                            case 'n':
                                escapedStr = Environment.NewLine;
                                break;
                            
                            // Tab character
                            case 't':
                                escapedStr = "\t";
                                break;

                            // String quotation mark (and fuck you "Smart Quote" feature)
                            case '"':
                            case '\'':
                            case '“':
                            case '”':
                            case '‘':
                            case '’':
                            case '`':
                                escapedStr = "\"";
                                break;
                            
                            // Unicode letter
                            case 'u':
                                string unicodeValueStr = string.Empty;
                                for (int j = 1; j <= 4; i++, j++)   // Adds 1 to i after execution
                                    unicodeValueStr += valueArray[i + j];

                                int unicodeValue = int.Parse(unicodeValueStr, NumberStyles.HexNumber);
                                escapedStr = string.Empty + Convert.ToChar(unicodeValue);
                                break;

                            default:
                                throw new UnexpectedCharacterException("Unknown escape sequence detected.");
                        }
                        escaped = false;
                    }
                    else if (valueArray[i] == '\\')
                        escaped = true;
                    else
                        sb.Append(valueArray[i]);

                    this._content = sb.ToString();
                }
            }
        }

        public StringToken(string content, uint position) : base(content, position) { }

        public static bool IsEscape(char escaped) => escaped == '\\';
    }
}
