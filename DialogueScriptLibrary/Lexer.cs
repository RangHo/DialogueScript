using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RangHo.DialogueScript.Token;
using RangHo.DialogueScript.Utility;

namespace RangHo.DialogueScript
{
    internal class Lexer
    {
        private InputReader<char> _input;

        /// <summary>
        /// Delegate that represents the predicate functions.
        /// </summary>
        /// <param name="target">Character to check against.</param>
        /// <returns>True if availability check succeeds</returns>
        public delegate bool Condition(char target);

        /// <summary>
        /// Initializes new Lexer object
        /// </summary>
        /// <param name="input">Script to process</param>
        public Lexer(string input)
        {
            this._input = new InputReader<char>(input.ToCharArray());
        }

        /// <summary>
        /// Process all characters in the input stream.
        /// </summary>
        /// <returns>Array of tokens that are processed.</returns>
        public AbstractToken[] ReadAll()
        {
            List<AbstractToken> result = new List<AbstractToken>();

            AbstractToken token = null;
            while (true)
            {
                token = ReadNext();

                if (token == null)
                    break;

                result.Add(token);
            }

            return result.ToArray();
        }

        /// <summary>
        /// Processes next token and returns it.
        /// </summary>
        /// <returns>Type of <see cref="AbstractToken"/> object</returns>
        public AbstractToken ReadNext()
        {
            // Remove all unnecessary whitespace characters
            ReadWhile(Predicates.IsWhitespace);

            if (this._input.IsEnd)
                return null;

            char target = this._input.Peek();
            AbstractToken token = null;

            // Comment
            if (target == '#')
                token = ReadComment();

            // New line start
            else if (target == '\n')
                token = ReadNewLine();

            // String literal
            else if (Predicates.IsStringDelimiter(target))
                token = ReadString();

            // Number literal
            else if (Predicates.IsNumberBeginning(target))
                token = ReadNumber();

            // Word (Identifiers & Keywords)
            else if (Predicates.IsIdentifierBeginning(target))
                token = ReadWord();

            // Operator
            else if (Predicates.IsOperator(target))
                token = ReadOperator();

            // Punctuation
            else if (Predicates.IsPunctuation(target))
                token = ReadPunctuation();

            // Other unprocessable characters
            else
                throw new UnexpectedCharacterException("Cannot handle character: " + target);

            return token;
        }

        /// <summary>
        /// Read characters while predicate returns true.
        /// </summary>
        /// <param name="predicate">This determines whether or not to continue.</param>
        /// <returns>Read characters in <see cref="string"/></returns>
        public string ReadWhile(Condition predicate)
        {
            StringBuilder sb = new StringBuilder();

            while (!this._input.IsEnd && predicate(this._input.Peek()))
                sb.Append(this._input.Read());

            return sb.ToString();
        }

        /// <summary>
        /// Read characters until the predicate returns true.
        /// </summary>
        /// <param name="predicate">This determines whether or not to continue.</param>
        /// <returns>Read characters in <see cref="string"/></returns>
        private string ReadUntil(Condition predicate)
        {
            StringBuilder sb = new StringBuilder();
            
            while (!predicate(this._input.Peek()))
            {
                char temp = this._input.Read();

                if (this._input.IsEnd)
                    throw new UnexpectedCharacterException("Input is terminated while reading a token.");
                if (temp == '\n')
                    throw new UnexpectedCharacterException("NewLine character encountered while reading a token.");

                sb.Append(temp);
            }

            return sb.ToString();
        }

        private AbstractToken ReadComment()
        {
            ReadUntil((char target) => target == '\n'); // Read until \n
            return ReadNext();
        }

        private StringToken ReadString()
        {
            uint position = this._input.Position;

            this._input.Read(); // Removes " character

            StringBuilder sb = new StringBuilder();
            
            string target;
            // This loop ensures all escaped characters to be included
            while (true)
            {
                target = ReadUntil(Predicates.IsStringDelimiter);
                sb.Append(target);

                Console.WriteLine(target);

                if (target.EndsWith("\\"))
                {
                    sb.Append(this._input.Read());  // Read and add escaped string delimiter
                    continue;                       // ...and start the process again
                }

                break;
            }

            this._input.Read(); // Removes trailling " character

            return new StringToken(sb.ToString(), position);
        }

        private NumberToken ReadNumber()
        {
            uint position = this._input.Position;
            string str = ReadWhile(Predicates.IsNumber);
            return new NumberToken(str, position);
        }

        private WordToken ReadWord()
        {
            uint position = this._input.Position;
            string str = ReadWhile(Predicates.IsIdentifier);

            if (Predicates.IsKeyword(str))
                return new KeywordToken(str, position);
            else
                return new IdentifierToken(str, position);
        }

        private OperatorToken ReadOperator()
        {
            throw new NotImplementedException("Operators are not implemented yet.");
            // TODO: Implement Operators
            //       They must be fully operational, including operator
            //       execution order.
        }

        private PunctuationToken ReadPunctuation()
        {
            uint position = this._input.Position;
            char input = this._input.Read();
            return new PunctuationToken(input.ToString(), position);
        }

        private NewLineToken ReadNewLine()
        {
            uint position = this._input.Position;
            this._input.Read(); // Removes \n character
            return new NewLineToken(position);
        }
    }
}
