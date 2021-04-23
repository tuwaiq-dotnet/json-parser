

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
    public class JSONParser
    {
        public delegate JSONValue parseValue(Token token, Tokenizer t);
        private JSONValue root;
        private int elements;
        private Tokenizer tokenizer;
        public JSONParser(string source)
        {
            tokenizer = new Tokenizer(new Input(source), new Tokenizable[]{
                new StringHandler(),
                // new SingleWordHandler(),
                // new SingleCharHandler()
            });
            Token token = tokenizer.tokenize();
            while (token.Type == TokenType.Whitespace && token != null)
            {
                token = tokenizer.tokenize();
                if (token == null)
                {
                    return;
                }
            }
            parseValue deleg = getDelegate(token, tokenizer);
            root = deleg(token, tokenizer);
        }

        public parseValue getDelegate(Token token, Tokenizer t)
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