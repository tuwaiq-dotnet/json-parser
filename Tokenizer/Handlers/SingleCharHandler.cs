using System;
using System.Collections.Generic;
/*
 * Tuwaiq .NET Bootcamp
 * 
 * Authors
 * 
 *  Younes Alturkey
 *  Abdulrahman Bin Maneea
 *  Abdullah Albagshi
 *  Ibrahim Alobaysi
 */

namespace JSONParser
{
    public class SingleCharHandler : Tokenizable
    {
        private List<Char> jsonCharacters = new List<Char> { ',', ':', '{', '}', '[', ']' };
        public override bool tokenizable(Input input)
        {
            return this.jsonCharacters.Contains(input.peek());
        }

        public override Token tokenize(Input input)
        {
            int initPos = input.Position;
            String val = input.step() + "";

            switch (val)
            {
                case ",":
                    return new Token(input.Position, input.LineNumber, TokenType.Comma, val);
                    break;
                case ":":
                    return new Token(input.Position, input.LineNumber, TokenType.Colon, val);
                    break;
                case "{":
                    return new Token(input.Position, input.LineNumber, TokenType.OpeningCurlyBracket, val);
                    break;
                case "}":
                    return new Token(input.Position, input.LineNumber, TokenType.ClosingCurlyBracket, val);
                    break;
                case "[":
                    return new Token(input.Position, input.LineNumber, TokenType.OpeningBracket, val);
                    break;
                case "]":
                    return new Token(input.Position, input.LineNumber, TokenType.ClosingBracket, val);
                    break;
            }
            throw new Exception("Unexpected Token");
        }
    }
}