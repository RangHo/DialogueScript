using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using RangHo.DialogueScript;
using RangHo.DialogueScript.Token;
using RangHo.DialogueScript.Utility;

namespace RangHo.DialogueScript.Test
{
    [TestFixture]
    public class LexerTest
    {        
        [Test]
        public void TestSayStatement()
        {
            string testScript = "character : \"Hello, world!\"";
            Lexer lexer = new Lexer(testScript);
            Console.WriteLine("Lexer is initialized.");

            AbstractToken[] tokens = lexer.ReadAll();
            Console.WriteLine("Finished reading tokens.");
            AbstractToken[] expected =
            {
                new IdentifierToken("character"),
                new PunctuationToken(":"),
                new StringToken("Hello, world!")
            };

            for (int i = 0; i < tokens.Length; i++)
            {
                Assert.That(tokens[i].Content, Is.EqualTo(expected[i].Content));
                Console.WriteLine(tokens[i]);
            }
        }

        [Test]
        public void TestComment()
        {
            string testScript = "# this is a comment \n"
                                + "character: \"Hello, world!\"";
            Lexer lexer = new Lexer(testScript);
            Console.WriteLine("Lexer is initialized.");

            AbstractToken[] tokens = lexer.ReadAll();
            Console.WriteLine("Finished reading tokens.");
            AbstractToken[] expected =
            {
                new NewLineToken(),
                new IdentifierToken("character"),
                new PunctuationToken(":"),
                new StringToken("Hello, world!")
            };

            for (int i = 0; i < tokens.Length; i++)
            {
                Assert.That(tokens[i].Content,
                       Is.EqualTo(expected[i].Content));
                Console.WriteLine(tokens[i]);
            }
        }
    }
}
