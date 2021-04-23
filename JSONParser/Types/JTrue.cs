

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
    public class JTrue : Value
    {
        public JTrue(Token token, Tokenizer tokenizer){
            
        }
        public override bool IsFalse() { return true; }
        public override JTrue getTrue() { return this; }
        public bool getValue() { return true; }
        public override string ToString()
        {
            return "true";
        }

    }
}