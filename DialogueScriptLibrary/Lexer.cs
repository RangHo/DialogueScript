using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RangHo.DialogueScript.Token;
using RangHo.DialogueScript.Tool;

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

        public Lexer(string input)
        {
            this._input = new InputReader<char>(input.ToCharArray());
        }

        public AbstractToken ReadNext()
        {
            char target = this._input.Peek();
            AbstractToken token = null;

            if (target == '#')
                token = ReadComment();
            else if (target == '\n')
                token = ReadNewLine();
            else if (target == '"')
                token = ReadString();
            else if (Predicate.IsNumberBeginning(target))
                token = ReadNumber();
            else if (Predicate.IsIdentifierBeginning(target))
                token = ReadWord();
            else if (Predicate.IsOperator(target))
                token = ReadOperator();

            return token;
        }

        private string ReadWhile(Condition predicate)
        {
            StringBuilder sb = new StringBuilder();

            while (!this._input.IsEnd && predicate(this._input.Peek()))
                sb.Append(this._input.Read());

            return sb.ToString();
        }

        private string ReadWhile(char until)
        {
            StringBuilder sb = new StringBuilder();
            
            while (this._input.Peek() != until)
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
            ReadWhile('\n');
            return ReadNext();
        }

        private StringToken ReadString()
        {
            this._input.Read(); // Removes " character
            string str = ReadWhile('"');
            this._input.Read(); // Removes trailling " character

            return new StringToken(str);
        }

        private NumberToken ReadNumber()
        {
            string str = ReadWhile(Predicate.IsNumber);
            return new NumberToken(str);
        }

        private WordToken ReadWord()
        {
            string str = ReadWhile(Predicate.IsIdentifier);

            if (Predicate.IsKeyword(str))
                return new KeywordToken(str);
            else
                return new IdentifierToken(str);
        }

        private AbstractToken ReadOperator()
        {
            throw new NotImplementedException();
            // TODO: Implement Operators
            //       They must be fully operational, including operator
            //       execution order.
        }

        private AbstractToken ReadNewLine()
        {
            throw new NotImplementedException();
        }
    }
}
