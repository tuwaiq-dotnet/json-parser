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
    public class Token
    {
        public int Position { set; get; }
        public int LineNumber { set; get; }
        public TokenType Type { set; get; }
        public string Value { set; get; }
        public Token(int position, int lineNumber, TokenType type, string value) { 
            this.Position = position;
            this.LineNumber = lineNumber;
            this.Type = type;
            this.Value = value;
        }
    }

    public enum TokenType {
        OpeningBracket,
        ClosingBracket,
        OpeningCurlyBracket,
        ClosingCurlyBracket,
        Comma,
        Colon,
        WhiteSpace,
        String,
        Number,
        True,
        False,
        Null,
    }
}
