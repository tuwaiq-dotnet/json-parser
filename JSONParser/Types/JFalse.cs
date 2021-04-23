

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
    public class JFalse : Value
    {
        public JFalse(Token token, Tokenizer tokenizer){
            
        }
        public override bool IsFalse() { return true; }
        public override JFalse getFalse() { return this; }
        public bool getValue() { return false; }
        public override string ToString()
        {
            return "false";
        }
    }
}