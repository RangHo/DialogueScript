using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Utility
{
    public static class ExtensionMethods
    {
        public static string ToLiteral(this string value)
        {
            using (var writer = new StringWriter())
            using (var provider = CodeDomProvider.CreateProvider("CSharp"))
            {
                provider.GenerateCodeFromExpression(new CodePrimitiveExpression(value), writer, null);
                return writer.ToString();
            }
        }
    }
}
