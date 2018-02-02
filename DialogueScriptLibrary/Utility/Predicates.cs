using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Utility
{
    /// <summary>
    /// Some pre-defined predicates to make my life easier.
    /// </summary>
    public static class Predicates
    {

        /// <summary>
        /// List of built-in keywords
        /// </summary>
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

        /// <summary>
        /// Checks if the character is a whitespace character
        /// </summary>
        /// <param name="target">Character to check</param>
        /// <returns>True if whitespace</returns>
        public static bool IsWhitespace(char target)
            => " \r\t".Contains(target); // Thank you CRLF for ruining everything

        /// <summary>
        /// Checks if the character is an operator character
        /// </summary>
        /// <param name="target">Character to check</param>
        /// <returns>True if operator</returns>
        public static bool IsOperator(char target)
            => "=+-*/%!><&|".Contains(target);

        /// <summary>
        /// Checks if the character is a punctuation character
        /// </summary>
        /// <param name="target">Character to check</param>
        /// <returns>True if punctuation</returns>
        public static bool IsPunctuation(char target)
            => ".,:;(){}[]".Contains(target);

        /// <summary>
        /// Checks if the character can be a string
        /// </summary>
        /// <param name="target">Character to check</param>
        /// <returns>True if string</returns>
        public static bool IsStringDelimiter(char target)
            => "\"“”‘’'`".Contains(target);     // Fuck the "smart quote" feature

        /// <summary>
        /// Checks if the character can be the beginning of a number
        /// </summary>
        /// <param name="target">Character to check</param>
        /// <returns>True if number beginning</returns>
        public static bool IsNumberBeginning(char target)
            => "0123456789".Contains(target);

        /// <summary>
        /// Checks if the character can be a number
        /// </summary>
        /// <param name="target">Character to check</param>
        /// <returns>True if number</returns>
        public static bool IsNumber(char target)
            => "0123456789.".Contains(target);

        /// <summary>
        /// Checks if the character can be the beginning of an identifier
        /// </summary>
        /// <param name="target">Character to check</param>
        /// <returns>True if indentifier beginning</returns>
        public static bool IsIdentifierBeginning(char target)
            => ("ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                + "abcdefghijklmnopqrstuvwxyz_").Contains(target);

        /// <summary>
        /// Checks if the character can be an indentifier
        /// </summary>
        /// <param name="target">Character to check</param>
        /// <returns>True if identifier</returns>
        public static bool IsIdentifier(char target)
            => ("ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                + "abcdefghijklmnopqrstuvwxyz_"
                + "0123456789").Contains(target);

        /// <summary>
        /// Check if the string is one of the keywords
        /// </summary>
        /// <param name="target">String to check</param>
        /// <returns>True if keyword</returns>
        public static bool IsKeyword(string target)
            => Predicates.Keywords.Contains<string>(target);
    }
}
