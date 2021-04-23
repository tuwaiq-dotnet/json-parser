/*
 * Tuwaiq .NET Bootcamp | JSON Parser
 * 
 * Team Members
 * Abdulrahman Bin Maneea (Team Lead)
 * Younes Alturkey
 * Abdullah Albagshi
 * Ibrahim Alobaysi
 */
using System;

namespace JSONParser
{
    public class WhitespaceHandler : ITokenizable
    {
        public override bool tokenizable(Input input)
        {
            return Char.IsWhiteSpace(input.peek());
        }

        static bool isWhiteSpace(Input input)
        {
            return Char.IsWhiteSpace(input.peek());
        }

        public override Token tokenize(Input input)
        {
            return new Token(input.Position, input.LineNumber, TokenType.Whitespace, input.loop(isWhiteSpace));
        }
    }
}