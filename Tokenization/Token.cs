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
        public string Type { set; get; }
        public string Value { set; get; }
        public Token(int position, int lineNumber, string type, string value) { }
    }
    //public abstract class Tokenizable
    //{
    //    public abstract bool tokenizable(Tokenizer tokenizer);
    //    public abstract Token tokenize(Tokenizer tokenizer);
    //    /*
    //      loop
    //     */
    //}
}
