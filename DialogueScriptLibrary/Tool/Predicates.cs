using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Tool
{
    /// <summary>
    /// Some pre-defined predicates to make my life easier.
    /// </summary>
    public static class Predicate
    {
        public static readonly string[] Keywords = {
            "set",      // Assign statement
            "of",       // Access clause
            "label",    // Label statement
            "jump",     // Jump statement
            "choice",   // Choice statement
            "begin",    // Statement Group start
            "done",     // Statement Group end
            "return",   // Return statement
            "true",     // True keyword (boolean literal)
            "false",    // False keyword (boolean literal)
            "null"      // Null keyword
        };

        public static bool IsWhitespace(char target)
            => " \r\t".Contains(target); // Thank you CRLF for ruining everything

        public static bool IsOperator(char target)
            => "=+-*/%!><&|".Contains(target);

        public static bool IsPunctuation(char target)
            => ".(){}[]:;".Contains(target);

        public static bool IsStringBeginning(char target)
            => "\"“”‘’'`".Contains(target);

        public static bool IsNumberBeginning(char target)
            => "0123456789".Contains(target);

        public static bool IsNumber(char target)
            => "0123456789.".Contains(target);

        public static bool IsIdentifierBeginning(char target)
            => ("ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                + "abcdefghijklmnopqrstuvwxyz_").Contains(target);

        public static bool IsIdentifier(char target)
            => ("ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                + "abcdefghijklmnopqrstuvwxyz_"
                + "0123456789").Contains(target);

        public static bool IsKeyword(string target)
            => Predicates.Keywords.Contains<string>(target);
    }
}
