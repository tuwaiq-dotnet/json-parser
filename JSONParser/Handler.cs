using System.Collections.Generic;
namespace JSONParser
{
    public class Handler
    {
        private List<Token> tokens;
        public JSONValue Handle(Token token, Tokenizer tokenizer){
            switch (token.Type)
            {
                case TokenType.OpeningBracket:
                    return null; // array
                case TokenType.OpeningCurlyBracket:
                    return null; // object
                case TokenType.String:
                    return null; // string
                case TokenType.Number:
                    return null; // number
                case TokenType.True:
                    return null; // true
                case TokenType.False:
                    return null; // true
                case TokenType.Null:
                    return null; // true
            }
            throw new System.Exception($@"Unexpected token ""{token.Value}"" at position {token.Position} (Line: {token.LineNumber})");
        }






        public delegate JSONValue ParseValue(Token token, Tokenizer t);
        public ParseValue getDelegate(Token token, Tokenizer t)
        {
            switch (token.Type)
            {
                case TokenType.OpeningBracket:
                    return null; // array
                case TokenType.OpeningCurlyBracket:
                    return null; // object
                case TokenType.String:
                    return null; // string
                case TokenType.Number:
                    return null; // number
                case TokenType.True:
                    return null; // true
                case TokenType.False:
                    return null; // true
                case TokenType.Null:
                    return null; // true
            }
            throw new System.Exception($@"Unexpected token ""{token.Value}"" at position {token.Position} (Line: {token.LineNumber})");
        }
    }
}