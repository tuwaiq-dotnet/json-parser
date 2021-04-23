
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
    public class StringTokenizer : Tokenizable
    {
        private const char DOUBLE_QOUTE = '"';
        private const char SLASH = '"';

        public override bool tokenizable(Tokenizer t)
        {
            return t.input.peek() == DOUBLE_QOUTE;
        }

        public override Token tokenize(Tokenizer t)
        {
            int initPos = t.input.Position;
            string val = t.input.step().Character+"";
            while(t.input.hasMore()){
                val += t.input.step().Character;
                if(t.input.Character == SLASH) val += t.input.step().Character;
                else if (t.input.Character == DOUBLE_QOUTE) return new Token(t.input.Position, t.input.LineNumber, TokenType.String, val);
            }
            throw new System.Exception($"Reached EOF without finding a closing double qoute for the one in position {initPos}"); 
        }
    }
}