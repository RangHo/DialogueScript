using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RangHo.DialogueScript.AST;
using RangHo.DialogueScript.Token;
using RangHo.DialogueScript.Utility;

namespace RangHo.DialogueScript
{
    public class Parser
    {
        private InputReader<AbstractToken> _input;

        private string _originalScript;

        public delegate Node ParseToken();

        public Parser(AbstractToken[] input)
        {
            this._input = new InputReader<AbstractToken>(input);
        }

        /// <summary>
        /// Initializes new Parser object.
        /// </summary>
        /// <param name="input">List of tokens read</param>
        /// <param name="original">Original raw script</param>
        /// <remarks>
        /// Though the main features do not require original scripts to be
        /// supplied, but some extensions may require it.
        /// (Namely extensions that deal with native script stuff)
        /// </remarks>
        public Parser(AbstractToken[] input, string original) : this(input)
        {
            this._originalScript = original;
        }

        public Node[] ParseAll()
        {
            
        }

        public Node ParseNext()
        {
            if (this._input.IsEnd)
                return null;

            AbstractToken target = this._input.Peek();
            Node AST = null;

            if (target is IdentifierToken)
                Maybe(ParseSay, ParseAssign, ParseOf, ParseIdentifier);
            else if (target is KeywordToken)
                ParseKeyword();
            else if (target is StringToken)
                ParseSay(); // String literal can be the character of say statement
        }

        private Node ParseKeyword()
        {
            string target = this._input.Peek().Content;
            Node AST = null;

            switch (target)
            {
                case "set":
                    AST = ParseSet();
                    break;

                case "choice":
                    AST = ParseChoice();
                    break;

                case "label":
                    AST = ParseLabel();
                    break;

                case "jump":
                    AST = ParseJump();
                    break;

                case "return":
                    AST = ParseReturn();
                    break;
            }

            return AST;
        }

        #region Value nodes

        /// <summary>
        /// Parses an identifier.
        /// </summary>
        /// <returns>Identifier AST</returns>
        private Identifier ParseIdentifier()
        {

        }

        /// <summary>
        /// Parses an Of Clause.
        /// </summary>
        /// <returns>Member AST</returns>
        private Member ParseOf()
        {

        }

        /// <summary>
        /// Parses a Dot Operator.
        /// </summary>
        /// <returns>Member AST</returns>
        private Member ParseDot()
        {
            
        }

        #endregion // Value nodes

        #region Statement nodes

        /// <summary>
        /// Parses a Say Statement
        /// </summary>
        /// <returns>Say AST</returns>
        private Say ParseSay()
        {

        }

        /// <summary>
        /// Parses a Set Statement.
        /// </summary>
        /// <returns>Assign AST</returns>
        private Assign ParseSet()
        {
            
        }

        /// <summary>
        /// Parses an Assign Statement (the one that uses =)
        /// </summary>
        /// <returns>Assign AST</returns>
        private Assign ParseAssign()
        {

        }

        /// <summary>
        /// Parses a Choice Statement
        /// </summary>
        /// <returns>Choice AST</returns>
        private Choice ParseChoice()
        {

        }

        /// <summary>
        /// Parses a Label Statement
        /// </summary>
        /// <returns>Label AST</returns>
        private Label ParseLabel()
        {

        }

        /// <summary>
        /// Parses a Jump Statement
        /// </summary>
        /// <returns>Jump AST</returns>
        private Jump ParseJump()
        {

        }

        /// <summary>
        /// Parses a Return Statement
        /// </summary>
        /// <returns>Return AST</returns>
        private Return ParseReturn()
        {

        }

        #endregion // Statement nodes

        /// <summary>
        /// Try parsing some possible candidates
        /// </summary>
        /// <param name="parsers">Parsing candidates</param>
        /// <returns>First successful parse result</returns>
        /// <remarks>
        /// The most generic candidates must be provided the last in the argument
        /// as this method goes over candidates in the order of array.
        /// </remarks>
        /// <exception cref="UnexpectedTokenException">
        /// This is thrown when <paramref name="parsers"/> does not
        /// include parser method that correctly parse given token.
        /// </exception>
        private Node Maybe(params ParseToken[] parsers)
        {
            uint prevPosition = this._input.Position;
            Node AST = null;

            foreach (var parser in parsers)
            {
                AST = parser();

                if (AST == null)    // If the current AST doesn't satisfy the requirement
                {
                    this._input.Position = prevPosition;    // Back to where we started...
                    continue;                               // Then try something else
                }

                return AST;
            }

            throw new UnexpectedTokenException("Token " + this._input.Peek() + " cannot be processed.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expected">Array of expected tokens</param>
        /// <returns></returns>
        private AbstractToken[] Expect(params Type[] expected)
        {

        }

        private bool TryExpect(out AbstractToken[] result, params Type[] expected)
        {

        }
    }
}
