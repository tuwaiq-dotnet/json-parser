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
        public override bool tokenizable(Tokenizer t)
        {
            return this.jsonCharacters.Contains(t.input.peek());
        }

        public override Token tokenize(Tokenizer t)
        {
            int initPos = t.input.Position;
            String val = t.input.step() + "";

            switch (val)
            {
                case ",":
                    return new Token(t.input.Position, t.input.LineNumber, TokenType.Comma, val);
                    break;
                case ":":
                    return new Token(t.input.Position, t.input.LineNumber, TokenType.Colon, val);
                    break;
                case "{":
                    return new Token(t.input.Position, t.input.LineNumber, TokenType.OpeningCurlyBracket, val);
                    break;
                case "}":
                    return new Token(t.input.Position, t.input.LineNumber, TokenType.ClosingCurlyBracket, val);
                    break;
                case "[":
                    return new Token(t.input.Position, t.input.LineNumber, TokenType.OpeningBracket, val);
                    break;
                case "]":
                    return new Token(t.input.Position, t.input.LineNumber, TokenType.ClosingBracket, val);
                    break;
            }
            throw new Exception("Unexpected Token");
        }
    }
}